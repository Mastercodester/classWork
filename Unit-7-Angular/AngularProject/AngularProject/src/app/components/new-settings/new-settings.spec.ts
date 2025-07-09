import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NewSettings } from './new-settings';

describe('NewSettings', () => {
  let component: NewSettings;
  let fixture: ComponentFixture<NewSettings>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [NewSettings]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NewSettings);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
