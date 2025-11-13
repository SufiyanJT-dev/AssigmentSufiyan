import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule, NgModel } from '@angular/forms';
import { Apicommuncation } from '../../../../../shared/Api/apicommuncation';
import { HotelDetails } from './Type/HotelDeatils';
import { addHotelDeatils } from './Type/AddHotelDeatils';
@Component({
  selector: 'app-hotel',
  imports: [FormsModule, CommonModule],
  templateUrl: './hotel.html',
  styleUrl: './hotel.scss',
})
export class Hotel {

  IfEditTrue:boolean=false;
  hotels: HotelDetails[] = [];
  newHotels: addHotelDeatils = {
    Name: '',
    Address: '',
    City: '',
    Country: '',
    Description: '',
    PhoneNumber: '',
    Path: ''
  };

  selectedFile: File | null = null;
  constructor(private api: Apicommuncation) { }
  ngOnInit() {
  this.getAllHotel();

  }
getAllHotel(){
  this.api.getAllHotel().subscribe({
      next: (data: any[]) => {
        this.hotels = data.map(hotel => ({
          id: hotel.id,
          name: hotel.name,
          address: hotel.address,
          city: hotel.city,
          country: hotel.country,
          description: hotel.description,
          phoneNumber: hotel.phoneNumber,
          path: 'https://localhost:7119' + hotel.path
        }));
        console.log(this.hotels)
      },
      error(err) {
        console.log(err);
      },
    })
}
  showForm = false;
  searchTerm = '';



  toggleForm() {
    this.showForm = !this.showForm;
  }

  addHotel() {
    const formData = new FormData();
    formData.append('Name', this.newHotels.Name);
    formData.append('Address', this.newHotels.Address);
    formData.append('City', this.newHotels.City);
    formData.append('Country', this.newHotels.Country);
    formData.append('Description', this.newHotels.Description);
    formData.append('PhoneNumber', this.newHotels.PhoneNumber);
    if (this.selectedFile) {
      formData.append('image', this.selectedFile);
    }
    console.log(this.newHotels)
    this.api.AddHotel(formData).subscribe({
      next(value) {
        console.log(value);
        
      },
      error(err) {
        console.log(err);
      },
      
    })
    this.getAllHotel();
  }
  onFileSelected(event: Event) {
    const input = event.target as HTMLInputElement;
    if (input.files && input.files.length > 0) {
      this.selectedFile = input.files[0];

      this.newHotels.Path = input.files[0].name;
    }
  }


  filteredHotels() {
    return this.hotels.filter(h =>
      h.name.toLowerCase().includes(this.searchTerm.toLowerCase())
    );
  }

  editHotel(hotel: any) {
this.IfEditTrue=true
    console.log('Edit', hotel);
  }

  deleteHotel(id: number) {
    this.api.DeleteHotel(id).subscribe({
      next: () => {
        this.hotels = this.hotels.filter(h => h.id !== id);
        console.log('Hotel deleted successfully');
       this.getAllHotel();
      },
      error: (err) => {
        console.error('Error deleting hotel:', err);
      }
    });
  
  }
}

