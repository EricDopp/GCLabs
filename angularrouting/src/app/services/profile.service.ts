import { Injectable } from '@angular/core';
import { UserProfile } from '../models/user-profile';

@Injectable({
  providedIn: 'root'
})
export class ProfileService {
  private userProfile: UserProfile = {
    name: 'Eric Dopp',
    contact: 'Grand Circus Bootcamp',
    bio: 'Funny guy',
  };

  getUserProfile(): UserProfile {
    return this.userProfile;
  }

  setUserProfile(newProfile: UserProfile): void {
    this.userProfile = { ...newProfile };
  }

}
