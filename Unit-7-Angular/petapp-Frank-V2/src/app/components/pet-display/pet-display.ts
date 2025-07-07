import { Component } from '@angular/core';
import { PetInfo } from '../../interfaces/pet-info';
import { PetService } from '../../services/pet.service';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-pet-display',
  imports: [CommonModule],
  templateUrl: './pet-display.html',
  styleUrl: './pet-display.css'
})
export class PetDisplay {
//we need to be sure we have a copy of the pet data
// call the service that has the data to get the data
ourPetInfo: PetInfo[] = [];
constructor(private thepetService: PetService) {
  this.ourPetInfo = thepetService.getPetData();
}


}
