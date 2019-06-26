import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'work-experience',
  templateUrl: './work-experience.component.html'
})
export class WorkExperienceComponent {
  public workExperiences: WorkExperience[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<WorkExperience[]>(baseUrl + 'api/WorkExperience/GetWorkExperience').subscribe(result => {
      this.workExperiences = result;
    }, error => console.error(error));
  }
}

interface WorkExperience {
  companyName: string,
  position: string,
  dateStart: string,
  endDate: string,
  duties: string,
  notableProjects: string[]
}
