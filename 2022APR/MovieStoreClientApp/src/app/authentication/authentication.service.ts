import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { LoginModel } from '../data-model/login-model';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http:HttpClient) { }

  login(request:LoginModel)
  {
    return this.http.post<any>("https://localhost:7250/api/account/login", request);
  }
}
