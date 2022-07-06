import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddGenreComponent } from './add-genre/add-genre.component';
import { GenreListComponent } from './genre-list/genre-list.component';
import { LoginComponent } from '../authentication/login/login.component';

const routes: Routes = [
    {
        path:"list",
        component:GenreListComponent
    },
    {
        path:"add",
        component:AddGenreComponent
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
  export class GenreRoutingModule { }
  