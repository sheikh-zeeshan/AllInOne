import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoursesComponent } from './courses/courses.component';
import { FormsModule } from '@angular/forms';
import { EmployeeComponent } from './employee/employee.component'

@NgModule({
  declarations: [ //component, pipes and delaratives here
    AppComponent,
    CoursesComponent,
    EmployeeComponent
  ],
  imports: [    //modules
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
