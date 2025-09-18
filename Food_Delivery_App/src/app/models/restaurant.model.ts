import { Dish } from './dish.model';

export interface Restaurant {
  id: number;
  name: string;
  menu: Dish[];
  imageUrl:string;
}