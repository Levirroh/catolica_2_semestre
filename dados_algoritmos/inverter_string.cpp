#include <iostream>

using namespace std;

void inverter_string(char str[], int inicio, int fim){
	if(inicio >= fim) return;

	swap(str[inicio], str[fim]);
	
	inverter_string(str, inicio+1, fim-1);
}

int main(){
	char str[100];
	
	cout << "Digite uma string : ";
	cin >> str;
	
	inverter_string(str, 0, strlen(str)-1);
	
	cout << "String invertida : " << str << endl;
	
	system("pause");
}