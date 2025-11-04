import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Tables } from './tables/tables';
import { LeapYear } from './leap-year/leap-year';
import { CreateLink } from './create-link/create-link';
import { CreateList } from './create-list/create-list';
import { NestedList } from './nested-list/nested-list';
import { AlertButton } from './alert-button/alert-button';
@Component({
  selector: 'app-root',
  imports: [RouterOutlet,LeapYear,Tables,AlertButton,NestedList,CreateLink,CreateList],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  

  protected readonly title = signal('AssigmentAngular03-11-2025');
}
