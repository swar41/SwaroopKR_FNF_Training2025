
import { Injectable } from '@angular/core';
import { CartItem } from '../models/cart-item.model';
import { Dish } from '../models/dish.model';

@Injectable({ providedIn: 'root' })
export class CartService {
  private storageKey = 'cart';

  private getCart(): CartItem[] {
    const data = sessionStorage.getItem(this.storageKey);
    return data ? JSON.parse(data) : [];
  }

  private saveCart(cart: CartItem[]) {
    sessionStorage.setItem(this.storageKey, JSON.stringify(cart));
  }

  addToCart(dish: Dish, restaurantId: number) {
    let cart = this.getCart();
    let item = cart.find(c => c.dish.id === dish.id && c.restaurantId === restaurantId);
    if (item) {
      item.quantity++;
    } else {
      cart.push({ dish, restaurantId, quantity: 1 });
    }
    this.saveCart(cart);
  }

  getCartItems(): CartItem[] {
    return this.getCart();
  }

  clearCart() {
    sessionStorage.removeItem(this.storageKey);
  }

  getTotal(): number {
    return this.getCart().reduce((sum, item) => sum + item.dish.price * item.quantity, 0);
  }
}
