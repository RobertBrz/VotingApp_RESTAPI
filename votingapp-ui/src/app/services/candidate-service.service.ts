import { Injectable } from '@angular/core';
import {HttpClient, HttpClientModule}from '@angular/common/http'
import { Observable } from 'rxjs';
import { ICandidate } from '../models/candidate';

@Injectable({
  providedIn: 'root'
})
export class CandidateServiceService {

  baseUrl= 'https://localhost:5001/Candidate/';

  constructor(private http:HttpClient) { }

  getCandidates() : Observable<ICandidate[]>{
    return this.http.get<ICandidate[]>(this.baseUrl+'GetAll');
  }

}
