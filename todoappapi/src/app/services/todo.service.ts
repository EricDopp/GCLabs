import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Todo } from '../models/todo';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class TodoService {

  constructor(private http:HttpClient) { }

  getAllTodos() : Observable<Todo[]> {
    return this.http.get<Todo[]>('http://localhost:3000/todos')
  }

  createTodo(todo:Todo) : Observable<Todo> {
      return this.http.post<Todo>('http://localhost:3000/todos',todo);
  }
}
