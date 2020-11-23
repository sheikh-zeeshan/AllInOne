import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Zeeshan angular demo';
  _proj_date = new Date();

constructor(){
  console.log("start.. component");
}

}
