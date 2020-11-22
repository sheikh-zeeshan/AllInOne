"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
exports.__esModule = true;
function log(a) {
    console.log(a);
}
var a = 'hello world';
log(a);
//declare types 4 ways
//var [identifier]: [type-annotation] =  value
var b = false;
var num = 10; //floating, octal, binary and hexa decimal
//var [identifier]: [type-annotation];
var hexaNum = 83; //0b123 - 0x123
//var [identifier] = value;
//var [identifier];
var _name = "zeeshan asghar";
//array
var aa = ["ts", "js"];
var ab = ["ts", "sss"];
var tup;
var _ad = 10;
var enumFruit;
(function (enumFruit) {
    enumFruit[enumFruit["apple"] = 0] = "apple";
    enumFruit[enumFruit["orange"] = 1] = "orange";
    enumFruit[enumFruit["banana"] = 2] = "banana";
    enumFruit[enumFruit["mango"] = 3] = "mango";
})(enumFruit || (enumFruit = {}));
console.log(b);
console.log(num);
var fruitname = enumFruit[2];
console.log(fruitname);
//any dynamic type
var age;
age = 10;
age = "my name";
function myfunc() {
    for (var i = 1; i <= 2; i++) {
        console.log("HELLO");
    }
    console.log("final alue of i");
}
myfunc();
var myvar;
myvar = "123";
var myvar2 = myvar;
function prodcut(x, y) {
    return x * y;
}
var anaoymousFnc = function (a) {
    return a * a;
};
console.log(anaoymousFnc(3));
prodcut(2, 3);
var ad = 10;
var _myvar = myvar;
var ex = function (a) { return console.log(a); };
var myclass = /** @class */ (function () {
    function myclass(k) {
        this.j = k;
    }
    myclass.prototype.value = function () {
        return ("the no is " + this.j);
    };
    return myclass;
}());
//class child extends parent class
var _myClass = new myclass(3);
console.log(_myClass.value());
var childclass = /** @class */ (function (_super) {
    __extends(childclass, _super);
    function childclass(a, k) {
        var _this = _super.call(this, k) || this;
        _this.val = a;
        return _this;
    }
    childclass.prototype.value = function () {
        return ("value from parent is" + this.j);
    };
    return childclass;
}(myclass));
var myclsint = /** @class */ (function () {
    function myclsint(ss, tt) {
        this.s = ss;
        this.t = tt;
    }
    myclsint.prototype.myfunc = function () {
        return ("Method not implemented.");
    };
    return myclsint;
}());
