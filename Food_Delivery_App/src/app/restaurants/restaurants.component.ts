

import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { Restaurant } from '../models/restaurant.model';
@Component({
  selector: 'app-restaurants.component',
  standalone: false,
  templateUrl: './restaurants.component.html',
  styleUrl: './restaurants.component.css'
})
export class RestaurantsComponent implements OnInit{
restaurants: Restaurant[] = [];

  constructor(private http: HttpClient, private router: Router) {}

  ngOnInit() {
    this.http.get<Restaurant[]>('http://localhost:3000/restaurants')
      .subscribe(data => this.restaurants = data);
  }

  openMenu(id: number) {
    this.router.navigate(['/menu', id]);
  }
}
