import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import { catchError, Observable, throwError } from 'rxjs';

@Injectable()
export class AuthInterceptor implements HttpInterceptor {

  constructor() {}

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    //return next.handle(request);
    //console.log("Enter intercept");
    const token = localStorage.getItem('token');
    return next.handle(request.clone(
      {
        setHeaders:{"Authorization": `Bearer ${token}`}
        //setHeaders:{'authorization': 'token' + token}
      }
    ));
  }
}
