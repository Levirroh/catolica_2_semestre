#include <iostream>

using namespace std;


//1 1 2 3 5 8 13 etc

int fibonacci(int n){
	
	//tarefa: fazer 3 testes de mesa com valores diferentes (ex: 1, 3 , 5)
	if(n <= 1) return n; 	
	return fibonacci(n - 1) + fibonacci(n - 2);
}

int main(){
	
	int num, result;
	
	
	cout << "Qual elemento da sequencia fibonacci voce deseja saber? ";
	cin >> num;
	cout << "|";
	
	result = fibonacci(num);
	cout << result;
}