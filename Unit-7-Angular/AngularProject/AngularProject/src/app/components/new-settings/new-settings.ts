import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { NewClockForum } from '../new-clock-forum/new-clock-forum';

@Component({
  selector: 'app-new-settings',
  imports: [CommonModule, RouterOutlet, FormsModule, NewClockForum],
  templateUrl: './new-settings.html',
  styleUrl: './new-settings.css'
})
export class NewSettings {
Timezones: string[] = [
    'America/New_York',
    'Europe/London',
    'Asia/Tokyo',
    'Australia/Sydney', 
    'America/Los_Angeles',
]
TimezonePick: string = 'America/New_York';

}
