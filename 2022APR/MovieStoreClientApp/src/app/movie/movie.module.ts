import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListMovieComponent } from './list-movie/list-movie.component';
import { AddMovieComponent } from './add-movie/add-movie.component';
import { DetailMovieComponent } from './detail-movie/detail-movie.component';
import { MovieRoutingModule } from './movie-routing.module';
import { FormsModule } from '@angular/forms';
// {HttpClientModule} only can be imported once in whole project, we import it in app.module.ts
//import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    ListMovieComponent,
    AddMovieComponent,
    DetailMovieComponent
  ],
  imports: [
    CommonModule,
    MovieRoutingModule,
    FormsModule,
    //HttpClientModule,
  ]
})
export class MovieModule { }
