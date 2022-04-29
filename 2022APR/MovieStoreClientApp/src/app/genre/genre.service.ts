import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GenreModel } from '../data-model/genre-model';

@Injectable({
  providedIn: 'root'
})
export class GenreService {

  constructor(private httpClient:HttpClient) { }

  GetAllGenres()
  {
    return this.httpClient.get<GenreModel[]>("https://localhost:44390/api/Genre");
  }
}
