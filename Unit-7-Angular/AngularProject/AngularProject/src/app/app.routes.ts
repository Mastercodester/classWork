import { Routes } from '@angular/router';
import { NewSettings } from './components/new-settings/new-settings';
import { NewClocks } from './components/new-clocks/new-clocks';

export const routes: Routes = [
    {path: '', redirectTo: '/new-settings', pathMatch: 'full'},
    {path: 'new-settings', component: NewSettings},
    {path: 'new-clocks', component: NewClocks},
    
];
