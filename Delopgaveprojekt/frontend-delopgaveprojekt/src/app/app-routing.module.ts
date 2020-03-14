import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateToolComponent } from './create-tool/create-tool.component';
import { CreateToolboxComponent } from './create-toolbox/create-toolbox.component';
import { CreateCraftsmanComponent } from './create-craftsman/create-craftsman.component';
import { ShowItemsComponent } from './show-items/show-items.component';

const routes: Routes = [
  { path: 'tool/create', component: CreateToolComponent },
  { path: 'tool/:id', component: CreateToolComponent },
  { path: 'toolbox/create', component: CreateToolboxComponent },
  { path: 'toolbox/:id', component: CreateToolboxComponent },
  { path: 'craftsman/create', component: CreateCraftsmanComponent },
  { path: 'craftsman/:id', component: CreateCraftsmanComponent },
  { path: '**', component: ShowItemsComponent }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
