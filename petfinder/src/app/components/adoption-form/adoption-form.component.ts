import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { AdoptionForm } from 'src/app/models/adoptionform';
import { Pet } from 'src/app/models/pet';
import { PetService } from 'src/app/services/pet.service';

@Component({
  selector: 'app-adoption-form',
  templateUrl: './adoption-form.component.html',
  styleUrls: ['./adoption-form.component.css']
})
export class AdoptionFormComponent {
  pet:Pet|null = null;
  petId:string|null = null;

  //typically you put variables before the constructor
  adoptionForm = this.fb.group({
    //inside the array, goes 2 things: the starting value and the validator
    firstName: ['', Validators.required],
    lastName: ['', Validators.required],
    petName: [{value: this.pet?.name, disabled:true}],
    fencedBackyard: [false],
    livingSituation: ['', [Validators.required, Validators.minLength(10)]],
    agreedTerms: [false, Validators.requiredTrue]
  });

  constructor(private fb:FormBuilder, private route:ActivatedRoute,
    private petService:PetService){
  }

  ngOnInit(){
    this.petId = this.route.snapshot.paramMap.get('id');

    this.petService.getPetById(Number(this.petId))
    .subscribe(pet => {
      this.adoptionForm.patchValue({
        petName: pet.name
      })

      this.pet = pet;
    });
  }

  onSubmit() {
    if(this.adoptionForm.valid){
      const formData:AdoptionForm = this.adoptionForm.getRawValue() as AdoptionForm;

      console.log(formData);
    }
  }
}
