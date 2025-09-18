import { Dish } from './dish.model';

export interface CartItem {
  dish: Dish;
  restaurantId: number;
  quantity: number;
}
