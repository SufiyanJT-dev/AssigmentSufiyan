import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LeapYear } from './leap-year';

describe('LeapYear', () => {
  let component: LeapYear;
  let fixture: ComponentFixture<LeapYear>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [LeapYear]
    })
    .compileComponents();

    fixture = TestBed.createComponent(LeapYear);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
