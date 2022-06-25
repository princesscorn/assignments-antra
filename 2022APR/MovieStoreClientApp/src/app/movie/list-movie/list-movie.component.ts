import { Component, OnInit } from '@angular/core';
import { MovieModel } from 'src/app/data-model/movie-model';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-list-movie',
  templateUrl: './list-movie.component.html',
  styleUrls: ['./list-movie.component.css'],
  providers: [MovieService]
})
export class ListMovieComponent implements OnInit {

  movies:MovieModel[] = []

  constructor(private movieService:MovieService) { this.ShowMoviesList();}

  ngOnInit(): void {  }

  ShowMoviesList()
  {
    this.movieService.getMovies().subscribe((res)=> {this.movies = res;});
  }

  DeleteMovieById(id:number)
  {
    this.movieService.deleteMovie(id).subscribe((res) => {
      alert("Movie has been deleted!")
      this.ShowMoviesList();
    });
  }

}
