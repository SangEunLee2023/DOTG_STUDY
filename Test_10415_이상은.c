#define _CRT_SECURE_NO_WARNINGS

#include<stdio.h>
#include<Windows.h>

enum Seletion{
	���� = 11,
	����,
	��
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
	printf("������ �����Ͻðڽ��ϱ�? Y( 0 ) | N( 1 )\n");
	while (process_Selection(input_Selection()))
		printf("������ �����Ͻðڽ��ϱ�? Y( 0 ) | N( 1 )\n");
	
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
	case 11: return ����;
	case 12: return ����;
	case 13: return ��;
	}
}

void Frist()
{
	printf("@���� ����@\n");
	printf("�� ������ ��ǻ�Ϳ� [���� ���� �� ����] ���ӿ��� �¸��Ͽ� ������ ��� �����Դϴ�. \n");
	printf("�¸��ϸ� 3point �� ȹ���ϸ� �й��ϸ� 1point �� �ҽ��ϴ�. ���� ���� �ȴٸ� 0point�� ȹ���մϴ�. \n");
	printf("��ǥ ������ 17point(���� ��� ������ ����)�̸� ��ǥ ������ �޼��ϸ� ��ǻ�Ϳ��� ��ῡ�� �¸��մϴ�. \n");
	printf("������ ������ 0���ϰ� �� ��� ��ǻ�Ϳ��� ��ῡ�� �й��մϴ�. �⺻ ������ 8point �Դϴ�. \n");
	printf("���ӿ��� �¸��ϰų� �й��ϸ� ������ ����˴ϴ�. \n");

	getch();
}

void opening()
{
	printf("\n\n-----------------------------���� ����-----------------------------\n\n");
}

void print_Game()
{
	printf("����( 1 ), ����( 2 ), ��( 3 )\n");
	printf("������ ���ðڽ��ϱ�?\n");
}
