import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { CastModel } from 'src/app/data-model/cast-model';
import { CastService } from '../cast.service';

@Component({
  selector: 'app-detail-cast',
  templateUrl: './detail-cast.component.html',
  styleUrls: ['./detail-cast.component.css'],
  providers:[CastService]
})
export class DetailCastComponent implements OnInit {

  castId = 0;
  
  castModel:CastModel = {
    id:0,
    name:'',
    gender:1,
    tmdbUrl:'',
    profilePath:'',
    MovieCasts:[]
  };

  constructor(private cService:CastService, private activatedRoute:ActivatedRoute) {
    //alert("Cast detail!")
    this.activatedRoute.params.subscribe( p => {
      console.log(p);
      const para = p;
      this.castId = para["id"];  //case sensive, can not use "Id"
    });
    this.ShowCastById(this.castId);
   }

   
  ngOnInit(): void {
  }

  ShowCastById(id:number)
  {
    this.cService.getCastById(id).subscribe((res) => {
      //alert("In ShowCastById!") 
      this.castModel = res;
    });
  }
}
