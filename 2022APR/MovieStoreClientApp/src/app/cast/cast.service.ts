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
    //return this.Http.post<any>("http://localhost:50091", castModel).pipe(map((res:any)=> {return res;}));
    //return this.Http.post<any>("http://localhost:59724", castModel).pipe(map((res:any)=> {return res;}));
    //return this.Http.post<any>("http://localhost:4200", castModel).pipe(map((res:any)=> {return res;}));
    //return this.Http.post<any>("http://localhost:5272", castModel).pipe(map((res:any)=> {return res;}));
    //return this.Http.post<any>("https://localhost:7272", castModel).pipe(map((res:any)=> {return res;}));
    return this.Http.post<any>("https://localhost:44390/api/Cast/add", castModel).pipe(map((res:any)=> {return res;}));
  }

  getCast() {
    return this.Http.get<CastModel[]>("https://localhost:44390/api/Cast");
  }
}
