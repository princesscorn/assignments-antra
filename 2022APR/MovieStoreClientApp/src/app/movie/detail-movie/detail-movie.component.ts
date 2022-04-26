import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-detail-movie',
  templateUrl: './detail-movie.component.html',
  styleUrls: ['./detail-movie.component.css']
})
export class DetailMovieComponent implements OnInit {

  constructor(private activatedRoute:ActivatedRoute) {
    this.activatedRoute.params.subscribe( p => {
      console.log(p);
      const para = p;
      this.movieId = para["id"];  //case sensive, can not use "Id"
    });
   }

   movieId = 0;

  ngOnInit(): void {
  }

}
