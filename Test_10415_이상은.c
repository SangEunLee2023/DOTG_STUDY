#define _CRT_SECURE_NO_WARNINGS

#include<stdio.h>
#include<Windows.h>

enum Seletion{
	가위 = 11,
	바위,
	보
};

enum yesORno {
	y = 0,
	Y = 0,
	n = 1,
	N = 1
};

int input_Selection();
int process_Selection(int );

void opening();

void Frist();

void print_Game();

int main(void)
{
	printf("게임을 시작하시겠습니까? Y( 0 ) | N( 1 )\n");
	while (process_Selection(input_Selection()))
		printf("게임을 시작하시겠습니까? Y( 0 ) | N( 1 )\n");
	
	Frist();
	opening();

	return 0;
}
int input_Selection()
{
	int Select;
	printf(">");
	scanf("%d", &Select);

	return Select;
}

int process_Selection(int Select)
{
	switch (Select)
	{
	case 0: return y;
	case 1: return n;
	case 11: return 가위;
	case 12: return 바위;
	case 13: return 보;
	}
}

void Frist()
{
	printf("@게임 설명@\n");
	printf("이 게임은 컴퓨터와 [가위 바위 보 게임] 게임에서 승리하여 점수를 얻는 게임입니다. \n");
	printf("승리하면 3point 를 획득하며 패배하면 1point 를 잃습니다. 만약 비기게 된다면 0point를 획득합니다. \n");
	printf("목표 점수는 17point(개발 당시 개발자 나이)이며 목표 점수를 달성하면 컴퓨터와의 대결에서 승리합니다. \n");
	printf("하지만 점수가 0이하가 될 경우 컴퓨터와의 대결에서 패배합니다. 기본 점수는 8point 입니다. \n");
	printf("게임에서 승리하거나 패배하면 게임이 종료됩니다. \n");

	getch();
}

void opening()
{
	printf("\n\n-----------------------------게임 시작-----------------------------\n\n");
}

void print_Game()
{
	printf("가위( 1 ), 바위( 2 ), 보( 3 )\n");
	printf("무엇을 내시겠습니까?\n");
}
