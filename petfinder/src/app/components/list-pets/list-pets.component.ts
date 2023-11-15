import { Component } from '@angular/core';
import { Pet } from 'src/app/models/pet';
import { PetService } from 'src/app/services/pet.service';

@Component({
  selector: 'app-list-pets',
  templateUrl: './list-pets.component.html',
  styleUrls: ['./list-pets.component.css']
})
export class ListPetsComponent {
  constructor(private petService:PetService){
    
  }

  pets:Pet[] = [];

  ngOnInit(){
    this.petService.getAllPets()
      .subscribe(pets => this.pets = pets);
  }
}
