import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddMovieComponent } from './add-movie/add-movie.component';
import { DetailMovieComponent } from './detail-movie/detail-movie.component';
import { ListMovieComponent } from './list-movie/list-movie.component';
import { LoginComponent } from '../authentication/login/login.component';

const routes: Routes = [
    {
        path:"list",
        component:ListMovieComponent
    },
    {
        path:"add",
        component:AddMovieComponent
    },
    {
        path:"detail/:id",
        component:DetailMovieComponent
    },
    {
        path:"",
        component:LoginComponent
    }
];

@NgModule({
    //imports: [RouterModule.forRoot(routes)],
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class MovieRoutingModule { }
  