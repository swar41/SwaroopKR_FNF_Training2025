
import { Component, OnInit } from '@angular/core';
import { CartService } from '../services/cart.service';
@Component({
  selector: 'app-checkout.component',
  standalone: false,
  templateUrl: './checkout.component.html',
  styleUrl: './checkout.component.css'
})
export class CheckoutComponent implements OnInit {

  constructor(private cartService: CartService) {}

  ngOnInit() {
    this.cartService.clearCart();
  }
}

