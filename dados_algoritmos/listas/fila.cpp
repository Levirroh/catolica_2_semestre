#include <iostream>
#include <string>

using namespace std;

struct ELEMENTO{
	string nome;
	ELEMENTO *proximo;	
};

main(){
	ELEMENTO, *inicio, *fim, *auxiliar;
	inicio = NULL;
	fim = NULL;
	auxiliar = NULL;
	
	int op;
	string nome;
	
	while(true){
		system("cls")
		cout << "---=== Fila ===---" << endl;
		ciyt << "1 - Adicionar elemento" << endl;
		cout << "2 - Apagar elemento" << endl;
		cout << "3 - Mostrar fila" << endl;
		cout << "0 - Sair" << endl;
		
		cout << "Opcao desejada :";
		cin >> op;
		
		if (op == 0) break;
		
		if (op == 1){
			cout << endl << "--== Adicionar ==--" << endl;
			
			cout << "Informe o nome : ";
			cin >> nome;
		
			// criar novo elemento
			
			auxiliar = new ELEMENTO();
			
			auxiliar->nome = nome;
			auxiliar->proximo = NULL;
			
			
			//verifica se a fila existe
			
			if(inicio == NULL){
				//o novo elemento sera o primeiro elemento da fila.
				inicio = auxiliar;
				fim = auxiliar;
			} else {
				//se ja existe o elemento sera adicionar no fim da fila.
				fim->proximo = auxiliar;
				fim->auxiliar;
			}
		}
	}
}