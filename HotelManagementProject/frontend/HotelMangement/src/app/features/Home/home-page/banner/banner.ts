import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Apicommuncation } from '../../../../shared/Api/apicommuncation';
import { Console, error } from 'console';
import { Router } from '@angular/router';

@Component({
  selector: 'app-banner',
  imports: [CommonModule,FormsModule],
  templateUrl: './banner.html',
  styleUrl: './banner.scss',
})
export class Banner {
  constructor(private router:Router ,private api:Apicommuncation){}
onSearch(form: any) {
    const formValues = form.value;
    this.router.navigate(['/result-page'],{
      queryParams:formValues,
      
    });         
     
}
}
