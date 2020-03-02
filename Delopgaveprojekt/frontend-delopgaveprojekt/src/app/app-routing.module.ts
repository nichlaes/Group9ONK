import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateToolComponent } from './create-tool/create-tool.component';

const routes: Routes = [
  { path: 'create', component: CreateToolComponent }
];

@NgModule({
  declarations: [],
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
