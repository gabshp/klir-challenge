import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../../environments/environment';
import { map } from 'rxjs/operators';

import { Forecast } from '../../../shared/models/forecast';

@Injectable()
export class ForecastService {
  private baseRoute = `${environment.API_ENDPOINT}/api`;

  constructor(private http: HttpClient) { }

  getForecasts() {
    return this.http
      .get(`${this.baseRoute}/WeatherForecast`)
      .pipe(map(response => <Forecast>response));
  }
}
