#include "BNO055_AOG.h"
#include <Wire.h>

#define A 0X28  //I2C address selection pin LOW
#define B 0x29  //                          HIGH

BNO055 IMU(A);

float head = 0;
float rads = 0;
float fAngVel;

//loop time variables in microseconds
const unsigned int LOOP_TIME = 100; //10hz 
unsigned int lastTime = LOOP_TIME;
unsigned int currentTime = LOOP_TIME;
unsigned int dT = 50000;
unsigned int count = 0;
int inByte = 0; // incoming serial byte

//Kalman variables
float rollK = 0;
float Pc = 0.0;
float G = 0.0;
float P = 1.0;
float Xp = 0.0;
float Zp = 0.0;
float Xe = 0;
const float varRoll = 0.5; // variance
const float varProcess = 0.2;

//setup
void setup() {
  
  Wire.begin();
  Serial.begin(38400);
  IMU.init();

  // Restore calibration data from zeroing
  bno055_offsets_t calibrationData;
  
  calibrationData.accel_offset_x = 65506;
  calibrationData.accel_offset_y = 65438;
  calibrationData.accel_offset_z = 5;
  calibrationData.gyro_offset_x = 65534;
  calibrationData.gyro_offset_y = 65533;
  calibrationData.gyro_offset_z = 1;
  calibrationData.mag_offset_x = 65350;
  calibrationData.mag_offset_y = 19;
  calibrationData.mag_offset_z = 27;
  calibrationData.accel_radius = 1000;
  calibrationData.mag_radius = 968;
  
  IMU.setSensorOffsets(calibrationData);

  //use external 32K crystal
  IMU.setExtCrystalUse(true);    
  
  //Pins 8 thru 12 as output, 8 is LSB
  DDRB = B00011111;

  //PORTB turn off 8 thru 12
  PORTB = B00000000;

  //Pin D2 as input, pulled up.
  pinMode(2, INPUT_PULLUP);  
}

void loop() 
{  
  currentTime = millis();
  unsigned int time = currentTime;

  if (currentTime - lastTime >= LOOP_TIME)
  {   
    dT = currentTime - lastTime;
    lastTime = currentTime;

    IMU.readIMU();

    // kalman SINGLE VARIABLE process
    rollK = IMU.euler.roll;    
    Pc = P + varProcess;
    G = Pc / (Pc + varRoll);    // kalman gain
    P = (1 - G) * Pc;
    Xp = Xe;
    Zp = Xp;
    Xe = G * (rollK - Zp) + Xp;

    Serial.print(IMU.euler.head);
    Serial.print(","); 
    Serial.println((int)Xe);  
  
    Serial.flush();           // flush out buffer
  }   
}
