import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProfilepageComponent } from './profilepage/profilepage.component';
import { EditprofilepageComponent } from './editprofilepage/editprofilepage.component';

const routes: Routes = [
  { path: 'profile', component: ProfilepageComponent },
  { path: 'edit-profile', component: EditprofilepageComponent },
  { path: '', redirectTo: '/profile', pathMatch: 'full' }, // Default route
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
