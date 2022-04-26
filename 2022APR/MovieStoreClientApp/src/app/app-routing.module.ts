import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { AdminRouteGuard } from './route-guards/admin-route.guard';

const routes: Routes = [

  {
    path:'genre',
    canActivate:[AdminRouteGuard],    // true by default
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
