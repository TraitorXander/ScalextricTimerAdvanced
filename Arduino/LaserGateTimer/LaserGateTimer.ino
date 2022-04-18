int ptPin = 1;

const int triggerOffset = 25;
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

  for(int i = 0; i < numValues; i++){
    values[i] = 0;
  }
}

void loop() {
  total = total - values[valueIndex];
  values[valueIndex] = analogRead(ptPin);  
  total = total + values[valueIndex];
  average = total / numValues;

  Serial.println("SMES 0 " + String(values[valueIndex]) + " " + String(average) + "\n");

  delay(100);

  if(values[valueIndex] < (average - triggerOffset)){
    Serial.println("SMES 1 " + String(TriggerTime()) + "\n");
    delay(100);
  }

  valueIndex++;
  if(valueIndex >= 10){
    valueIndex = 0;
  }
  
  delay(100);
}

float TriggerTime(){
  endTime = millis();
  elapsedTime = endTime - startTime;
  startTime = millis();
  return elapsedTime;
}
