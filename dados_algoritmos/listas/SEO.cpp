#include <iostream>
#include <string>

using namespace std;

struct ELEMENTO
{
	string nome;
	ELEMENTO *proximo;
};

main(){
	ELEMENTO *inicio, *fim, *anterior, *auxiliar;
	inicio = NULL;
	fim = NULL;
	auxiliar = NULL;
	
	
	int op;
	string nome;
	string onde;

	while (true)
	{
		system("cls");
		cout << "---=== Lista Nao Ordenada ===---" << endl;
		cout << "1 - Adicionar elemento" << endl;
		cout << "2 - Apagar elemento" << endl;
		cout << "3 - Mostrar lista" << endl;
		cout << "0 - Sair" << endl;
		cout << "Opcao desejada : ";
		cin >> op;

		if (op == 0) break;
		
		if(op == 1){
			cout << endl << "--== Adicionar ==--" << endl;
			cout << "Informe o nome : ";
			cin >> nome;
			
			auxiliar = new ELEMENTO();
			auxiliar->nome = nome;
			
			if(inicio == NULL){
				
				inicio = auxiliar;
				fim = inicio;
				auxiliar->proximo = inicio;
				
			} else if(inicio == fim){
				if(auxiliar->nome < inicio->nome){
					auxiliar->proximo = inicio;
					inicio = auxiliar;
				} else {
					fim = auxiliar;
					inicio->proximo = fim;	
				}
			} else {
				anterior = inicio;
				while(anterior->proximo != NULL){
					if()
				}
			}
			
//			
//			if(onde == "I") {
//				if(inicio == NULL) {
//					inicio = auxiliar;
//					fim = inicio;
//				} else {
//					auxiliar->proximo = inicio;
//					inicio = auxiliar;
//				}
//			} else 
//			{
//				if(fim == NULL) {
//					inicio = auxiliar;
//					fim = inicio;
//				} else {
//					
//				}
//			}
		}
		
		
	}


}