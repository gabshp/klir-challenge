import { Injectable, InjectionToken } from '@angular/core';
import { HttpEvent, HttpInterceptor, HttpHandler, HttpRequest, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { TimeoutError } from 'rxjs/util/TimeoutError';
import 'rxjs/add/operator/timeout';
import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';
import 'rxjs/add/observable/throw'
import { Inject } from '@angular/core';

@Injectable()
export class APIInterceptor implements HttpInterceptor {

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).timeout(6000).catch(this.handleError);
  }

  private handleError = (error: any) => {
    console.log("interceptor error");

    if (error instanceof TimeoutError) {
      console.log("timeouted");
    }

    return Observable.throw(error);
  }
}
