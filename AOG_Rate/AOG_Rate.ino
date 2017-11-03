  #define LED_PIN 13   
  #define   DIR_PIN    12  //PB4
  #define   PWM_PIN    11  //PB3  
  #define WORKSW_PIN 4  //PD4
  
  #define RELAY1_PIN 5  //PD5
  #define RELAY2_PIN 6  //PD6
  #define RELAY3_PIN 7  //PD7
  #define RELAY4_PIN 8  //PB0
  #define RELAY5_PIN 9  //PB1
   
  //loop time variables in microseconds
  const unsigned int LOOP_TIME = 50; //20hz 
  unsigned int lastTime = LOOP_TIME;
  unsigned int currentTime = LOOP_TIME;
  unsigned int dT = 50000;
  unsigned int count = 0;
  unsigned int watchdogTimer = 0;

  //program flow
  bool isDataFound = false, isSettingFound = false;
  int header = 0, tempHeader = 0, temp;

  byte relay = 0;
  float rateSetPoint = 0, groundSpeed = 0, accumulatedVolume = 99; //speed from AgOpenGPS is multiplied by 4
  unsigned int  pulseCount = 0;


void setup()
{

  pinMode(LED_PIN, OUTPUT); //configure LED for output
  pinMode(RELAY1_PIN, OUTPUT); //configure RELAY1 for output //Pin 5
  pinMode(RELAY2_PIN, OUTPUT); //configure RELAY2 for output //Pin 6
  pinMode(RELAY3_PIN, OUTPUT); //configure RELAY3 for output //Pin 7
  pinMode(RELAY4_PIN, OUTPUT); //configure RELAY4 for output //Pin 8
  pinMode(RELAY5_PIN, OUTPUT); //configure RELAY5 for output //Pin 9
  //pinMode(RELAY6_PIN, OUTPUT); //configure RELAY6 for output //Pin 10
  //pinMode(RELAY7_PIN, OUTPUT); //configure RELAY7 for output //Pin A4
  //pinMode(RELAY8_PIN, OUTPUT); //configure RELAY8 for output //Pin A5
  
  //set up communication  
  Serial.begin(38400); 
    
  //PWM rate settings Adjust to desired PWM Rate
  //TCCR1B = TCCR1B & B11111000 | B00000010;    // set timer 1 divisor to     8 for PWM frequency of  3921.16 Hz
  TCCR1B = TCCR1B & B11111000 | B00000011;    // set timer 1 divisor to    64 for PWM frequency of   490.20 Hz (The DEFAULT)
} 

void loop()
{ 
  currentTime = millis();
  unsigned int time = currentTime;

  if (currentTime - lastTime >= LOOP_TIME)
  {   
    dT = currentTime - lastTime;
    lastTime = currentTime;

    SetRelays(); //turn on off sections
       
 
    if (count++ > 20)
    {
      //Send to agopenGPS, once per second
      Serial.print(dT); 
      Serial.print(",");
      Serial.print(groundSpeed); 
      Serial.print(","); 
      Serial.print(rateSetPoint); //steering switch status
      Serial.print(","); 
      Serial.println(accumulatedVolume); //steering switch status
      
      Serial.flush();   // flush out buffer
      count = 0;
    }
    
    if (watchdogTimer++ > 10)
    {
      //here goes the code to shut everything down, AgOpenGPS went asleep, lost communication
      relay = 0;
      SetRelays();        
    }
      
  } //end of timed loop
  
    //****************************************************************************************
    //This runs continuously, outside of the timed loop, keeps checking UART for new data  
    // header high/low, relay byte, speed byte, rateSetPoint hi/lo
    if (Serial.available() > 0 && !isDataFound && !isSettingFound) //find the header, 127H + 250L = 32762
    {
      int temp = Serial.read();
      header = tempHeader << 8 | temp;               //high,low bytes to make int
      tempHeader = temp;                             //save for next time
      if (header == 32762) isDataFound = true;     //Do we have a match? 
      if (header == 32760) isSettingFound = true;     //Do we have a match? 
    }
    
    //Data Header has been found, so the next 4 bytes are the data
    if (Serial.available()> 3 && isDataFound)
    {  
      isDataFound = false;    
      relay = Serial.read();   // read relay control from AgOpenGPS     
      groundSpeed = Serial.read()>>2;  //actual speed times 4, single byte
  
      // sent as 10 times value in liters per minute, LPM * 0.264172 to get US GPM
      rateSetPoint = ((float)(Serial.read() << 8 | Serial.read()))* 0.1;   //high,low bytes

      //reset watchdog as we just heard from AgOpenGPS
      watchdogTimer = 0;
    }  
  
    //Settings Header has been found, 8 bytes are the settings
    if (Serial.available() > 7 && isSettingFound)
    {        
      isSettingFound = false;  //reset the flag
  
      //change the factors as required for your own PID values
      //steerSensorCounts = Serial.read()*0.1; //sent as 10 times the setting displayed in AOG
    }
}

//ISR
void pulseCounter()
{
  // Increment the pulse counter
  pulseCount++;
}

