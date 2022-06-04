/*
Задача 21: 

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

// проверка на ввод корректных данных

int EnterNumberTest()
{
    bool readlineFromStrToInt = true;
    int number = 0;
    while (readlineFromStrToInt)
    {
        string numberSTR = Console.ReadLine();

        if (int.TryParse(numberSTR, out int numberInt))
        {
            number = numberInt;
            readlineFromStrToInt = false;
        }
        else Console.Write("Вы ввели текст, введите пожалуйста число : ");
    }
    return number;
}

// ввод координат для проверки

void Test(int i, int j)
{
    if ((i == 0) && (j == 0)) Console.Write(" Введите координату  X1 : ");
    else if ((i == 0) && (j == 1)) Console.Write(" Введите координату  Y1 : ");
    else if ((i == 0) && (j == 2)) Console.Write(" Введите координату  Z1 : ");
    else if ((i == 1) && (j == 0)) Console.Write(" Введите координату  X2 : ");
    else if ((i == 1) && (j == 1)) Console.Write(" Введите координату  Y2 : ");
    else Console.Write(" Введите координату  Z2 : ");
}

// создание массива

int[,] CoordEnter()
{
    int[,] array = new int[2, 3];
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Test(i, j);
            array[i, j] = EnterNumberTest();
        }
    }
    return array;
}

// вычисление длинны


double lengtCount(int[,] array)
{
    double d = (double)Math.Sqrt(Math.Pow(array[1, 0] - array[0, 0], 2)
                        + Math.Pow(array[1, 1] - array[0, 1], 2)
                        + Math.Pow(array[1, 2] - array[0, 2], 2));

    return d;
}

int[,] array = new int[2, 2];

array = CoordEnter();

Console.WriteLine($"Length = {lengtCount(array):N2}");

Console.WriteLine();

