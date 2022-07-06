import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'
import { MovieModel } from '../data-model/movie-model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class MovieService {

  constructor(private httpClient:HttpClient) { }

  addMovie(movieModel:MovieModel) {
    //return this.httpClient.post<any>("https://localhost:44390/api/Movie/add", movieModel).pipe(map((res:any)=> {return res;}));
    return this.httpClient.post<any>("https://localhost:7250/api/Movie/add", movieModel).pipe(map((res:any)=> {return res;}));
  }

  getMovies() {
    return this.httpClient.get<MovieModel[]>("https://localhost:7250/api/Movie");
  }

  getMovieById(id:number) {
    return this.httpClient.get<MovieModel>("https://localhost:7250/api/Movie/" + id);
  }

  deleteMovie(id:number) {
    //return this.httpClient.delete("https://localhost:44390/api/Movie/remove/" + id);
    return this.httpClient.delete("https://localhost:7250/api/Movie/remove/" + id);
  }

}
