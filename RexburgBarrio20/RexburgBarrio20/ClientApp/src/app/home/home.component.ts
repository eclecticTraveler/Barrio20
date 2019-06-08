import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
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
