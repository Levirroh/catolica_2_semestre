#include <iostream>
#include <string>

using namespace std;

struct ELEMENTO
{
	string nome;
	ELEMENTO *proximo;
	ELEMENTO *anterior;
};

main(){
	ELEMENTO *inicio, *fim, *auxiliar;
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
			cout << "Onde incluir (I/F) : " << endl;
			cin >> onde;
			
			auxiliar = new ELEMENTO();
			auxiliar->nome = nome;
			
			
			if(onde == "I") {
				if(inicio == NULL) {
					inicio = auxiliar;
					fim = inicio;
					fim->anterior = inicio;
				} else {
					inicio->anterior = auxiliar;
					auxiliar->proximo = inicio;
					inicio = auxiliar;
				}
			} else 
			{
				if(fim == NULL) {
					inicio = auxiliar;
					fim = inicio;
				} else {
					fim->proximo = auxiliar;
					fim = auxiliar;
				}
			}
		}
		
		
	}


}