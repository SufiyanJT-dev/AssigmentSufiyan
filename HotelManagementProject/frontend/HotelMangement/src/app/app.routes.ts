import { Routes } from '@angular/router';
import { HomePage } from './features/Home/home-page/home-page';
import { Hoteldetails } from './features/Hotels/hoteldetails/hoteldetails';
import { LoginAuth } from './features/auth/login-auth/login-auth';
import { AdminDashboard } from './features/Admin/admin-dashboard/admin-dashboard';
import { SearchPage } from './features/search-page/search-page';

export const routes: Routes = [
 { path: '', redirectTo: 'Home', pathMatch: 'full' }, 
{path:'Home',component:HomePage},
{path:'login',component:LoginAuth},
{path:'result-page',component:SearchPage},

{path:'HotelDetails',component:Hoteldetails},
{
    path:'Admin-DashBoard',
    component:AdminDashboard
}
];
