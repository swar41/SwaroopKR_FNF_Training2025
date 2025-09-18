
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';

import { AppComponent } from './app';
import { UserComponent } from './user/user.component';
import { RestaurantsComponent } from './restaurants/restaurants.component';
import { MenuComponent } from './menu/menu.component';
import { CartSummaryComponent } from './cart-summary/cart-summary.component';
import { CheckoutComponent } from './checkout/checkout.component';
import { AppRoutingModule } from './app-routing-module';

// const routes: Routes = [
//   { path: '', component: UserComponent },
//   { path: 'restaurants', component: RestaurantsComponent },
//   { path: 'menu/:id', component: MenuComponent },
//   { path: 'cart', component: CartSummaryComponent },
//   { path: 'checkout', component: CheckoutComponent },
// ];

@NgModule({
  declarations: [
    AppComponent,
    UserComponent,
    RestaurantsComponent,
    MenuComponent,
    CartSummaryComponent,
    CheckoutComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

