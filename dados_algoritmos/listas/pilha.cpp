#include <iostream>
#include <string>

using namespace std;

struct ELEMENTO{
	string nome;
	ELEMENTO *proximo;
};

main()
{
	ELEMENTO *topo, *auxiliar;
	topo = NULL;
	auxiliar = NULL;
	
	string nome;
	int op;
	
	while (true){
		system("cls");
		cout << "---=== Menu ===---" << endl;
		cout << "1 - Incluir elemento" << endl;
		cout << "2 - Excluir elemento" << endl;
		cout << "3 - Mostrar pilha" << endl;
		cout << "0 - Sair" << endl;
		cout << "Opcao desejada: ";
		cin >> op;		
		
		if(op == 0){
			break;
		}
		
		if(op == 1){
			cout << endl << "---=== Inclusao de elemento ===---" << endl;
			cout << "Nome para incluir : ";
			cin >> nome;
			
			//cria o novo elemento;
			auxiliar = new ELEMENTO();
			auxiliar->nome = nome;
			auxiliar->proximo = NULL;
			
			//if(topo != NULL) auxiliar->proximo = topo
			//topo = auxiliar;
			
			
			if(topo == NULL){
				topo = auxiliar;
			} else {
				auxiliar->proximo = topo;
				topo = auxiliar;
			}
		}
		
		if(op == 2){
			if(topo != NULL){
				auxiliar = topo;
				topo = topo->proximo;
				delete auxiliar;
			}
		}
		
		if(op == 3){
			cout << endl << "---=== Elementos da pilha ===---" << endl;
			
			auxiliar = topo;
			
			while (auxiliar != NULL){
				cout << auxiliar->nome << endl;
				auxiliar = auxiliar->proximo;
			}
			system("pause");
		}
	}
}