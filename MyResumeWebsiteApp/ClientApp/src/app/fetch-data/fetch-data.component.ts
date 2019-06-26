import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public skills: Skill[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Skill[]>(baseUrl + 'api/ProgrammingLanguage/ProgrammingLanguages').subscribe(result => {
      this.skills = result;
    }, error => console.error(error));
  }
}

interface Skill {
  languageName: string;
  programmingLanguageLevel: number,
  skillsUsed: string;
}
