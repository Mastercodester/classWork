import { Component } from '@angular/core';
import { Clock } from '../../clock';
import { ServiceClock } from '../../services/service-clock';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-new-clock-list',
  imports: [CommonModule],
  templateUrl: './new-clock-list.html',
  styleUrl: './new-clock-list.css'
})
export class NewClockList {

public clocks: Clock[] = [];
constructor(private serviceClock: ServiceClock) {
  this.clocks = this.serviceClock.getClocks();

}
}
