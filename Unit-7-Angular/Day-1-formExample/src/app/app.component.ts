import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
// import for external component - may be automatically added by IDE
import { FormExampleComponent } from './components/form-example/form-example.component';
// @Component identifies all the Angular stuff you are using
//            including new components
@Component({
  selector: 'app-root',// st the name of the tag used in html to refernce the component
  standalone: true,

  // imports identifies external resources, like components, used in the app
  imports: [ FormExampleComponent],  // Note the name has Component
  templateUrl: './app.component.html',           // the file containing the HTML for this component
                                                // the file containing the css for this component
  styleUrl: './app.component.css'
})
// export Allows processes outside this component to access things defined in the component 
// any data or methods you want angular to use must be exported from Typescript file for the component
// To use One-Way Binding for data defined in this code in the HTML:  {{variable-name}}
export class AppComponent {
  pageHeading = 'Welcome to Bananna AHBC - C# - Contact Info Submission'
}
