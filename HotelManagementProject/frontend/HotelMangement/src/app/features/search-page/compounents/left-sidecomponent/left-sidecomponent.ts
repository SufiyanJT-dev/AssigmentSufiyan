import { Component, OnInit } from '@angular/core';
import { Apicommuncation } from '../../../../shared/Api/apicommuncation';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { SerachServices } from '../../Shared/serach-services';
import { Router } from '@angular/router';

@Component({
  selector: 'app-left-sidecomponent',
  imports: [FormsModule,CommonModule ],
  standalone: true,
  templateUrl: './left-sidecomponent.html',
  styleUrl: './left-sidecomponent.scss',
})
export class LeftSidecomponent  {
  route: any;
  constructor(private serachService:SerachServices,  private router: Router){}
  isEditing: boolean = false;
  Search=[{
  location:   'New York',
  checkInDate:  '2025-12-10',
  checkOutDate:  '2025-12-15'
  }
  ]
  

  toggleEdit() {
    this.isEditing = !this.isEditing;
  }

  sendData() {
    this.serachService.setData(this.Search);
  }
  applyChanges() {
  this.isEditing = false;
  console.log('Updated search:', this.Search);

  const updatedSearch = this.Search[0]; 

  this.router.navigate([], {
    queryParams: {
      location: updatedSearch.location,
      checkInDate: updatedSearch.checkInDate,
      checkOutDate: updatedSearch.checkOutDate
    },
    queryParamsHandling: 'merge' 
  });
}
 }

