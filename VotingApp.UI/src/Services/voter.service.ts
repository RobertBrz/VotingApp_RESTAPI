import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

import { Observable, throwError, } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

import { IVoter } from 'src/Shared/interfaces';


@Injectable({
  providedIn: 'root'
})

export class VoterService {
  baseUrl = "https://localhost:5001/";
  baseVoterUrl = this.baseUrl + 'Voter/';


  constructor(private http: HttpClient) { }

  getVoters(): Observable<IVoter[]> {
    return this.http.get<IVoter[]>(this.baseVoterUrl + 'Voters')
      .pipe(
        map(voters => voters.map((voter): IVoter => ({
          id: voter.id,
          name: voter.name,
          pesel: voter.pesel,
        })))
        //map(voters => {
        //  return voters;
        //})
      );
  }
}
