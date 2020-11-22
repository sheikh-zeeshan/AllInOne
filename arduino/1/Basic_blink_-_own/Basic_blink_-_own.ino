 
/*
  ESP8266 Blink by Simon Peter
  Blink the blue LED on the ESP-01 module
  This example code is in the public domain

  The blue LED on the ESP-01 module is connected to GPIO1
  (which is also the TXD pin; so we cannot use Serial.print() at the same time)

  Note that this sketch uses LED_BUILTIN to find the pin with the internal LED
*/
#include <ESP8266WiFi.h>
#include <Wire.h>
#include <LiquidCrystal_I2C.h>
#include <DHT.h>

//variables
// set the LCD number of columns and rows
int lcdColumns = 16;
int lcdRows = 2;
char ssid[] = "PTCL-BB";
char pass[] = "f296ded9";
int rhs = 5;  /*1= buit in led, 2 blink at d2, 3= wifi, 4 = lcd,  5= DHT11*/
int val;


//define
#define DHTPIN  D3
#define DHTTYPE DHT11
//#define LED_BLUE D0
#define LED_BUILTIN D4
#define LED D2
#define BUZZER_PIN D5;

//DHT object
DHT dht (DHTPIN, DHTTYPE);
// set LCD address, number of columns and rows
// if you don't know your display address, run an I2C scanner sketch
LiquidCrystal_I2C lcd(0x27, lcdColumns, lcdRows);  

/*===========================================================*/
void setup() {

  if (1 == rhs) {
    //zeeshan - led builtin not defined means build in, if change to D2 it changes
    pinMode(LED_BUILTIN, OUTPUT);     // Initialize the LED_BUILTIN pin as an output
  } else if (2 == rhs) {
    pinMode(LED, OUTPUT); //fade effect
  }
  else if (3 == rhs) { //network connectivity
    Serial.begin(9600);
    delay(500);
    Serial.print("Connecting to..");
    Serial.println(ssid);
    delay(500);
    WiFi.disconnect();
    WiFi.begin(ssid, pass);
    while (WiFi.status() != WL_CONNECTED)
    {
      delay(500);
      Serial.println(".");
    }
    Serial.print("SSID...");
    Serial.println (WiFi.SSID());
    Serial.println("Successfully connected!!!");

    Serial.print("IP Address allotted to NodeMcu ESP..");
    Serial.println(WiFi.localIP());

    Serial.print("MAC Address of ESP...");
    Serial.println(WiFi.macAddress());
    WiFi.printDiag(Serial);
  }
  else if (4 == rhs) {
   
   // initialize LCD
  lcd.init();
  // turn on LCD backlight                      
  lcd.backlight();
  }
  else if (5 == rhs){
    
    Serial.begin(9600);
    Serial.println("DHT 11 test");
    dht.begin();

     // initialize LCD
    lcd.init();
    // turn on LCD backlight                      
    lcd.backlight();
    
    }
}

// the loop function runs over and over again forever
void loop() {
   
  if (1 == rhs) {
    digitalWrite(LED_BUILTIN, LOW);   // Turn the LED on (Note that LOW is the voltage level
    // but actually the LED is on; this is because
    // it is active low on the ESP-01)
    delay(1000);                      // Wait for a second
    digitalWrite(LED_BUILTIN, HIGH);  // Turn the LED off by making the voltage HIGH
    delay(2000);                      // Wait for two seconds (to demonstrate the active low LED)
  } else if (2 == rhs) {
    for (val = 0; val < 1000; val += 50) {
      analogWrite(LED, val);
      delay(100);
    }

    for (val = 1000; val > 1; val -= 50) {
      analogWrite(LED, val);
      delay(100);
    }
  }
  else if (3 == rhs) {

    //do nothing
  }
  else if (4 == rhs){
    // set cursor to first column, first row
  lcd.setCursor(0, 0);
  // print message
  lcd.print("Hello, World!");
  delay(1000);
  // clears the display to print new message
  lcd.clear();
  // set cursor to first column, second row
  lcd.setCursor(0,1);
  lcd.print("share video!");
  delay(1000);
  lcd.clear(); 

  Serial.println("--XX--");
    
    }

    else if (5 == rhs){
       delay(3000);
       lcd.clear();
       
       float h = dht.readHumidity();
       float t = dht.readTemperature(); //centigrade
       float f = dht.readTemperature(true); //farhite


        if (isnan(h) || isnan(t) || isnan(f)){
          Serial.println("failed to read temperature");
          return;
        }

        String values = "Hunmidity : " + String(h) +  " Temperature C : " + String(t) + " 'C Temperature F : " + String(f) + " 'F";
        Serial.println(values);
     
        String lcdValues = "H= " + String(h);
        lcd.setCursor(0, 0);
        lcd.print(lcdValues);
        
        lcdValues = "'C=" + String(t) + ",'F=" + String(f); 
        lcd.setCursor(0, 1);
        lcd.print(lcdValues);

        if (t > 32)
        {
          tone(14,780,160); //pin, frequency, duration
        }
        }
      
      }
