import { Component } from '@angular/core';

@Component({
  selector: 'Students',
  templateUrl: './student.component.html',
  styleUrls: ['./student.component.css']
})
export class StudentComponent{

firstName:string="Raffay";
lastName:string="Zeeshan";
gender:string="boy"
age:number=9
constructor() { }
}


