import { Console } from "console";

function log(a) {
    console.log(a);
}

var a = 'hello world'

log(a);

//declare types 4 ways
//var [identifier]: [type-annotation] =  value
    let b:boolean=false;
    let num:number=10;  //floating, octal, binary and hexa decimal
//var [identifier]: [type-annotation];
    let hexaNum=0o123; //0b123 - 0x123
//var [identifier] = value;
//var [identifier];

let _name:string="zeeshan asghar";


//array
let aa:string[] = ["ts", "js"];
let ab:Array<string>=["ts", "sss"];

let tup:[number, string];

const _ad:number=10;

enum enumFruit{
    apple ,
    orange,
    banana,
    mango
}


console.log(b);
console.log(num);

let fruitname:string = enumFruit[2];
console.log(fruitname);

//any dynamic type

let age: any;
age=10;
age="my name";

function myfunc() {
    for(var i=1; i<=2;i++){
        console.log("HELLO");
    }
    console.log("final alue of i");
}

myfunc();

let myvar;
myvar="123";

let myvar2: number=(myvar as number);

function prodcut(x:number, y:number) {
    return x*y;
}

let anaoymousFnc = function (a:number) {
    return a*a;
}
console.log(anaoymousFnc(3));

prodcut(2,3);

const ad =10;

let _myvar :string= (<string>myvar);

let ex =(a) => console.log(a);


class myclass{
    j:number;
private x:number;
    constructor(k: number){
        this.j=k;
    }

    value(){
        return ("the no is " + this.j);
    }
}
//class child extends parent class

let _myClass = new myclass(3);
 
console.log( _myClass.value());

class childclass extends myclass{
    constructor(a:string, k:number){
        super(k);
        this.val = a;
    }
    val:string;
    value(){
        return ("value from parent is" + this.j);
    }
}


interface myint{
    s:number;
    t:string;
    myfunc();
}

class myclsint implements myint{
    s: number;
    t: string;
    myfunc() {
        return ("Method not implemented.");
    }

    constructor(ss:number,tt:string){
        this.s=ss;
        this.t=tt;
    }
    
}