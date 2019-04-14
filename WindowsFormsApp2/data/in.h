#pragma once

typedef struct{
	char region[100];
	int year;
	int month;
	int day;
	int age;
	int sex;
}INFOR;

extern "C" __declspec(dllexport) INFOR dllin(char id[19]);