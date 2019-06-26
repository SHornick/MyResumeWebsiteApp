import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'education',
  templateUrl: './education.component.html'
})
export class EducationComponent {
  public schools: School[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<School[]>(baseUrl + 'api/Education/GetSchoolList').subscribe(result => {
      this.schools = result;
    }, error => console.error(error));
  }
}

interface School {
  name: string;
  location: string,
  major: string,
  startDate: string,
  endDate: string;
}
