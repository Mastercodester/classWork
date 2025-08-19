import { Injectable } from '@angular/core';
import  { HttpClient   }  from '@angular/common/http'; 
import  { HttpHeaders  }  from '@angular/common/http';
 import  { lastValueFrom }  from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class GamblerApiService {
  
   private theServerURL : string = "https://6891e7fa447ff4f11fbe463a.mockapi.io/gamblers"




     constructor(private theGamblerApiServer:HttpClient) {} 


     async getGamblerList()  : Promise<any[]> {

   const theGamblers : any[] =            
   await lastValueFrom(this.theGamblerApiServer.get<any[]>(this.theServerURL)) 


return theGamblers;

      }


      
}
