//Service manage the datat for the app and acess to the data

// Created via ng g service services/pet.service
// Which makes it Dependency Injectable automatically
//       and creates an empty constructor
import { Injectable } from '@angular/core';
import { PetInfo } from '../interfaces/pet-info';

@Injectable({
  providedIn: 'root'
})
export class PetService {

petData: PetInfo[] = []

  constructor() { 
    this.petData.push({name: 'Frank', type: 'Dog', gender: 'boy', age: 5});
    this.petData.push({name: 'Signora', type: 'Dog', gender: 'girl', age: 3});
    

  }
  // Method to get the pet data
  getPetData(): PetInfo[] {
    return this.petData;
  }
}
