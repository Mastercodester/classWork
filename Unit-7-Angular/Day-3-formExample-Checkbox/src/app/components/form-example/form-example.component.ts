import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { throwError } from 'rxjs';

@Component({
  selector: 'form-example',  // Name used in html to reference the component <form-example>
  standalone: true,
  imports: [FormsModule, CommonModule],  // Tell Angular we want Forms support for this code
  templateUrl: './form-example.component.html',
  styleUrl: './form-example.component.css'
})
// Allow access to stuff defined this component from outside the component
export class FormExampleComponent {
  // Data to be shared with the Angular when processing the web page
  buttonClicked = false
  firstName = ""     // hold the data from first name from the form
  lastName = ""      // hold the data from last name from the form
  birthday = ""      // hold the data from birthday from the form
  foodPreference = ""
  emailAddress = ""
  sendEmail = ""
  // A checkbox control may have multiple values (many checkboxes can be checked)
  // Sports is specified as a checkbox it's data will be returned as an array
  // With each element in the array corresponding to a choice
  // Checkbox need to be included in the html a individual element
  // More tomorrow
  //sports : any[] 
  sports : any[] = [ // any type is used to make the array flexible - hold kind of datat
    {
      name: 'football',
      value: 'football'
    },
    {
      name: 'basketball',
      value: 'basketball'
    },
    {
      name: 'baseball',
      value: 'baseball'
    },
    {
      name: 'soccer',
      value: 'soccer'
    }
    , {
      name: 'cricket',
      value: 'cricket'
    }
    , {
      name: 'other',
      value: 'other'
    }
    , {
      name: 'hockey',
      value: 'hockey'
     
    }
  ]
 // Methods to handle interactions with the html/web page
  onSubmit() { // Handle the Submit button click on the  form
    this.buttonClicked = true
    console.log(`OK.... You Clicked Submit`)
    console.log(`You entered ${this.firstName} in the First Name field`)
    console.log(`You entered ${this.lastName} in the Last Name field`)
    console.log(`You entered ${this.emailAddress} in the email field`)
  //  console.table(this.sports)
  console.table(this.checkBoxResult)
//.forEach() - an array function that will loop through an arra passing each element to an arrow function(=>)
this.checkBoxResult.forEach((aBox) => console.log(aBox.name)
)}

  get checkBoxResult() {
    // Loop through the sports array
    // This will be used in the html to display the values
return this.sports.filter((aCheckbox) => aCheckbox.checked)

   /* if (this.sports) {
      return this.sports.filter(sport => sport.checked).map(sport => sport.value);
    } else {
      return [];
    }
      */

  }
}