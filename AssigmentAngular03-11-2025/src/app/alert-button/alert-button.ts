import { Component } from '@angular/core';

@Component({
  selector: 'app-alert-button',
  templateUrl: './alert-button.html',
})
export class AlertButton {
  onButtonClick() {
    alert('Button was clicked!');
  }
}
