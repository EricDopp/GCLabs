import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { HttpClientModule } from '@angular/common/http';
import { ListPetsComponent } from './components/list-pets/list-pets.component';
import { HeaderComponent } from './components/header/header.component';
import { PetDetailsComponent } from './components/pet-details/pet-details.component';
import { AdoptionFormComponent } from './components/adoption-form/adoption-form.component'
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    ListPetsComponent,
    HeaderComponent,
    PetDetailsComponent,
    AdoptionFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
