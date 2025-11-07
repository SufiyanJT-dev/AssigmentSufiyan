import { Component, input, Input } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OnInit } from '@angular/core';
import{ HotelCommunication } from '../../../Shared/hotel-communication';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-hotel-details',
  imports: [RouterModule,CommonModule ],
  templateUrl: './hotel-details.html',
  styleUrl: './hotel-details.scss',
})

export class HotelDetails implements OnInit {
  selectedHotel: any;
 constructor(private hotelService: HotelCommunication) {}
 @Input() hotels: any[] = [];
  ngOnInit() {
    this.hotelService.selectedHotel$.subscribe(hotel => {
      this.selectedHotel = hotel;
    });
  }
}

