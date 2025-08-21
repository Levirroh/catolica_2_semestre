// C++ code
//

#define vermelho 3
#define azul 2
#define verde 1
#define tempo_abertura 10000

#define vermelho_1 10
#define azul_1 9
#define verde_1 8

#define buzz 0
void setup()
{
  pinMode(vermelho, OUTPUT);
  pinMode(azul, OUTPUT);
  pinMode(verde, OUTPUT);
  pinMode(buzz, OUTPUT);

}

void loop()
{
	analogWrite(vermelho, 0);
  	analogWrite(azul, 0);
  	analogWrite(verde, 255);
  	delay(1000);
	analogWrite(vermelho, 255);
  	analogWrite(azul, 0);
  	analogWrite(verde, 255);
  	delay(1000);
  	analogWrite(vermelho, 255);
  	analogWrite(azul, 0);
  	analogWrite(verde, 0);
  	analogWrite(vermelho, 255);
  	analogWrite(azul, 0);
  	analogWrite(verde, 0);
  	analogWrite(vermelho_1, 255);
  	analogWrite(azul_1, 0);
  	analogWrite(verde_1, 0);
    tone(buzz, 522, 200);
  	delay(200);
  	analogWrite(vermelho_1, 0);
  	analogWrite(azul_1, 255);
  	analogWrite(verde_1, 0);
    tone(buzz, 1044, 200);
    delay(200);
  	analogWrite(vermelho_1, 0);
  	analogWrite(azul_1, 0);
  	analogWrite(verde_1, 255);
	tone(buzz, 1044, 200);
	delay(400);
   	analogWrite(vermelho_1, 255);
  	analogWrite(azul_1, 0);
  	analogWrite(verde_1, 0); 
  	tone(buzz, 522, 200);
	delay(400);
  	analogWrite(vermelho_1, 0);
  	analogWrite(azul_1, 255);
  	analogWrite(verde_1, 0);
    tone(buzz, 1044, 200);
	delay(400);
    analogWrite(vermelho_1, 0);
  	analogWrite(azul_1, 0);
  	analogWrite(verde_1, 255);
  	tone(buzz, 1044, 200);
	delay(400);
    tone(buzz, 522, 200);
  	analogWrite(vermelho_1, 255);
  	analogWrite(azul_1, 0);
  	analogWrite(verde_1, 0);
	delay(400);
    tone(buzz, 1044, 200);
  	analogWrite(vermelho_1, 0);
  	analogWrite(azul_1, 255);
  	analogWrite(verde_1, 0);
	delay(400);
    tone(buzz, 1044, 200);
	analogWrite(vermelho_1, 0);
  	analogWrite(azul_1, 0);
  	analogWrite(verde_1, 255);
  	delay(400);
    tone(buzz, 2088, 200);
   	analogWrite(verde_1, 0);
    analogWrite(azul_1, 0);
    analogWrite(vermelho_1, 0); // reiniciando todos eles

  	analogWrite(vermelho_1, 255);
 	delay(400);
    tone(buzz, 300, 200);
    analogWrite(vermelho_1, 0);
   	delay(200);
  	analogWrite(vermelho_1, 255);
    delay(600);
    tone(buzz, 300, 200);
 	analogWrite(vermelho_1, 0);
   	delay(200);
  	analogWrite(vermelho_1, 255);  
  	delay(600);
    tone(buzz, 300, 500);
     analogWrite(vermelho_1, 0);

    delay(600);

}