import { Component, input, Input } from '@angular/core';
import { RouterModule } from '@angular/router';
import { OnInit } from '@angular/core';
import{ HotelCommunication } from '../../../Shared/hotel-communication';
@Component({
  selector: 'app-hotel-details',
  imports: [RouterModule ],
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

