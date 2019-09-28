#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include<Windows.h>

std::vector<std::string> getWords(std::string fileName);
bool isAnagram(std::string word, std::string letters);
std::string cp1251_to_utf8(const char *str);

void main() {
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	std::string letters;
	std::cout << "¬ведите буквы дл€ поиска слов =>> ____\b\b\b\b";
	std::cin >> letters;
	letters = cp1251_to_utf8(letters.c_str());

	SetConsoleCP(CP_UTF8);
	SetConsoleOutputCP(CP_UTF8);
	std::vector<std::string> words = getWords("th_ru_RU_v2.dat");

	for (std::string word : words)
	{
		if (isAnagram(word, letters)) std::cout << word << std::endl;
	}

	system("pause");
}

bool isAnagram(std::string word, std::string letters) 
{
	if (!word.size()) return true;

	char c = word[0];

	//std::cout << "word:" << word << " " << "letters:" << letters << std::endl;

	for (size_t i = 0; i < letters.size(); i++)
	{
		if (c == letters[i])
		{
			letters.erase(letters.begin() + i);
			word.erase(word.begin());

			return isAnagram(word, letters);
		}
	}

	return false;
}

std::vector<std::string> getWords(std::string fileName) 
{
	std::vector<std::string> result;
	std::ifstream in(fileName);
	std::string temp;

	while (getline(in, temp))
	{
		if (temp.size() && temp[0] <= '€')
		{
			if (temp.find('|') > 0)
			{
				temp = temp.substr(0, temp.find('|'));
			}

			result.push_back(temp);
		}
	}

	return result;
}

std::string cp1251_to_utf8(const char *str)
{
	std::string res;
	int result_u, result_c;
	result_u = MultiByteToWideChar(1251, 0, str, -1, 0, 0);
	if (!result_u) { return 0; }
	wchar_t *ures = new wchar_t[result_u];
	if (!MultiByteToWideChar(1251, 0, str, -1, ures, result_u)) {
		delete[] ures;
		return 0;
	}
	result_c = WideCharToMultiByte(65001, 0, ures, -1, 0, 0, 0, 0);
	if (!result_c) {
		delete[] ures;
		return 0;
	}
	char *cres = new char[result_c];
	if (!WideCharToMultiByte(65001, 0, ures, -1, cres, result_c, 0, 0)) {
		delete[] cres;
		return 0;
	}
	delete[] ures;
	res.append(cres);
	delete[] cres;
	return res;
}