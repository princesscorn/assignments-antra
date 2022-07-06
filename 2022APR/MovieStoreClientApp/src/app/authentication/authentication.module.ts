import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { FormsModule } from '@angular/forms';
// {HttpClientModule} only can be imported once in whole project, we import it in app.module.ts
//import { HttpClientModule } from '@angular/common/http';
import { AuthenticationService } from './authentication.service';



@NgModule({
  declarations: [
    LoginComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    //HttpClientModule
  ],
  providers:[AuthenticationService]
})
export class AuthenticationModule { }
