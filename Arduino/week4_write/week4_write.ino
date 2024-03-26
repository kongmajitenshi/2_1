void setup() {
  Serial.begin(9600);
  Serial.println();

  Serial.println("----문자----");
  char c = 'a';
  Serial.println(c);
  Serial.write(c);

  Serial.println("\n----문자열----");
  char s[] = "abc";
  Serial.println(s);
  Serial.write(s);

  Serial.println("\n----byte----");
  byte b = 97;
  Serial.println(b);
  Serial.write(b);
  Serial.println();

}

void loop() {
  // put your main code here, to run repeatedly:

}
