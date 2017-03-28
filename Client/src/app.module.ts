import { NgModule } from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';

import { AppComponent } from './app/components/app.component';
import { NavbarComponent } from './app/components/navbar/navbar-component';

import { CategoryService } from './app/services/category.service';

@NgModule({
  imports: [
    BrowserModule
  ],
  declarations: [
    AppComponent,
    NavbarComponent
  ],
  bootstrap: [ AppComponent ],
  providers: [
    CategoryService
  ]
})

export class AppModule { }