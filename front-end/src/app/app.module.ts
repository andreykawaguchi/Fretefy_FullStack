import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeModule } from './modules/home/home.module';
import { ToolbarModule } from './components/toolbar/toolbar.module';
import { RouterModule } from '@angular/router';
import { RegiaoService } from './services/regiao.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './shared/material.module';
import { CidadeService } from './services/cidade.service';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    HttpClientModule,
    HomeModule,
    ToolbarModule,
    MaterialModule,

    AppRoutingModule,

    BrowserAnimationsModule,
  ],
  providers: [RegiaoService, CidadeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
