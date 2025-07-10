import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ClockDisplay } from './clock-display';

describe('ClockDisplay', () => {
  let component: ClockDisplay;
  let fixture: ComponentFixture<ClockDisplay>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ClockDisplay]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ClockDisplay);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
