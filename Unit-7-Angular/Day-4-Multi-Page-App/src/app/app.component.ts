// import gives us access to external features and components
// Most imported name must be included in imports property of @Component
import { Component }       from '@angular/core';
import { RouterOutlet }    from '@angular/router';

//we must import any component used by this component 
// the import name is the component name (without a -)Componenet
import { NavBarComponent } from './components/nav-bar/nav-bar.component';

//The home componenet is used in  the nav-bar component
// which is included in  this component
//This 
import { HomeComponent }   from './components/home/home.component';

@Component({ // Metadata for the component - gives Angular some basic info
  selector: 'app-root',  // This is what is used to include this component 
                         //      on a page 
  standalone: true,      // Added in Angular 17 to allow components to ne independent

  //include the import name for anty component in the imports attrOF @Component
  imports: [RouterOutlet, NavBarComponent, HomeComponent], // identifies things used

  templateUrl: './app.component.html',  // Where to find the html file
  styleUrl: './app.component.css'       //       and css file
})
// This defines a module for this component
// export - say let things outside this component have access to it
// class - This is a group of things associated with this component 
export class AppComponent {
 
}
