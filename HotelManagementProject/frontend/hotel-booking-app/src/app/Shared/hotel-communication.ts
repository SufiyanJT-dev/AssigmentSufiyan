import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

export interface Hotels {
  id: number;
  name: string;
}

@Injectable({
  providedIn: 'root',
})

export class HotelCommunication {
  private selectedHotelSource = new BehaviorSubject<Hotels | null>(null);
  selectedHotel$ = this.selectedHotelSource.asObservable();
  selectHotel(hotels:Hotels ) {
    this.selectedHotelSource.next(hotels);
  }
}
