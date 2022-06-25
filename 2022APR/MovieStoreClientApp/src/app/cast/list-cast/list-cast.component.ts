import { Component, OnInit } from '@angular/core';
import { CastModel } from 'src/app/data-model/cast-model';
import { CastService } from '../cast.service';

@Component({
  selector: 'app-list-cast',
  templateUrl: './list-cast.component.html',
  styleUrls: ['./list-cast.component.css'],
  providers: [CastService]
})
export class ListCastComponent implements OnInit {

  casts:CastModel[] = [];
  constructor(private castService:CastService) { 
    this.ShowCastsList();
  }

  ngOnInit(): void {  } 

  ShowCastsList()
  {
    alert("Show All Casts!")
    this.castService.getCast().subscribe((res) => {this.casts = res;});
  }

  DeleteCastById(id:number)
  {
    this.castService.deleteCast(id).subscribe((res) => {
      alert("Cast has been deleted!")
      this.ShowCastsList();
    });
  }

}
