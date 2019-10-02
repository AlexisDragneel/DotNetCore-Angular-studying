import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { RecursiveStringComponent } from './recursive-string/recursive-string.component';

import {FormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';  

@NgModule({
  declarations: [
    AppComponent,
    RecursiveStringComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
