
import { Component, OnInit } from '@angular/core';
import { CartService } from '../services/cart.service';
import { CartItem } from '../models/cart-item.model';
import { Router } from '@angular/router';
@Component({
  selector: 'app-cart-summary.component',
  standalone: false,
  templateUrl: './cart-summary.component.html',
  styleUrl: './cart-summary.component.css'
})

export class CartSummaryComponent implements OnInit {
  items: CartItem[] = [];
  total = 0;
  user = {
    name: '',
    location: '',
    phone: ''
  };

  constructor(private cartService: CartService, private router: Router) {}

  ngOnInit() {
    this.items = this.cartService.getCartItems();
    this.total = this.cartService.getTotal();

    // Retrieve user details from localStorage
    const storedUser = localStorage.getItem('user');
    if (storedUser) {
      this.user = JSON.parse(storedUser);
    }
  }

  checkout() {
    this.router.navigate(['/checkout']);
  }
}

