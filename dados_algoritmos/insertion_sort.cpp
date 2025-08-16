//insertion sort

#include <iostream>
#include <string>
#include <vector>

using namespace std; // Como C++ e POO, existe o conjunto de namespace (que e uma 'biblioteca'), o std e uma biblioteca que esta sendo usada aqui, 
//por isso esta sendo especificado, para que caso a mesma palavra reservada esteja na bibiloteca ou no proprio compilador, ele sabe que e da biblioteca
//dizendo: se esta sendo usada uma palavra reservada, use a do std e nao a de outro lugar;


main(){
	// espeficar que e o do std
	//std::cout << "Ola mundo" << endl;
	
	// c out
	cout << "asdkh";
	
	vector<string> nomes; // como foi feito com o vector, pode ser operado como uma array, por exemplo usando o .size() da de achar o tamanho da array
	int x, y;
	string temp;
	
	nomes.push_back("Catatau");
	nomes.push_back("Ze colmeia");
	nomes.push_back("Xunda");
	nomes.push_back("Gonzo");
	nomes.push_back("Tiao Gaviao");
	nomes.push_back("Mutley");
	nomes.push_back("Pombo Dudley");
	nomes.push_back("Capitao Caverna");
	
	
	//imprime na ordem normal
	cout << "---=== DADOS ORIGINAIS ===---" << endl;
	for(x = 0; x < nomes.size(); x++){
		cout << nomes[x] << endl;
	}
	
	cout << endl;
	
	// ordena os dados com Inserction Sort
	
	for(x = 1; x < nomes.size(); x++){
		temp = nomes[x];
		y = x-1;
		while(y >= 0 && nomes[y] > temp){
			nomes[y+1] = nomes[y];
			y--;
		}
		nomes[y+1] = temp;
	}
	 /*
	 Como funciona:
	 	Pelo tamanho da array, ele:
	 	
	 		1. Comeca a contar do 1, de 1 em 1 ate o tamanho da array 
	 		2. A posicao anterior ao x vai ser chamada de y (que sera 0, ja que comeca no 1);
	 		3. A variavel temp vai ser igual a coordenada x da array
	 		Dentro do while
			1.Enquanto o y for maior ou igual a 0 E a posicao y da array for maior que a temp ele vai:
			2.A posicao depois do vai receber a y
			3.O y vai descer em 1
			Fora do while
			1.A array de nomes na posicao a frente do y vai receber a temp (x)
			
			Ou seja, no primeiro caso:
			
			Nomes:
			0. Catatau
			1. Ze Colmeia
			2. Xunda
			
			// x neste caso eh igual a 1, ele vai fazer a logica de percorrer a array comecando em 1 
			for(x = 1; x < nomes.size(); x++){
				
				//temp vai ser igual a "Ze Colmeia"
				temp = nomes[x];
			
				//y vai ser igual a 0
				y = x-1;
			
				// enquanto y for >= 0 E nomes na posicao y for maior que temp (em conta de strings)
				//		true		false (ja que z nao eh maior que c)
				while(y >= 0 && nomes[y] > temp){
					nomes[y+1] = nomes[y];
					y--;
				}
				// O nome na posicao 1 vai ser igual ao temp (Ze Colmeia)
				nomes[y+1] = temp;
			}
			//A ordem ficou depois dessa passada
			//1.Catatau
			//2.Ze Colmeia
			//3.Xunda
			
			//Perceba que a ordem nao mudou ja que a condicao nao aconteceu
			
			//Na segunda passada do codigo
			//Nomes:
			//0. Catatau
			//1. Ze Colmeia
			//2. Xunda
			
			// x neste caso eh igual a 2
			for(x = 1; x < nomes.size(); x++){
				
				//temp vai ser igual a "Xunda"
				temp = nomes[x];
			
				//y vai ser igual a 1
				y = x-1;
			
				// enquanto y for >= 0 E nomes na posicao y for maior que temp (em conta de strings)
				
				//		true		true (ja que x eh maior que z)
				while(y >= 0 && nomes[y] > temp){
					// aqui ele vai fazer a array de nomes na posicao 2 vai ser igual a nomes na posicao 1
					nomes[y+1] = nomes[y];
					// y diminui em 1 para fazer a logica novamente depois na proxima passada
					y--; // y = 0
				}
			
				// o nome depois do y (posicao 1) vai ser igual ao temp, que eh o Xunda
				nomes[y+1] = temp;
			}
		
			//Depois dessa passada ficou:
			//Catatau
			//Xunda
			//Ze Colmeia
			
	 	
	 */
	 
	 
	cout << "---=== DADOS ORDENADOS ===---" << endl;
	for(x = 0; x < nomes.size(); x++){
		cout << nomes[x] << endl;
	}
	
	cout << endl;
}

