import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddGenreComponent } from './add-genre/add-genre.component';
import { GenreListComponent } from './genre-list/genre-list.component';

const routes: Routes = [
    {
        path:"list",
        component:GenreListComponent
    },
    {
        path:"add",
        component:AddGenreComponent
    }
];

@NgModule({
    //imports: [RouterModule.forRoot(routes)],
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class GenreRoutingModule { }
  