import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddCastComponent } from './add-cast/add-cast.component';
import { DetailCastComponent } from './detail-cast/detail-cast.component';
import { ListCastComponent } from './list-cast/list-cast.component';

const routes: Routes = [
    {
        path:"list",
        component:ListCastComponent
    },
    {
        path:"add",
        component:AddCastComponent
    },
    {
        path:"detail/:id",
        component:DetailCastComponent
    }
];

@NgModule({
    //imports: [RouterModule.forRoot(routes)],
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })
  export class CastRoutingModule { }
  