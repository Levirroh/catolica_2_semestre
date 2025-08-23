//selection sort

#include <iostream>
#include <string>
#include <vector>


using namespace std;



main(){
	// espeficar que e o do std
	//std::cout << "Ola mundo" << endl;
	
	// c out
	cout << "asdkh";
	
	vector<string> nomes; // como foi feito com o vector, pode ser operado como uma array, por exemplo usando o .size() da de achar o tamanho da array
	int x, y, posicao;
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
	
	// ordena os dados com Selection Sort
	
	for(x = 1; x < nomes.size()-1; x++){
		posicao = x;
        for(y = x+1; y< nomes.size();y++){
            if(nomes[y]< nomes[posicao]){
                posicao = y;
            }
        }
        if (x != posicao){
            temp = nomes[x];
            nomes[x] = nomes[posicao];
            nomes[posicao] = temp;
        }
	}
	 
	cout << "---=== DADOS ORDENADOS ===---" << endl;
	for(x = 0; x < nomes.size(); x++){
		cout << nomes[x] << endl;
	}
	
	cout << endl;
}

