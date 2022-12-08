import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule}from '@angular/common/http'
import { Observable } from 'rxjs';
import { Candidate, ICandidate } from '../models/candidate';

@Injectable({
  providedIn: 'root'
})
export class CandidateServiceService {

  baseUrl= 'https://localhost:5001/Candidate/';

  constructor(private http:HttpClient) { }

  getCandidates() : Observable<ICandidate[]>{
    return this.http.get<ICandidate[]>(this.baseUrl+'GetAll');
  }

  getCandidate(id:number  ):Observable<ICandidate>{
    return this.http.get<ICandidate>(this.baseUrl+id);
  }

  postCandidate(candidate:Candidate):Observable<Candidate>{
    return this.http.post<Candidate>(this.baseUrl+'AddCandidate', candidate);
  }

}
