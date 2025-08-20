//ligando uma luz de cada vez e apagando junto
void setup()
{
  pinMode(12, OUTPUT);
  pinMode(7, OUTPUT);
}

void loop()
{
  digitalWrite(12, HIGH);
  delay(1000); 
  digitalWrite(7, HIGH);
  delay(1000);   
  digitalWrite(12, LOW);
  digitalWrite(7, LOW);
  delay(1000); 
}