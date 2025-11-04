import { Component } from '@angular/core';

@Component({
  selector: 'app-leap-year',
  imports: [],
  templateUrl: './leap-year.html',
  styleUrl: './leap-year.scss',
})
export class LeapYear {
 checkLeapYear(year: string) {
    const y = parseInt(year, 10);
    if (isNaN(y)) {
      alert('Please enter a valid year.');
      return;
    }

    const isLeap = (y % 4 === 0 && y % 100 !== 0) || (y % 400 === 0);
    alert(isLeap ? `${y} is a leap year.` : `${y} is not a leap year.`);
  }
}
