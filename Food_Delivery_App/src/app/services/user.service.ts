import { Injectable } from '@angular/core';
import { User } from '../models/user.model';

@Injectable({ providedIn: 'root' })
export class UserService {
  private storageKey = 'user';

  saveUser(user: User) {
    localStorage.setItem(this.storageKey, JSON.stringify(user));
  }

  getUser(): User | null {
    const data = localStorage.getItem(this.storageKey);
    return data ? JSON.parse(data) : null;
  }
}