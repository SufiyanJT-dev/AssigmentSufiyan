import { Component, Input, signal } from '@angular/core';
import {Router, RouterOutlet,RouterLink, RouterModule } from '@angular/router';
import { NavBarComponent } from './Features/nav-bar.component/nav-bar.component';
import { HotelDetails } from './Features/Hotels/hotel-details/hotel-details';
import { HotelsList } from './Features/Hotels/hotels-list/hotels-list';

@Component({
  selector: 'app-root',
  imports: [NavBarComponent,HotelsList,HotelDetails,RouterOutlet,RouterModule],
  templateUrl:'./app.html' ,
  styleUrl: './app.scss'
})
export class App {
   constructor(private router: Router) {}
 
  protected readonly title = signal('hotel-booking-app');
    hotelList: any[] = [];
  receiveValue(event:any[]){
     this.hotelList = event;
  }

}
