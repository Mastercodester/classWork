import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClockDisplay } from '../clock-display/clock-display';




@Component({
  selector: 'app-new-clocks',
  imports: [CommonModule, ClockDisplay],
  templateUrl: './new-clocks.html',
  styleUrl: './new-clocks.css'
})
export class AppNewClocks {

}
