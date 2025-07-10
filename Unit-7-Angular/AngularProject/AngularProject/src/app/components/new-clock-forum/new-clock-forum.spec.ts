import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewClockForum } from './new-clock-forum';

describe('NewClockForum', () => {
  let component: NewClockForum;
  let fixture: ComponentFixture<NewClockForum>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewClockForum]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewClockForum);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
