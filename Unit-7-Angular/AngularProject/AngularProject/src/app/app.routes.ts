import { Routes } from '@angular/router';
import { AppNewSettings } from './components/new-settings/new-settings';
import { AppNewClocks } from './components/new-clocks/new-clocks';

export const routes: Routes = [
    {path: '', redirectTo: '/new-settings', pathMatch: 'full'},
    {path: 'new-settings', component: AppNewSettings},
    {path: 'new-clocks', component: AppNewClocks},
    
];
