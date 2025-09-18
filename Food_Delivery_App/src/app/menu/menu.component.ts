
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Restaurant } from '../models/restaurant.model';
import { CartService } from '../services/cart.service';
@Component({
  selector: 'app-menu.component',
  standalone: false,
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent implements OnInit{
restaurant?: Restaurant;

  constructor(
    private route: ActivatedRoute,
    private http: HttpClient,
    private cartService: CartService
  ) {}

  ngOnInit() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.http.get<Restaurant>(`http://localhost:3000/restaurants/${id}`)
      .subscribe(data => this.restaurant = data);
  }

  addToCart(dishId: number) {
    if (!this.restaurant) return;
    const dish = this.restaurant.menu.find(d => d.id === dishId);
    if (dish) {
      this.cartService.addToCart(dish, this.restaurant.id);
      alert(`${dish.name} added to cart!`);
    }
  }
}
