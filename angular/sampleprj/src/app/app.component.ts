import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Zeeshan angular demo';
  _proj_date = new Date();
  _name='Test app by zeeshan'
  buttonTextSize:number=30;
  applyBold:string='bold'
  name=""
  public myId="testid";

constructor(){
  console.log("start.. component");
}
public welcomMSG(){return " WELCOME Dear user" + this.title;}

applyStyle(){
  var myStyles ={
    'font-size.px': this.buttonTextSize,
    'font-weight': this.applyBold
  };
   return myStyles;
}
public message ="";
public onClick(): void{
  console.log("Button is clicked");
  this.message="welcome to angular";
}
}
