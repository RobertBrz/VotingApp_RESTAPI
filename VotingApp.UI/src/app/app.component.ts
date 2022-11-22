import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Observable } from 'rxjs';

import { VoterService } from 'src/Services/voter.service'
import { IVoter } from '../Shared/interfaces';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public forecasts?: WeatherForecast[];
  public voters?: Observable<IVoter[]>;

  constructor(http: HttpClient,
    private voterService: VoterService) {
    //http.get<WeatherForecast[]>('/weatherforecast').subscribe(result => {
    //  this.forecasts = result;
    //}, error => console.error(error));
    this.getVoters();
  }

  title = 'VotingApp.UI';

  getVoters() {
    var voters = this.voterService.getVoters();
    //voters.forEach(v => console.log(v))
    voters.forEach(item => console.log(item));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
