import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CastModel } from '../data-model/cast-model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class CastService {

  constructor(private Http:HttpClient) { }

  addCast(castModel:CastModel){
    return this.Http.post<any>("http://localhost:50091", castModel).pipe(map((res:any)=> {return res;}));
  }
}
