#define LED_PIN LED_BUILTIN
char reading;
int time;
String PrintResult;

void setup() {
  Serial.begin(9600);
  Serial.println("LED ON: o 숫자, LED OFF: x 숫자");
  pinMode(LED_PIN, OUTPUT);
}

void loop() {
  reading = Serial.read();

  if(reading == 'o') {
    time = Serial.parseInt();
    PrintResult = "LED ON " + String(time) + "ms";
    Serial.println(PrintResult);
    digitalWrite(LED_PIN, HIGH);
    delay(time);

  }else if(reading == 'x') {
    time = Serial.parseInt();
    PrintResult = "LED ON " + String(time) + "ms";
    Serial.println(PrintResult);
    digitalWrite(LED_PIN, LOW);
    delay(time);
    }

  digitalWrite(LED_PIN, HIGH);
  delay(1000);
  digitalWrite(LED_PIN, LOW);
  delay(1000);
}

