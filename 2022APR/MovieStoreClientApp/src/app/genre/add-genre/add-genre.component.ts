import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { GenreService } from '../genre.service';
import { GenreModel } from 'src/app/data-model/genre-model';

@Component({
  selector: 'app-add-genre',
  templateUrl: './add-genre.component.html',
  styleUrls: ['./add-genre.component.css'],
  providers:[GenreService]
})

export class AddGenreComponent implements OnInit {

  constructor(private genreService:GenreService) { }
  
  genreModelValue:GenreModel = {
    id:0,
    name:''
  };


  genreName:string="";
  ngOnInit(): void {
  }

  addGenre(genreForm:NgForm) {
    this.genreModelValue.id=0,
    this.genreModelValue.name = genreForm.value.name,
    this.genreService.AddGenre(this.genreModelValue).subscribe((res)=> {
      alert("Genre has been added.")},
      err => {console.log(err)});
  }

  
  /*saveGenre(genreForm: NgForm) {
    console.log(genreForm);
    console.log(genreForm.value);
    //console.log(genreForm.value.genreName);
  }*/
}
