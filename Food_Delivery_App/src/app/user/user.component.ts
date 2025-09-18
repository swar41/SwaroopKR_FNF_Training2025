import { Component } from '@angular/core';

import { Router } from '@angular/router';
import { UserService } from '../services/user.service';
import { User } from '../models/user.model';
@Component({
  selector: 'app-user.component',
  standalone: false,
  templateUrl: './user.component.html',
  styleUrl: './user.component.css'
})
export class UserComponent {

  user: User = { name: '', location: '', phone: '' };

  constructor(private userService: UserService, private router: Router) {}

  saveUser() {
    this.userService.saveUser(this.user);
    this.router.navigate(['/restaurants']);
  }
}
