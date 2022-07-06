import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GenreModel } from '../data-model/genre-model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private httpClient:HttpClient) { }

  AddGenre(genreModel:GenreModel) {
    //return this.httpClient.post<any>("https://localhost:44390/api/Genre/add", genreModel).pipe(map((res:any)=> {return res;}));
    return this.httpClient.post<any>("https://localhost:7250/api/Genre/add", genreModel).pipe(map((res:any)=> {return res;}));
  }

  GetAllGenres() {
    //return this.httpClient.get<GenreModel[]>("https://localhost:44390/api/Genre");
    return this.httpClient.get<GenreModel[]>("https://localhost:7250/api/Genre");
  }

  DeleteGenre(id:number) {
    //return this.httpClient.delete("https://localhost:44390/api/Genre/remove/" + id);
    return this.httpClient.delete("https://localhost:7250/api/Genre/remove/" + id);
  }
}
