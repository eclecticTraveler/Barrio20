import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-suggestion-component',
  templateUrl: './suggestion.component.html',
})
export class SuggestionComponent {
  public categories: Category[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Category[]>(baseUrl + 'api/SuggestionsByCategory/GetSuggestionsByCategories').subscribe(result => {
      this.categories = result;
      console.log(this.categories);
      console.log("igiyiytf");
    }, error => console.error(error));
  }
}

interface Category {
  name: string;
  numberOfVisits: number;
}
