import { Component, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  // templateUrl: './app.html',
  standalone: false,
  styleUrl: './app.css',
  template: `<router-outlet></router-outlet>`,

})
export class AppComponent {
  protected readonly title = signal('Food_Delivery_App');
}

