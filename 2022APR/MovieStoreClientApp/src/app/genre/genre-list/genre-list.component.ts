import { Component, OnInit } from '@angular/core';
import { GenreService } from '../genre.service';
import { GenreModel } from 'src/app/data-model/genre-model'

@Component({
  selector: 'app-genre-list',
  templateUrl: './genre-list.component.html',
  styleUrls: ['./genre-list.component.css'],
  providers:[GenreService]
})
export class GenreListComponent implements OnInit {

  genres:GenreModel[] =[];

  constructor(private gService:GenreService) { 
    this.ShowGenresList();
  }

  ShowGenresList()
  { 
    this.gService.GetAllGenres().subscribe( (res)=> {this.genres = res;})
  }

  DeleteGenreById(id:number)
  {
    this.gService.DeleteGenre(id).subscribe((res) => {
      alert("Genre has been deleted!")
      this.ShowGenresList();
    });
  }

  ngOnInit(): void { }
  
}
