import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { UserComponent } from './user/user.component';
import { RestaurantsComponent } from './restaurants/restaurants.component';
import { MenuComponent } from './menu/menu.component';
import { CartSummaryComponent } from './cart-summary/cart-summary.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { FormsModule } from '@angular/forms';

const routes: Routes = [
  { path: '', component: UserComponent },
  { path: 'restaurants', component: RestaurantsComponent },
  { path: 'menu/:id', component: MenuComponent },
  { path: 'cart', component: CartSummaryComponent },
  { path: 'checkout', component: CheckoutComponent },
];
@NgModule({
  imports: [RouterModule.forRoot(routes),FormsModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
