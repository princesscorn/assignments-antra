import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { CastModel } from 'src/app/data-model/cast-model';
import { CastService } from '../cast.service';

@Component({
  selector: 'app-add-cast',
  templateUrl: './add-cast.component.html',
  styleUrls: ['./add-cast.component.css'],
  providers:[CastService]
})
export class AddCastComponent implements OnInit {

  constructor(private castService:CastService) { }

  castModelValue:CastModel = {
    id:0,
    name:'',
    gender:1,
    tmdbUrl:'',
    profilePath:''
  };

  ngOnInit(): void {
  }

  addCast(castForm:NgForm) {
    this.castModelValue.id=0,
    this.castModelValue.name = castForm.value.name,
    this.castModelValue.gender = castForm.value.gender,
    this.castModelValue.tmdbUrl = castForm.value.tmdbUrl,
    this.castModelValue.profilePath = castForm.value.profilePath,
    this.castService.addCast(this.castModelValue).subscribe((res)=> {
      alert("Cast has been added.")},
      err => {console.log(err)});
  }

  resetForm(castForm:NgForm) {
    castForm.reset();
  }
}
