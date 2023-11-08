import { Component } from '@angular/core';
import { MenuItem } from './models/MenuItem';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ChirpusPizza';

  MenuItems:MenuItem[] = [
    { Name: "Chicken Fingers", Category: "dinner", Price: 11.99},
    { Name: "Pizza", Category: "dinner", Price: 11.99},
    { Name: "Wings", Category: "sides", Price: 8.99},
    { Name: "Breadsticks", Category: "sides", Price: 4.99},
    { Name: "Ceasar Salad", Category: "salads", Price: 5.99},
    { Name: "Cinnamonk Roll", Category: "dessert", Price: 8.99},
  ]

  dinner: MenuItem[] = [];
  getByCategory(category: string): MenuItem[] {
    return this.MenuItems.filter(item => item.Category === category);
  }

  getCategories(): string[] {
    return Array.from(new Set(this.MenuItems.map(item => item.Category)));
  }
}
