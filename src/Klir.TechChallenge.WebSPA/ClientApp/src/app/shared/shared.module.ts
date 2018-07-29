import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpModule } from '@angular/http';

import { ForecastService } from './services/forecast/forecast.service';
import { APIInterceptor } from './services/http/http.interceptor';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  declarations: [
  ],
  exports: [
    HttpModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [
    ForecastService,
    APIInterceptor
  ]
})

export class SharedModule { }
