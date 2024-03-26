void setup() {
  Serial.begin(9600);
  Serial.println();

  char c = 'a';
  Serial.println(c); // 문자
  Serial.println(c, DEC); // 10진수, 97 
  Serial.println(c, BIN); // 2진수
  Serial.println(c, HEX); // 16진수

  float f = 35.657;
  Serial.println(f); // 두자리
  Serial.println(f, 1); // 소숫점 한자리까지
  Serial.println(f, 0); // 0자리
}

void loop() {
  // put your main code here, to run repeatedly:

}
