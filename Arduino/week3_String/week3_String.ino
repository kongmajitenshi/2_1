void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  Serial.println();

  String longStr = "9:08:35,27.6";

  int p1 = longStr.indexOf(":");
  int p2 = longStr.indexOf(":", p1+1);
  int p3 = longStr.indexOf(",");

  String hStr = longStr.substring(0, p1);
  String mStr = longStr.substring(p1+1, p2);
  String sStr = longStr.substring(p2+1, p3);
  String tStr = longStr.substring(p3+1);

  int h = hStr.toInt();
  int m = mStr.toInt();
  int s = sStr.toInt();
  float t = tStr.toFloat();

  Serial.println(h);
  Serial.println(m);
  Serial.println(s);
  Serial.println(t);
}

void loop() {
  // put your main code here, to run repeatedly:

}

