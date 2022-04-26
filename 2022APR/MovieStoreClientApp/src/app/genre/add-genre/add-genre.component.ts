import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-add-genre',
  templateUrl: './add-genre.component.html',
  styleUrls: ['./add-genre.component.css']
})
export class AddGenreComponent implements OnInit {

  constructor() { }

  genreName:string="";
  ngOnInit(): void {
  }

  saveGenre(genreForm: NgForm) {
    console.log(genreForm);
    console.log(genreForm.value);
    //console.log(genreForm.value.genreName);
  }
}
