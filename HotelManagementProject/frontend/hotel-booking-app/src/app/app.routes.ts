import { Routes } from '@angular/router';
import { HotelsList } from './Features/Hotels/hotels-list/hotels-list';
import { HotelDetails } from './Features/Hotels/hotel-details/hotel-details';
import { CustomerList } from './Features/Customers/customer-list/customer-list';
import { CustomerDetails } from './Features/Customers/customer-details/customer-details';
import { Room } from './Features/Hotels/hotel-details/room/room';
import { Employees } from './Features/Hotels/hotel-details/employees/employees';
import { Review } from './Features/Hotels/hotel-details/review/review';
import { Home } from './Features/home/home';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  {path:'home',component:Home},
  { path: 'hotel-list', component: HotelsList },
  { path: 'hotel-details/:hotelid', component: HotelDetails ,children:
     [
          {path:'room',component:Room},
          {path:'employees',component:Employees},
          {path:'Reviews',component:Review}
  ]},
  { path: 'customers', component: CustomerList },
  { path: 'customer-details/:customerid', component: CustomerDetails,
    },
];
