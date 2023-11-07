import { Component } from '@angular/core';
import { Todo } from './todo';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'todoapp';

  todos:Todo[] = [
    { task: 'Clean my room', completed: false },
    { task: 'Bring in patio furniture', completed: true},
    { task: 'Make spaghetti', completed: false},
    { task: 'Make new bougie desk', completed: false},
    { task: 'Cry at my party if I want to', completed: true}
  ];

  completeTask(index:number) :void {
      this.todos[index].completed = true;
      alert(this.todos[index].task + " is complete!");
  }

  newTask:string = "";
  addTask(): void {
    let todo: Todo = {
      task: this.newTask,
      completed: false
    };
    this.todos.push(todo);
    this.newTask ="";
  }
}
