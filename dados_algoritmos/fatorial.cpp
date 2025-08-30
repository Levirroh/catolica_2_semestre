#include <iostream>

using namespace std;

int main()
{

	int numero, i, total;
	
	system("cls");
	cout << "Numero para fatorar: ";
	cin >> numero;
	
	
	
	
	
	/*
	total = 1;	
	for(i = numero; i > 1; i--)
	{	
		total *= i;
	}
	
	total = 1;
	for(i = 1; i <= numero; i++)
	{	
		total *= i;
	}
	*/
	total = 0;
	for(i = numero; i > 1; i--)
	{	
		total += numero * i;
	}
	
	cout << "O fatorial de " << numero << " eh igual a " << total <<  endl;
	
	system("pause");
	
	
}