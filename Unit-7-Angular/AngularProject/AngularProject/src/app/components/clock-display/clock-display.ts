import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Clock } from '../../clock';
import { ServiceClock } from '../../services/service-clock';
import { RouterOutlet } from '@angular/router';
import { NewDeleteClock } from '../new-delete-clock/new-delete-clock';

@Component({
  selector: 'app-clock-display',
  imports: [CommonModule, RouterOutlet, NewDeleteClock, ServiceClock],
  templateUrl: './clock-display.html',
  styleUrl: './clock-display.css',
  standalone: true
})
export class ClockDisplay {
ourClockInfo: Clock[] = [];
  constructor(private serviceClock: ServiceClock) {
    this.ourClockInfo = this.serviceClock.getClocks();
  }
  public deleteClock(index: number): void {
    this.serviceClock.deleteClock(index);
    this.ourClockInfo = this.serviceClock.getClocks();
  }

}
