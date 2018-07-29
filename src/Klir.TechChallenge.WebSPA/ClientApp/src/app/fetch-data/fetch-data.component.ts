import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TimeoutError } from 'rxjs/util/TimeoutError';
import { environment } from '../../environments/environment';

import { ForecastService } from '../shared/services/forecast/forecast.service'
import { Forecast } from '../shared/models/forecast';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

export class FetchDataComponent implements OnInit {
  public forecasts: Forecast[];
  public error: string;  

  constructor(private forecastService: ForecastService) {
  }

  ngOnInit() {
    this.getForecast();
  }

  getForecast() {
    this.error = '';
    this.forecastService.getForecasts()
      .subscribe(
        (response: any) => {
          this.forecasts = response
        },
        error => {
          this.error = error.message;
        });
  }
}
