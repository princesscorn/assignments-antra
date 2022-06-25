import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MovieModel } from 'src/app/data-model/movie-model';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-detail-movie',
  templateUrl: './detail-movie.component.html',
  styleUrls: ['./detail-movie.component.css'],
  providers: [MovieService]
})
export class DetailMovieComponent implements OnInit {

  movieId = 0
  movieModel:MovieModel = {
    id: 0,
    title: '',
    overview: '',
    tagline: '',
    budget: 0,
    revenue: 0,
    imdbUrl: '',
    tmdbUrl: '',
    posterUrl: '',
    backdropUrl: '',
    originalLanguage: '',
    releaseDate: new Date("Fri Dec 08 2019 07:44:57"),
    runTime: 0,
    price: 0,
    createdDate: new Date("Fri Dec 08 2019 07:44:57"),
    updatedDate: new Date("Fri Dec 08 2019 07:44:57"),
    updatedBy: '',
    createdBy: ''
  }

  constructor(private mService:MovieService, private activatedRoute:ActivatedRoute) {
    //alert("Movie detail!")
    this.activatedRoute.params.subscribe( p => {
      console.log(p);
      const para = p;
      this.movieId = para["id"];  //case sensive, can not use "Id"
    });
    
    this.ShowMovieById(this.movieId);
    //alert("Movie detail-3!")
   }

  

  ngOnInit(): void {  }

  ShowMovieById(id:number)
  {
    this.mService.getMovieById(id).subscribe((res) => {
      //alert("In ShowMovieById!") 
      this.movieModel = res;
    });
  }
}
