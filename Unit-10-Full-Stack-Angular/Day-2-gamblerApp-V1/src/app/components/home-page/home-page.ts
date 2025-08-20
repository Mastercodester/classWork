import { Component } from '@angular/core';
import { GamblerDataLayout } from '../../interfaces/GamblerDataLayout';
import { CommonModule } from '@angular/common';
import { GamblerApiService } from '../../services/gambler-api-service';
@Component({
  selector: 'app-home-page',
  imports: [CommonModule],
  templateUrl: './home-page.html',
  styleUrl: './home-page.css'
})
export class HomePage {
theGamblers : GamblerDataLayout[] = []
  //{id: 1, address: "Detroit", name: "Smokkey", birthDate : "03-20-1989" , salary: 100000000000000000},
  //{id: 2, address: "Tupelo", name: "Al Capone", birthDate : "03-20-1910" , salary: 5000},
//  {id: 3, address: "Miami", name: "Maanski", birthDate : "04-11-1960" , salary: 5000}


shouldDisplayForm : boolean = false;

constructor(private gamblerService : GamblerApiService){}

 async ngOnInit(){    
this.theGamblers = await this.gamblerService.getGamblerList();  
console.table(this.theGamblers)      
        } 
}
