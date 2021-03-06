import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AddCastComponent } from './add-cast/add-cast.component';
import { ListCastComponent } from './list-cast/list-cast.component';
import { DetailCastComponent } from './detail-cast/detail-cast.component';
import { CastRoutingModule } from './cast-routing.module';
import { FormsModule } from '@angular/forms';
// {HttpClientModule} only can be imported once in whole project, we import it in app.module.ts
//import { HttpClientModule } from '@angular/common/http'; 



@NgModule({
  declarations: [
    AddCastComponent,
    ListCastComponent,
    DetailCastComponent
  ],
  imports: [
    CommonModule,
    CastRoutingModule,
    FormsModule,
    //HttpClientModule
  ]
})
export class CastModule { }
