import { Component } from '@angular/core';

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

  logMessage()
  {
    console.log("button is clicked. ");
    console.log(this.studentName);
  }

}

