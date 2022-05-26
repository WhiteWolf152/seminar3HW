/*
Задача 23: 
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 4, 9. 
5 -> 1, 8, 27, 64, 125

view
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125
*/


// проверка ввода корректных данных

int EnterNumberTest()
{
    bool readlineFromStrToInt = true;
    int number =0;

    while (readlineFromStrToInt)
    {
        Console.Write("Введите N : ");
        string numberSTR = Console.ReadLine();

        if (int.TryParse(numberSTR, out int numberInt) )
        {
            number = numberInt;
            if (number < 0) Console.WriteLine("Введите положительное число");

            else if ( number == 0) Console.WriteLine("Введите пожалуйста не 0");

            else
                readlineFromStrToInt = false;
        }
        else Console.WriteLine("Вы ввели текст");  
    }
    return number;
}

// расчет результата

void printResult(int n)
{
    for (int i=1 ; i <= n ; i ++) 
    {
        Console.Write($"{Math.Pow(i , 3)}");
        if (i<n) Console.Write(", ");
    }
}

// вывод результата

printResult(EnterNumberTest());

Console.ReadLine(); 