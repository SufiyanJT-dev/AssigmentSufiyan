import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import { ActivatedRoute, Router } from '@angular/router';
import { Apicommuncation } from '../../../../shared/Api/apicommuncation';
import { CommonModule } from '@angular/common';
import { SerachServices } from '../../Shared/serach-services';
import { FormValues } from './type/FormValues';

@Component({
  selector: 'app-right-sidecomponent',
  templateUrl: './right-sidecomponent.html',
  imports: [CommonModule],
  styleUrls: ['./right-sidecomponent.scss'],
})
export class RightSidecomponent implements OnInit {
  formValues:FormValues = {
    location: '',
    checkInDate: '',
    checkOutDate: ''
  };
  results: any[] = [];
  search: any[] = [];  
  HotelNumber:any[]=[];
  HotelValues:any[]=[];
  constructor(
    private api: Apicommuncation,
    private location: Location,
    private serachServices: SerachServices,
    private route: ActivatedRoute ,
    private router:Router
  ) {}

  ngOnInit() {
    this.route.queryParams.subscribe(params => {
      this.formValues = {
        location: params['location'],
        checkInDate: params['checkInDate'],
        checkOutDate: params['checkOutDate']
      };
      
      console.log(this.HotelValues)
      this.api.filtering(this.formValues).subscribe({
        next: (response) => {
          this.results = response;
          this.HotelNumber=[...new Set(this.results.map(room=>room.hotelId))]
          console.log(this.results)
          const HotelMap=new Map<number,any>();
          response.forEach((room:any) => {
            const hotel=room.hotel;
            if(hotel &&!HotelMap.has(hotel.id)){
                
                HotelMap.set(hotel.id,hotel);
            }
          });
          this.HotelValues=Array.from(HotelMap.values())
          console.log('API response:', this.HotelValues);
        },
        error: (err) => {
          console.error('API error:', err);
        },
      });
    });
  }
  HotelDeatils(id:any){
    const hotelDetails = this.HotelValues.find(item => item.id === id);
    const encodedDetails = JSON.stringify(hotelDetails);
    this.router.navigate(['/HotelDetails'],{
      queryParams:{hotelDetails: encodedDetails},
    });
    
  }
}
