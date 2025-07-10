import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { Clock } from '../../clock';  
import { ServiceClock } from '../../services/service-clock';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-new-clock-forum',
  imports: [CommonModule,RouterOutlet, FormsModule],
  templateUrl: './new-clock-forum.html',
  styleUrl: './new-clock-forum.css'
})



export class NewClockForum {

ClockforumClock: Clock = {
timezone: 'America/New_York',
isDigital: false  
}    

}
