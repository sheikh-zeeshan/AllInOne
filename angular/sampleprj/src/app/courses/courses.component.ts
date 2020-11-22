import {COURSES} from './../mockcourse';
import { Component, OnInit } from '@angular/core';
import {Course} from './Course';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css']
})
export class CoursesComponent implements OnInit {

  constructor() { }

  courses=COURSES;
  selectedCourse:Course;
  // course:Course = {
  //   id:1,
  //   name:"Angular 8"
  // }; //  "Angular";

  ngOnInit(): void {

    //put init logic if any 
  }
  onSelect(course:Course):void{
    this.selectedCourse = course;
  }

}
