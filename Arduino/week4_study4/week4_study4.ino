#define LED_PIN LED_BUILTIN
char reading;
int time;


void setup() {
  Serial.begin(9600);
  Serial.println("LED Control Input");
  pinMode(LED_PIN, OUTPUT);
}

void loop() {
  reading = Serial.read();

  if(reading == 'o') {
    time = Serial.parseInt();
    Serial.print("LED ON ");
    Serial.print(time);
    Serial.print("ms\n");
    digitalWrite(LED_PIN, HIGH);
    delay(time);
    digitalWrite(LED_PIN, LOW);
  }else if(reading == 'x') {
    time = Serial.parseInt();
    Serial.print("LED OFF ");
    Serial.print(time);
    Serial.print("ms\n");
    digitalWrite(LED_PIN, LOW);
    delay(time);
    digitalWrite(LED_PIN, HIGH);
    }

  digitalWrite(LED_PIN, HIGH);
  delay(1000);
  digitalWrite(LED_PIN, LOW);
  delay(1000);
}

