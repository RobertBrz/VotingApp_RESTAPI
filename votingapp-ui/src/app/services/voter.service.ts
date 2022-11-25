import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule}from '@angular/common/http'
import { Observable } from 'rxjs';
import { IVoter } from '../models/voter';


@Injectable({
  providedIn: 'root'
})
export class VoterService {

baseUrl= 'https://localhost:5001/Voter/';

  constructor(private http:HttpClient) { }

  getVoters():Observable<IVoter[]>{
    return this.http.get<IVoter[]>(this.baseUrl+'Voters');
  }

  getVoter(id :number ):Observable<IVoter>{
  return this.http.get<IVoter>(this.baseUrl+id);
  }

  postVoter(voter : IVoter):void {
    this.http.post(this.baseUrl+'Add', voter);
  }
}
