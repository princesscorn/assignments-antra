import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GenreListComponent } from './genre-list/genre-list.component';
import { AddGenreComponent } from './add-genre/add-genre.component';
import { GenreRoutingModule } from './genre-routing.module';
import { FormsModule } from '@angular/forms';
// {HttpClientModule} only can be imported once in whole project, we import it in app.module.ts
//import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    GenreListComponent,
    AddGenreComponent
  ],
  imports: [
    CommonModule,
    GenreRoutingModule,
    FormsModule,
    //HttpClientModule
  ]
})
export class GenreModule { }
