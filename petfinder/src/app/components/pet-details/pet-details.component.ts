import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Pet } from 'src/app/models/pet';
import { PetService } from 'src/app/services/pet.service';

@Component({
  selector: 'app-pet-details',
  templateUrl: './pet-details.component.html',
  styleUrls: ['./pet-details.component.css']
})
export class PetDetailsComponent {
  constructor(private route:ActivatedRoute,
              private petService:PetService){

  }

  petId:(string  | null)= "";

  pet:Pet | null = null; 

  ngOnInit(){
    //grabbing the id from the url
    this.petId = this.route.snapshot.paramMap.get('id');
    //goes to line 10 on app-routing.module.ts

    if(this.petId !== null){
      this.petService.getPetById(Number(this.petId))
        .subscribe(pet => this.pet = pet);
    }
  }
}
