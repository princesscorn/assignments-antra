import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginModel } from 'src/app/data-model/login-model';
import { AuthenticationService } from '../authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username = '';
  password = '';
  loginRequest:LoginModel={
    username:'',
    password:''
  }

  constructor(private auth:AuthenticationService, private router:Router) {  }

  ngOnInit(): void {  }

  userLogin(loginFrm:NgForm)
  {
    //console.log("Enter userLogin");
    this.loginRequest.username = loginFrm.value.username;
    this.loginRequest.password = loginFrm.value.password;
    //this.auth.login(this.loginRequest).subscribe( response=> {console.log(response);}, err=> {console.log(err);} );
    this.auth.login(this.loginRequest).subscribe( 
        response=> {console.log(response.jwt);
                    localStorage.clear();
                    localStorage.setItem('token', response.jwt);
                    this.router.navigateByUrl('home');
                   },         
        err=> {console.log(err);} );
  }

}
