import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'myapp';

  fruits = ['Strawberry', 'Banana', 'Orange', 'Grapes'];

  newFruit:string = "";

  addFruit() : void {
    this.fruits.push(this.newFruit);
  }

  name:string = "Jonathan";
}
