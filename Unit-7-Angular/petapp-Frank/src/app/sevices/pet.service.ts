//created via ng g service services/pet.service
//which makes it dependency injectable automatically
//             and creates an empty constructor

import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PetService {

  constructor() { }
}
