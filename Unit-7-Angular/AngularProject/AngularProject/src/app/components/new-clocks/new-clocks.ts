import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ClockDisplay } from '../clock-display/clock-display';
import { RouterOutlet } from '@angular/router';



@Component({
  selector: 'app-new-clocks',
  imports: [CommonModule, ClockDisplay, RouterOutlet],
  templateUrl: './new-clocks.html',
  styleUrl: './new-clocks.css'
})
export class NewClocks {

}
