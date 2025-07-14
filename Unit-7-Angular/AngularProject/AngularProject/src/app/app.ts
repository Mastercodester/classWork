import { Component } from '@angular/core';

import { AppNewSettings } from './components/new-settings/new-settings';
import { AppNewClocks } from './components/new-clocks/new-clocks';
import { CommonModule } from '@angular/common';
import { ClockDisplay } from './components/clock-display/clock-display';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [ RouterOutlet, AppNewSettings, AppNewClocks, CommonModule,ClockDisplay],
  templateUrl: './app.html',
  styleUrl: './app.css',
  standalone: true
})
export class App {
  protected title = 'AngularProject';
}
