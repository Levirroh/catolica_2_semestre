#include <iostream>

using namespace std;


//1 1 2 3 5 8 13 etc

int fibonacci(int n){
	
	if(n <= 1) return n; // créditos ao VH, pensou em tudo
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