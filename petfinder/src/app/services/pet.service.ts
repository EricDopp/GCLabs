import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Pet } from '../models/pet';

@Injectable({
  providedIn: 'root'
})
export class PetService {

  constructor(private client:HttpClient) { }

  apiUrl:string = 'http://localhost:3000/pets';

  getAllPets() :Observable<Pet[]> {
    return this.client.get<Pet[]>(this.apiUrl);
  }

  getPetById(id:number) : Observable<Pet> {
    return this.client.get<Pet>(`${this.apiUrl}/${id}`);
  }

  createPet(pet:Pet) : Observable<Pet> {
    return this.client.post<Pet>(this.apiUrl, pet);
  }

  updatePet(id:number, pet:Pet) : Observable<Pet> {
    return this.client.put<Pet>(`${this.apiUrl}/${id}`, pet);
  }

  deletePet(id:number) {
    return this.client.delete(`${this.apiUrl}/${id}`);
  }
}
