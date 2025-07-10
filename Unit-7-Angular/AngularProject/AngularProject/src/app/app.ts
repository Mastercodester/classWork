import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { AppNewSettings } from './components/new-settings/new-settings';
import { AppNewClocks } from './components/new-clocks/new-clocks';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, AppNewSettings, AppNewClocks],
  templateUrl: './app.html',
  styleUrl: './app.css',
  standalone: true
})
export class App {
  protected title = 'AngularProject';
}
