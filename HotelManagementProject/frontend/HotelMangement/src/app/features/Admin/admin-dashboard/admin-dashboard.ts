import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-dashboard',
  imports: [],
  templateUrl: './admin-dashboard.html',
  styleUrl: './admin-dashboard.scss',
})
export class AdminDashboard {
  constructor(private router:Router){}
  ngOnInit(){
    const storedToken = sessionStorage.getItem('JwtToken');
  if(storedToken==null){
    this.router.navigate(['/login']);
  }
}
}
