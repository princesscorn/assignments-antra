import { Component, OnInit } from '@angular/core';
import { CastModel } from 'src/app/data-model/cast-model';
import { CastService } from '../cast.service';

@Component({
  selector: 'app-list-cast',
  templateUrl: './list-cast.component.html',
  styleUrls: ['./list-cast.component.css']
})
export class ListCastComponent implements OnInit {

  casts:CastModel[] = [];
  constructor(private castService:CastService) { 
    this.ShowCastsList();
  }

  ShowCastsList()
  {
    this.castService.getCast().subscribe((res) => {this.casts = res;});
  }

  ngOnInit(): void {  } 

}
