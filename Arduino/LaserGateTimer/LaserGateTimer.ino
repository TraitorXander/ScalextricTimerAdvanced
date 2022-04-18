int ptPin = 1;

const int triggerOffset = 25;
const int triggerMin = 250;
const int numValues = 10;

int values[numValues];
int valueIndex = 0;
int total = 0;
int average = 0;

unsigned long startTime = 0;
unsigned long endTime = 0;
unsigned long elapsedTime = 0;

void setup() {
  Serial.begin(19200);

  Serial.println("Starting...");

  for(int i = 0; i < numValues; i++){
    values[i] = 0;
  }

  startTime = millis();
}

void loop() {
  // Subtract last value in array
  total = total - values[valueIndex];
  // Get latest value from phototransistor
  values[valueIndex] = analogRead(ptPin); 
  // Add new value to total 
  total = total + values[valueIndex];
  // Average the total
  average = total / numValues;

  // If the light level drops, record the time
  if((values[valueIndex] < (average - triggerOffset)) && (millis() - startTime > triggerMin)){
    RestartTimer();
  }

  // Send current light and average light value to serial
  Serial.println("TIME " + String(values[valueIndex]) + " " + String(average) + " " + String(millis() - startTime) + " " + String(elapsedTime));

  valueIndex++;
  if(valueIndex >= 10){
    valueIndex = 0;
  }
  
  delay(50);
}

void RestartTimer(){
  endTime = millis();
  elapsedTime = endTime - startTime;
  startTime = millis();
}
