import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Clock } from '../../clock';


import { AppNewDeleteClock } from '../new-delete-clock/new-delete-clock';

@Component({
  selector: 'app-clock-display',
  imports: [CommonModule,  AppNewDeleteClock],
  templateUrl: './clock-display.html',
  styleUrl: './clock-display.css',
 
})
export class ClockDisplay {
ourClockInfo: Clock[] = [];
  constructor(private AppdeleteClock: AppNewDeleteClock) {
    this.ourClockInfo = this.AppdeleteClock.getClocks();
  }
  public deleteClock(index: number): void {
    this.AppdeleteClock.deleteClock(index);
    this.ourClockInfo = this.AppdeleteClock.getClocks();
  }

}
