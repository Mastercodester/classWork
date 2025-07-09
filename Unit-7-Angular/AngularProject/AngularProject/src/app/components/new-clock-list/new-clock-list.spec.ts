import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewClockList } from './new-clock-list';

describe('NewClockList', () => {
  let component: NewClockList;
  let fixture: ComponentFixture<NewClockList>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewClockList]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewClockList);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
