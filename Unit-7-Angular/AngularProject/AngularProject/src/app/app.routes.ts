import { Routes } from '@angular/router';
import { NewSettings } from './components/new-settings/new-settings';
import { NewClockList } from './components/new-clock-list/new-clock-list';

export const routes: Routes = [
    {path: '', redirectTo: 'new-clock-list', pathMatch: 'full'},
    
];
