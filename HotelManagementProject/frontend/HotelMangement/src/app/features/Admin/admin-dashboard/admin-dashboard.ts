import { Component } from '@angular/core';
import { Router, RouterOutlet } from '@angular/router';
import { Apicommuncation } from '../../../shared/Api/apicommuncation';
import { error } from 'console';
import { Sidebar } from './components/sidebar/sidebar';

@Component({
  selector: 'app-admin-dashboard',
  imports: [Sidebar,RouterOutlet],
  templateUrl: './admin-dashboard.html',
  styleUrl: './admin-dashboard.scss',
})
export class AdminDashboard {

  constructor(private router: Router, private api: Apicommuncation) { }
  ngOnInit() {
    const storedToken = sessionStorage.getItem('JwtToken');
    if (storedToken == null) {
      this.router.navigate(['/login']);
    }
  }
  GetEmployeeDetails() {
    this.api.getAllEmployee().subscribe({
      next: (res) => {
        console.log(res.status);
        console.log(res);
      },
      error: (err) => {
        console.log(err);
        if (err.status == 401) {
          this.api.getRefershToken().subscribe({
            next: (res) => {
              console.log(res.status);
              sessionStorage.setItem('JwtToken', res.accessToken)
              console.log(res.accessToken);
              this.api.getAllEmployee().subscribe({
                next: (res) => {
                  console.log(res.status);
                  console.log(res);
                }
              },)
            },
            error: (err) => {
              console.log(err);
            }
          })
        }

      }
    })

  }
}
