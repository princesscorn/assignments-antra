import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { GenreListComponent } from './genre-list/genre-list.component';
import { AddGenreComponent } from './add-genre/add-genre.component';
import { GenreRoutingModule } from './genre-routing.module';



@NgModule({
  declarations: [
    GenreListComponent,
    AddGenreComponent
  ],
  imports: [
    CommonModule,
    GenreRoutingModule
  ]
})
export class GenreModule { }
