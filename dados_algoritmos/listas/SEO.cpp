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
			} else if(inicio == fim || auxiliar->nome > fim->nome || auxiliar->nome < fim->nome){
				if(auxiliar->nome < inicio->nome){
					inicio = auxiliar;
					auxiliar->proximo = fim;
				} else {
					fim = auxiliar;
					inicio->proximo = fim;	
				}
			} else {
				//sor
				/*
				ELEMENTO *ant = NULL;
				ELEMENTO *atu = inicio;
				
				//faz um loop ate encontrar o espaco onde sera inserido o auxiliar
				while(auxiliar->nome > atu->nome){
					ant = atu;
					atu = atu->proximo;
				}
				
				ant->proximo = auxiliar;
				auxiliar->proximo = atu;
				*/			
					
				//eu
				
				/*
				anterior = inicio;
				while(anterior->proximo != NULL){
					if(anterior->proximo->nome > auxiliar->nome){
						
						auxiliar->proximo = anterior->proximo;
						anterior->proximo = auxiliar;
						
					} else {
						anterior = anterior->proximo;					
					}
				}
				*/
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
			if(fim == inicio){
				cout << auxiliar->nome << endl;
				
			} else {
				while(auxiliar != NULL) {
					cout << auxiliar->nome << endl;
					auxiliar = auxiliar->proximo;
				}
			}
			system("pause");
		}
	}
}