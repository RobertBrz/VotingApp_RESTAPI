import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule, HttpParams }from '@angular/common/http'
import { catchError, Observable, throwError } from 'rxjs';
import { IVoter, Voter } from '../models/voter';
import { MessageService } from './message.service';


@Injectable({
  providedIn: 'root'
})
export class VoterService {


baseUrl= 'https://localhost:5001/Voter/';

  constructor(private http:HttpClient,
    private messageService :MessageService
   ) { }

  getVoters():Observable<IVoter[]>{
    return this.http.get<IVoter[]>(this.baseUrl+'Voters');
  }

  getVoter(id :number ):Observable<IVoter>{
   var result  =   this.http.get<IVoter>(this.baseUrl+'Voters/'+id);
 
  return  result;
  }

  postVoter(voter : Voter):Observable<Voter> {
    this.messageService.addMessage("post voter "+voter.name+" " + voter.id +" "+ voter.pesel)
    // var vJson = JSON.stringify(voter);
  //   let  params  =  new HttpParams()
  //    .append('name', voter.name)
  //    .append('pesel', voter.pesel);
  //  return  this.http.post<Voter>(this.baseUrl+'A?name='+voter.name+'&pesel='+voter.pesel,{params:params});
  //return  this.http.post<any>(this.baseUrl+'Add',{name:params.get("name") , pesel:params.get('pesel')});
    
   return this.http.post<Voter>(this.baseUrl+'Add', voter);
    // .pipe(
    //   catchError(this.handleError('addHero', hero))
    this.messageService.addMessage("sent ");
  }
  
}
