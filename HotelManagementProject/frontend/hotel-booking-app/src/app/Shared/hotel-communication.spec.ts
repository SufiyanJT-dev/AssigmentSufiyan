import { TestBed } from '@angular/core/testing';

import { HotelCommunication } from './hotel-communication';

describe('HotelCommunication', () => {
  let service: HotelCommunication;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HotelCommunication);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
