import { Component } from '@angular/core';
import { Clock } from '../../clock';
import { ServiceClock } from '../../services/service-clock';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-new-delete-clock',
  imports: [CommonModule, RouterOutlet],
  templateUrl: './new-delete-clock.html',
  styleUrl: './new-delete-clock.css'
})
export class NewDeleteClock {
constructor(private serviceClock: ServiceClock) { }



  public clocks: Clock[] = [
    { timezone: "America/New_York", isDigital: true },
    { timezone: "Europe/London", isDigital: false },
    { timezone: "Asia/Tokyo", isDigital: true }
  ];

  deleteClock(index: number): void {
    this.serviceClock.deleteClock(index);
    this.clocks = this.serviceClock.getClocks();
  }
  
  
}
