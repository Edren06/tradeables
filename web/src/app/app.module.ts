import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { ProductListComponent } from './product-list/product-list.component';
import { RouterModule } from '@angular/router';
import { routes } from './app.routes';
import { DataService } from './data.service';

@NgModule({
  declarations: [AppComponent, ProductListComponent],
  imports: [BrowserModule, HttpClientModule, RouterModule.forRoot(routes)],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }