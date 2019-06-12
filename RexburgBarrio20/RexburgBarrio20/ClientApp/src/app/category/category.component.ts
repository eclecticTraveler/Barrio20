import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-category-component',
  templateUrl: './category.component.html',
})
export class CategoryComponent {
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
