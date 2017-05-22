void setup() {
  // put your setup code here, to run once:
pinMode(8,OUTPUT);

Serial.begin(9600);
}

void loop() {
  
  while(Serial.available())   //Eğer seri haberleşme açık olursa alttaki komutlar işleyecek.
  {
   
    int a=Serial.read();    //Seri haberleşme ile okunan verimize a integer değerini verdik.
  if(a=='1')
 { digitalWrite(8, HIGH);}  // a, 1 olursa yanacak.
  
  else if (a == '0')          // a, 0 olursa sönecek.
  {digitalWrite(8, LOW);}
  }
}
