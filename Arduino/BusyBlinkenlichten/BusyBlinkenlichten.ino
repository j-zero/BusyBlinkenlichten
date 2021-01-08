#include <Arduino.h>
#include <FastLED.h>      // https://github.com/FastLED/FastLED

#define LED_COUNT 1
#define LED_DATA_PIN 2

CRGB leds[LED_COUNT];

CRGB solidColor = CHSV(160,255,255);
CRGB blinkColor = CHSV(0,0,0);


uint8_t maxBrightness = 128;
uint16_t heartbeat = 1000;

uint8_t blinkEnabled = 0;
uint8_t blinkState = 0;
uint16_t blinkInterval = 500;

uint8_t fadeEnabled = 0;
uint16_t fadeDelay = 5;
uint16_t fadeValue = maxBrightness;
uint16_t fadeDirection = 1;

unsigned long previousMillisHeartBeat = 0;
unsigned long previousMillisBlink = 0;
unsigned long previousMillisFade = 0;

void setup() {
  
  Serial.begin (115200);
  LEDS.addLeds<WS2812,LED_DATA_PIN,GRB>(leds,LED_COUNT).setCorrection(TypicalSMD5050);
  LEDS.setBrightness(255);
  FastLED.clear();

  static uint8_t hue = 0;
  // First slide the led in one direction
  for(int i = 0; i < 255; i++) {
    for(int l = 0; l < LED_COUNT; l++){
      leds[l] = CHSV(i, 255, 255);
    }
    FastLED.show(); 
    delay(5);
  }
  FastLED.show(); 
  
}

void fadeall() { for(int i = 0; i < LED_COUNT; i++) { leds[i].nscale8(250); } }

void loop() {
    static uint8_t c = 0;
    static uint8_t b1 = 0;
    static uint8_t b2 = 0;
    static uint8_t b3 = 0;
    
    unsigned long currentMillis = millis();

    // Heartbeat
    if (currentMillis - previousMillisHeartBeat >= heartbeat) {
      previousMillisHeartBeat = currentMillis;
      Serial.println("heartbeat");
    }
    
    // Blink
    if (currentMillis - previousMillisBlink >= blinkInterval) {
      previousMillisBlink = currentMillis;
      if(blinkState == 0)
        blinkState = 1;
      else
        blinkState = 0;
    }

    // Fade
    if (currentMillis - previousMillisFade >= fadeDelay) {
      previousMillisFade = currentMillis;
      if(fadeDirection == 0) {  // Up
        if (fadeValue >= maxBrightness) {
          fadeDirection = 1;  // Go Down
        }
        else{
          fadeValue++;
        }
      }
      else{                   // Down
        if (fadeValue == 0) {
          fadeDirection = 0;  // Go Down
        }
        else{
          fadeValue--;
        }
      }
    }
    
    if (Serial.available() == 4){
      
        c = Serial.read();
        b1 = Serial.read();
        b2 = Serial.read();
        b3 = Serial.read();
        
        Serial.print("0x");
        Serial.print(c,HEX);
        Serial.print(" ");
        Serial.print("0x");
        Serial.print(b1,HEX);
        Serial.print(" ");
        Serial.print("0x");
        Serial.print(b2,HEX);
        Serial.print(" ");
        Serial.print("0x");
        Serial.print(b3,HEX);

        
        switch(c){
          case 0x00: // HSV
              solidColor = CHSV(b1, b2, b3);
              break;
          case 0x01: // RGB
              solidColor = CRGB(b1, b2, b3);
              break;
          case 0x02: // Blink On
              // 0x02 = Blink, 0x00/0x01 = Blink On/Off, 0x01 << 8 + 0xF4 = 500ms; 
              blinkEnabled = b1;
              blinkInterval = (b2 << 8) + b3;
              fadeEnabled = 0;
              break;
          case 0x03: // Blink Color HSV
              blinkColor = CHSV(b1, b2, b3);
              break;
          case 0x04: // Blink Color RGB
              blinkColor = CRGB(b1, b2, b3);
              break;
          case 0x05: // Fade On
              // 0x05 = Fade, 0x00/0x01 = Fade On/Off, 0x02 = 2ms delay, 0x00 = reserved; 
              fadeEnabled = b1;
              fadeDelay = b2;
              blinkEnabled = 0;
              break;
          case 0xf0: // Settings
              maxBrightness = b1;
              //LEDS.setBrightness(maxBrightness);
              
              break;
        }

      Serial.println("");
    }


  for(int i = 0; i < LED_COUNT; i++) {
      if(blinkEnabled){
        LEDS.setBrightness(maxBrightness);
        leds[i] = blinkState ? solidColor : blinkColor;
      }
      else if(fadeEnabled){
        leds[i] = solidColor;
        LEDS.setBrightness(fadeValue);
      }
      else{
        LEDS.setBrightness(maxBrightness);
        leds[i] = solidColor;
      }
      
  }
  
  FastLED.show(); 

}
