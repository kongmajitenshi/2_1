int cnt;
float temp;
String name;  

void setup() {
  Serial.begin(9600);
  Serial.println();
}

void loop() {
  while(Serial.available()) {
    char reading = Serial.read();
    if(reading == 'c') {
      cnt = Serial.parseInt();
      Serial.print("cnt = ");
      Serial.println(cnt);
    }else if(reading == 't') {
      temp = Serial.parseFloat();
      Serial.print("temp = ");
      Serial.println(temp);
    }else if(reading == 'n') {
      name = Serial.readStringUntil(';');
      Serial.print("name = ");
      Serial.println(name.c_str());
    }
  }
}
