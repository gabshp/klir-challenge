import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public forecasts: WeatherForecast[];
  private baseRoute = `${environment.API_ENDPOINT}/api`;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {    

    http.get<WeatherForecast[]>(this.baseRoute + '/WeatherForecast').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }
}

interface WeatherForecast {
  dateFormatted: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
