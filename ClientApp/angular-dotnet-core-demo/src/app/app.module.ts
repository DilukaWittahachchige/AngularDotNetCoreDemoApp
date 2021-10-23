import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { StudentDashboardModule } from './student-dashboard/student-dashboard.module';
 
@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    StudentDashboardModule 
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
