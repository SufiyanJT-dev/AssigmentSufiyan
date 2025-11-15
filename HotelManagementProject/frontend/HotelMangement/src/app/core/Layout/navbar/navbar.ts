import { Component } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { routes } from '../../../app.routes';

@Component({
  selector: 'app-navbar',
  imports: [],
  standalone: true,
  templateUrl: './navbar.html',
  styleUrl: './navbar.scss',
})
export class Navbar {
constructor( private router:Router){}
GotoLogin(){
  console.log("abx");
this.router.navigate(['/login']);
}
}
