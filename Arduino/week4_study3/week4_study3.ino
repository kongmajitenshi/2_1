#define LED_PIN LED_BUILTIN
String reading;


void setup() {
  Serial.begin(9600);
  Serial.println("LED Control Input");
  pinMode(LED_PIN, OUTPUT);
}

void loop() {

    reading = Serial.readString();

    if(reading == "on") {

      digitalWrite(LED_PIN, HIGH);
      Serial.println("LED ON");

    }else if(reading == "off") {

      digitalWrite(LED_PIN, LOW);
      Serial.println("LED OFF");

    }

}

