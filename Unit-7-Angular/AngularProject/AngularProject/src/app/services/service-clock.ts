import { Injectable } from '@angular/core';
import { Clock } from '../../app/clock';

@Injectable({
  providedIn: 'root'
})
export class ServiceClock {

private clock: Clock[] = []

  constructor() { 
    this.clock.push({
      timezone: 'America/New_York',
      isDigital: true
    });
    this.clock.push({
      timezone: 'Europe/London',
      isDigital: false
    });
    this.clock.push({
      timezone: 'Asia/Tokyo',
      isDigital: true
    });
  }
  addClock(clock: Clock) {
    this.clock.push(clock);
  }
  deleteClock(index: number) {
    if (index >= 0 && index < this.clock.length) {
      this.clock.splice(index, 1);
    }
  }
  editClock(index: number, updatedClock: Clock) {
    if (index >= 0 && index < this.clock.length) {
      this.clock[index] = updatedClock;
    }
  }
  getClocks(): Clock[] {
    return this.clock;
  }

}
