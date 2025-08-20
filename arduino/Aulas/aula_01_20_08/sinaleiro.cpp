void setup()
{
  pinMode(12, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(1, OUTPUT);

}

void loop()
{
  	int vermelho = 12;
	int amarelo = 7;
  	int verde = 1;
   	
  	digitalWrite(vermelho, HIGH);
  	delay(1000); 
  
  	digitalWrite(vermelho, LOW);
    digitalWrite(amarelo, HIGH);
    delay(1000); 
  
   	digitalWrite(amarelo, LOW);
    digitalWrite(verde, HIGH);
    delay(1000); 
  
    digitalWrite(verde, LOW);
}