import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Clock } from '../../clock';
import { OnInit } from '@angular/core';
import { OnDestroy } from '@angular/core';


import { AppNewDeleteClock } from '../new-delete-clock/new-delete-clock';

@Component({
  selector: 'app-clock-display',
  imports: [CommonModule,  AppNewDeleteClock],
  templateUrl: './clock-display.html',
  styleUrl: './clock-display.css',
 
})
export class ClockDisplay {
//ourClockInfo: Clock[] = [];
  //constructor(private AppdeleteClock: AppNewDeleteClock) {
    //this.ourClockInfo = this.AppdeleteClock.getClocks();
  //}
  //public deleteClock(index: number): void {
    //this.AppdeleteClock.deleteClock(index);
    //this.ourClockInfo = this.AppdeleteClock.getClocks();
  //}


  /////////////////////Analog clock

  intervalId: ReturnType<typeof setInterval> | undefined;
  hourDeg = 0;
  minuteDeg = 0;
 secondDeg = 0;

  ngOnInit(): void {
    this.updateClock();
   this.intervalId = setInterval(() => this.updateClock(), 1000);
  }

  updateClock(): void {
    const now = new Date();
    const seconds = now.getSeconds();
    const minutes = now.getMinutes();
    const hours = now.getHours();

    this.secondDeg = seconds * 6;
    this.minuteDeg = minutes * 6 + seconds * 0.1;
    this.hourDeg = ((hours % 12) * 30) + (minutes * 0.5);
  }

  ngOnDestroy(): void {
    if (this.intervalId) {
      clearInterval(this.intervalId);
    }
  }

}

