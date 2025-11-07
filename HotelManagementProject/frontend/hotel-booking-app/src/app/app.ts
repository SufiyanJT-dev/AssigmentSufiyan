import { Component, Input, signal } from '@angular/core';
import {Router, RouterOutlet,RouterLink, RouterModule } from '@angular/router';
import { NavBarComponent } from './Shared/nav-bar.component/nav-bar.component';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-root',
  imports: [NavBarComponent,RouterOutlet,RouterModule],
  templateUrl:'./app.html' ,
  styleUrl: './app.scss'
})
export class App {
   constructor(private router: Router) {}
 
  protected readonly title = signal('hotel-booking-app');
    hotelList: any[] = [];
 

}
