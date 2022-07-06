import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'MovieStoreClientApp';
  showTitle=true;
  studentName="Catherine"
  employees = ["Daniel", "Roger", "Olivia", "Rhea"]
  
  stateAcc="TX"

  constructor(private router:Router) {  }

  logMessage()
  {
    console.log("button is clicked. ");
    console.log(this.studentName);
  }

  logout()
  {
    localStorage.clear();
    console.log("In logout")
    this.router.navigateByUrl("login");
  }

}

