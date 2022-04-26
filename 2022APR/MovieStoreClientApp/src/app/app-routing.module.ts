import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCastComponent } from './cast/add-cast/add-cast.component';
import { ListCastComponent } from './cast/list-cast/list-cast.component';
import { AddGenreComponent } from './genre/add-genre/add-genre.component';
import { GenreListComponent } from './genre/genre-list/genre-list.component';
import { AddMovieComponent } from './movie/add-movie/add-movie.component';
import { DetailMovieComponent } from './movie/detail-movie/detail-movie.component';
import { ListMovieComponent } from './movie/list-movie/list-movie.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { MovieRoutingModule } from './movie/movie-routing.module';

const routes: Routes = [

  {
    path:'genre',
    loadChildren: () => import ('./genre/genre.module').then( m => m.GenreModule)
  },
  {
    path:'cast',
    loadChildren: () => import ('./cast/cast.module').then( m => m.CastModule)
  },
  {
    path:'movie',
    loadChildren: () => import('./movie/movie.module').then( m => m.MovieModule)
  }, 
  {
    path:'',
    redirectTo: 'movie/list',
    pathMatch:'full'
  },
  {
    path:'home',
    redirectTo: 'movie/list',
    pathMatch:'full'
  },
  {
    path:'Index',
    redirectTo: 'movie/list',
    pathMatch:'full'
  },
  {
    // Page Not Found, must be put in the last one.
    path:"**",
    component:PageNotFoundComponent
  }  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
