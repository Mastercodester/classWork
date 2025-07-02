import { Routes }        from '@angular/router'; // give me acess to angulsr router
import { HomeComponent } from './components/home/home.component';// give me access to the home component
import { SampleFormComponent } from './components/sample-form/sample-form.component';
import {StateSealsComponent} from './components/state-seals/state-seals.component'; // give me access to the state seals component
import { StudentListComponent } from './components/components/student-list/student-list.component';



//The Routes objedct is an array of objexcts to associate a url path to a component
//
//Each entry in the array contains the following attributes:
//
//Path- the url path to be associated with a component
// component - name of the component associated with the path 
//redirect - optional attribute to redirect a path to a different page
// pathMatch indicates if a full match to a URL path is neceeesary to use the entry 

//we are defining an object called routes with a data type of routes 
export const routes: Routes = [
    {path: '', redirectTo: '/home', pathMatch: 'full' }, //empty path should redirect to /home
    {path: 'home', component: HomeComponent},// /home should display the home component 
{path: 'sample-form', component: SampleFormComponent},
{path: 'seals', component : StateSealsComponent}, // /sample-form should display the sample form component
{path: 'students', component: StudentListComponent}, // /students should display the student list component
];
