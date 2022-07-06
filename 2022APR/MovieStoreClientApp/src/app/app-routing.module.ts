import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './authentication/login/login.component';
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
    canActivate:[AdminRouteGuard],    // true by default
    loadChildren: () => import ('./cast/cast.module').then( m => m.CastModule)
  },
  {
    path:'movie',
    canActivate:[AdminRouteGuard],    // true by default
    loadChildren: () => import('./movie/movie.module').then( m => m.MovieModule)
  }, 
  {
    path:'',
    component:LoginComponent
  },
  {
    path:'login',
    component:LoginComponent
  },
  {
    path:'home',
    component:LoginComponent
    //redirectTo: 'movie/list',
    //pathMatch:'full'
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
