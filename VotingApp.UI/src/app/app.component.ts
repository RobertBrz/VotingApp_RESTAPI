import { HttpClient } from '@angular/common/http';
import { Component, NgModule } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  public forecasts?: WeatherForecast[];

  title = 'VotingApp.UI';

  constructor(http: HttpClient) {
    //http.get<WeatherForecast[]>('/weatherforecast').subscribe(result => {
    //  this.forecasts = result;
    //}, error => console0.error(error));
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
