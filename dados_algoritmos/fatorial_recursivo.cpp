#include <iostream>

using namespace std;

int fatorial(int n)
{
	if(n == 0 || n== 1) return 1;
	return n * fatorial(n-1);
}

int main(){
	int num, resultado;
	
	cout << "Numero para fatorar : ";
	cin >> num;
	
	resultado = fatorial(num);
	
	cout << "O fatorial de " << num << " eh: " << resultado << endl;
	system("pause");
	
}