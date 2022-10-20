#include<iostream>
#include<string>
using namespace std;
int main()
{
	int size;
	string str1[50], str2[50], str3[50];
	cout << "ENTER NUMBER OF NAMES ? :";
	cin >> size;
	for (int i = 0; i < size; i++)
	{
		cout << "ENTER NAME :";
		cin >> str1[i];
		cin >> str2[i];
		cin >> str3[i];
		cout << endl;
	}
	cout << "TELEPHONE DIRECTORY FORMAT :\n" << endl;
	for (int i = 0; i < size; i++)
	{
		cout << str3[i] << "," << str1[i] << " " << str2[i][0] << "." << endl;
	}
	system("pause>0");
}
