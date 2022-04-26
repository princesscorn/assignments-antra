import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ListMovieComponent } from './list-movie/list-movie.component';
import { AddMovieComponent } from './add-movie/add-movie.component';
import { DetailMovieComponent } from './detail-movie/detail-movie.component';
import { MovieRoutingModule } from './movie-routing.module';



@NgModule({
  declarations: [
    ListMovieComponent,
    AddMovieComponent,
    DetailMovieComponent
  ],
  imports: [
    CommonModule,
    MovieRoutingModule
  ]
})
export class MovieModule { }
