import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AlertButton } from './alert-button';

describe('AlertButton', () => {
  let component: AlertButton;
  let fixture: ComponentFixture<AlertButton>;
 
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AlertButton]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AlertButton);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });
  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
 
