import { Routes } from '@angular/router';
import { AppNewSettings } from './components/new-settings/new-settings';
import { AppNewClocks } from './components/new-clocks/new-clocks';
import { AppNewDeleteClock } from './components/new-delete-clock/new-delete-clock';
import {ClockDisplay} from './components/clock-display/clock-display';

export const routes: Routes = [
    {path: '', redirectTo: '/new-settings', pathMatch: 'full'},
    {path: 'new-settings', component: AppNewSettings},
    {path: 'new-clocks', component: AppNewClocks},
    {path: 'new-delete-clock', component: AppNewDeleteClock},
    {path: 'clock-display', component: ClockDisplay}
    
];
