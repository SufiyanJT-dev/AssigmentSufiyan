import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-hoteldetails',
  imports: [],
  templateUrl: './hoteldetails.html',
  styleUrl: './hoteldetails.scss',
})
export class Hoteldetails {
  constructor(private route :ActivatedRoute){}
selectedHotelDetails:any=[];
ngOnInit(){
  this.route.queryParams.subscribe(params=>{
    this.selectedHotelDetails=params['hotelDetails'];
    console.log(this.selectedHotelDetails);
  })
}
}
