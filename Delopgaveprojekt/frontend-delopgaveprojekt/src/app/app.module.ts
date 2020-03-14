import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { AppRoutingModule } from './app-routing.module';
import { CreateToolComponent } from './create-tool/create-tool.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { ToolService } from './services/tool.service';
import { CreateToolboxComponent } from './create-toolbox/create-toolbox.component';
import { ToolBoxService } from './services/toolbox.service';
import { HttpClientModule } from '@angular/common/http';
import { CreateCraftsmanComponent } from './create-craftsman/create-craftsman.component';
import { CraftsmanService } from './services/craftsman.service';
import { ShowItemsComponent } from './show-items/show-items.component';

@NgModule({
  declarations: [
    AppComponent,
    CreateToolComponent,
    CreateToolboxComponent,
    CreateCraftsmanComponent,
    ShowItemsComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule
  ],
  providers: [ToolService, ToolBoxService, CraftsmanService],
  bootstrap: [AppComponent]
})
export class AppModule { }
