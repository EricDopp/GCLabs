import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { UserProfile } from '../models/user-profile';
import { ProfileService } from '../services/profile.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-editprofilepage',
  templateUrl: './editprofilepage.component.html',
  styleUrls: ['./editprofilepage.component.css']
})
export class EditprofilepageComponent implements OnInit {
  editedProfile!: UserProfile;

  constructor(private profileService: ProfileService, private router: Router, private cdr: ChangeDetectorRef) {}

  ngOnInit(): void {
    this.editedProfile = { ...this.profileService.getUserProfile() };
  }

  saveChanges(): void {
  console.log('Saving changes:', this.editedProfile);
  this.profileService.setUserProfile(this.editedProfile);
  console.log('Changes saved. New profile:', this.profileService.getUserProfile());

  // Manually trigger change detection
  this.cdr.detectChanges();
  }
}