#include <iostream>
#include <string>

using namespace std;

struct ELEMENTO
{
	string nome;
	ELEMENTO *proximo;
};


main()
{

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

		if (op == 1)
		{
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
				} else {
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
	


		if (op == 2)
		{
			cout << endl << "--== Excluir ==--" << endl;
			cout << "Onde excluir (I/F) : " << endl;
			cin >> onde;
	
			if(onde == "I")
			{
				auxiliar = inicio;
				inicio = inicio->proximo;
	
				delete auxiliar;
			}
	
			if (onde == "F")
			{
				auxiliar = inicio;
				while(auxiliar->proximo->proximo != NULL) {
					auxiliar = auxiliar->proximo;
				}
				delete fim;
				fim = auxiliar;
				fim->proximo = NULL;
			}
		}
	
	
	
		if (op == 3)
		{
			cout << endl << "--== Listagem da lista ==--" << endl;
			auxiliar = inicio;
			while(auxiliar != NULL) {
				cout << auxiliar->nome << endl;
				auxiliar = auxiliar->proximo;
			}
			system("pause");
		}
	}
}