import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CoursesComponent } from './courses/courses.component';
import { FormsModule } from '@angular/forms';
import { EmployeeComponent } from './employee/employee.component'
import { CompanyModule } from './company/company.module'
import { StudentComponent} from './student/student.component'
@NgModule({
  declarations: [ //component, pipes and delaratives here , compile time
    AppComponent,
    CoursesComponent,
    EmployeeComponent,
    StudentComponent
  ],
  imports: [    //modules
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    CompanyModule //feature module,(logical grouping)
  ],
  providers: [], //service error at run time,injector type, not compile time
  bootstrap: [AppComponent] //
})
export class AppModule {

constructor(){
  console.log("hi this is module");
}

}
