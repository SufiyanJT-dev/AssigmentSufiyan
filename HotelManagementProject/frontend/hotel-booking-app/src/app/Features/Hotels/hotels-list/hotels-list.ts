import { Component, EventEmitter, Output, output } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { NgbCarouselModule } from '@ng-bootstrap/ng-bootstrap';
import { HotelCommunication } from '../../../Shared/hotel-communication';

@Component({
  selector: 'app-hotels-list',
  standalone: true,
  imports: [CommonModule, NgbCarouselModule],
  templateUrl: './hotels-list.html',
  styleUrls: ['./hotels-list.scss']
})
export class HotelsList {
  constructor(private router: Router, private hotelService: HotelCommunication) {}
currentIndex = 0;

prevSlide() {
  this.currentIndex = (this.currentIndex - 1 + this.hotels.length) % this.hotels.length;
}

nextSlide() {
  this.currentIndex = (this.currentIndex + 1) % this.hotels.length;
}

  hotels = [
    { id: 1, name: 'Hotel California' },
    { id: 2, name: 'Grand Budapest Hotel' },
    { id: 3, name: 'The Overlook Hotel' }
  ];

  goToHotel(id: number) {
    const selectedHotel = this.hotels.find(hotel => hotel.id === id);
    if (selectedHotel) {
    
      this.hotelService.selectHotel(selectedHotel);
      this.router.navigate(['/hotel-details', id]);
    }
  }
}
