import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Apicommuncation } from '../../../../../shared/Api/apicommuncation';

@Component({
  selector: 'app-booking',
  imports: [CommonModule],
  templateUrl: './booking.html',
  styleUrl: './booking.scss',
})
export class Booking {
  constructor(private api:Apicommuncation){}
ngOnInit(){
  this.api.getAllBooking().subscribe({
    next:(value)=> {
      console.log(value);
    },
  })
}
}
