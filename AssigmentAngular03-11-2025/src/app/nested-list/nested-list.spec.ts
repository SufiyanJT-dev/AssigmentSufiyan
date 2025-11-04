import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NestedList } from './nested-list';

describe('NestedList', () => {
  let component: NestedList;
  let fixture: ComponentFixture<NestedList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NestedList]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NestedList);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
