#include <iostream>
#include <string>

using namespace std;

main(){
	
	//--- ENDERECO DE MEMÓRIA
	int idade;
	idade = 18;
	
	cout << "Valor de idade     :" << idade  << endl;
	cout << "Enredeco de idade  :" << &idade << endl; // isso mostra o endereço na própria memória
	
	int *ponteiro; // isso não é uma variável, ponteiros não podem armazenar valor, somente endereços de memória.
	
	ponteiro = &idade; // &variavel significa o endereço dela na memória
	
	cout << "valor de ponteiro  :" << ponteiro << endl; // isso mostra o endereço na própria memória
	cout << "valor no endereco do ponteiro  :" << *ponteiro << endl; 
	cout << "endereco do ponteiro  :" << &ponteiro << endl; 
	
}