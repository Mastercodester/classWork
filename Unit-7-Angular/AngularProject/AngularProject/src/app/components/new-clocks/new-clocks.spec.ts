import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewClocks } from './new-clocks';

describe('NewClocks', () => {
  let component: NewClocks;
  let fixture: ComponentFixture<NewClocks>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewClocks]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewClocks);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
