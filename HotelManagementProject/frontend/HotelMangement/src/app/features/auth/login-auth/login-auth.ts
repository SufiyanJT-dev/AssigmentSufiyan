import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Apicommuncation } from '../../../shared/Api/apicommuncation';
import { Router } from '@angular/router';
@Component({
  selector: 'app-login-auth',
  imports: [FormsModule],
  templateUrl: './login-auth.html',
  styleUrl: './login-auth.scss',
})
export class LoginAuth {
  constructor(private api:Apicommuncation,private router: Router){}
onSubmit(form:any){
  const loginDetails=form.value;
  this.api.Validation(loginDetails).subscribe({
    next:(res)=>{
      
      sessionStorage.setItem('JwtToken',res.result);
       this.router.navigate(['/Admin-DashBoard'])
    },
    error:(err)=>{
       console.error('Login failed:', err);
    }
  })
}
}
