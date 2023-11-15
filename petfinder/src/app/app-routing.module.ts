import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListPetsComponent } from './components/list-pets/list-pets.component';
import { PetDetailsComponent } from './components/pet-details/pet-details.component';
import { AdoptionFormComponent } from './components/adoption-form/adoption-form.component';

const routes: Routes = [
  //path, component, redirectTo
  { path: '', redirectTo: 'pets', pathMatch: 'full'},
  { path: 'pets', component: ListPetsComponent },
  { path: 'pet/:id', component: PetDetailsComponent},
  { path: 'petform/:id', component: AdoptionFormComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
