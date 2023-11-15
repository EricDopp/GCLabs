import { Component, OnInit } from '@angular/core';
import { UserProfile } from '../models/user-profile';
import { ProfileService } from '../services/profile.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-profilepage',
  templateUrl: './profilepage.component.html',
  styleUrls: ['./profilepage.component.css']
})
export class ProfilepageComponent implements OnInit {
  userProfile!: UserProfile;

  constructor(private profileService: ProfileService, private router: Router) {}

  ngOnInit(): void {
    this.userProfile = this.profileService.getUserProfile();
  }

  navigateToEditProfile(): void {
    this.router.navigate(['/edit-profile']);
  }
}
