import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  buttonClicked = false
  firstName = "" // Two-way data binding with the input field // hold the data for FirstName
  lastName = "" // Two-way data binding with the input field // hold the data for LastName\
  birthDate = "" // Two-way data binding with the input field // hold the data for BirthDate
 foodPreferences  = "" // Two-way data binding with the input field // hold the data for FoodPreferences
  email = "" // Two-way data binding with the input field // hold the data for Email
  // Two-way data binding with the input field // hold the data for
  sports = "" // List of sports for the dropdown
  onSubmit() { // Handle the Submit button click on the  form
    this.buttonClicked = true
    console.log(`OK.... You Clicked Submit`)
    console.log(`First Name: ${this.firstName}`)
    console.log(`Last Name: ${this.lastName}`)
    console.log(`Birth Date: ${this.birthDate}`)
    console.log(`Food Preferences: ${this.foodPreferences}`)
    console.log(`Email: ${this.email}`)
    console.log(`Sports: ${this.sports}`)
  }
}