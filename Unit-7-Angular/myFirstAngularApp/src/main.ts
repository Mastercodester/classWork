//this starts the angular application
//when you do ng serve it looks for main.ts to start app
//This is where you define the component representing the home page

import { bootstrapApplication } from '@angular/platform-browser';//Starts the Angular application
import { appConfig } from './app/app.config';// Angular app configuration info




//Specify the folder containing the home page and its name

//import {name - used - in -this-code} from 'path to the component-files'

import { App } from './app/app';//Get the Angular component stuff from './app/app'

bootstrapApplication(App, appConfig)
  .catch((err) => console.error(err));
