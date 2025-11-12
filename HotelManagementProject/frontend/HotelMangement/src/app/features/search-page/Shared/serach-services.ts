import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})

export class SerachServices {
  private data: any[] = [];
  constructor() {
    
    const saved = localStorage.getItem('Search');
    this.data = saved ? JSON.parse(saved) : [];
  }
setData(array: any[]) {
    this.data = array;
    localStorage.setItem('sharedArray', JSON.stringify(array));
  }

  getData(): any[] {
    return this.data;
  }
}

