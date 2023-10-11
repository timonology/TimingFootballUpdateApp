import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';


import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FootballUpdatesComponent } from './components/football-updates/football-updates.component';
import { SignalrService } from '../app/services/signalr.service';


@NgModule({
  declarations: [
    AppComponent,
    FootballUpdatesComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [ SignalrService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
