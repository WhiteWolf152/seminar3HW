/*
 Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/
int GetNumber(string msg)
{
    while(true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            if ((number / 10000) > 0 && (number / 10000 <10))
            {
                return number; 
            }
            else
            {
                Console.WriteLine("Вы ввели не пятизначное число.");
            }   
        }
        else
        {
             Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

int number = GetNumber("Введите пятизначное число");


bool GetPolindro(int number)
{
    string numberst = Convert.ToString(number);
    int length = numberst.Length;
    int targetCount = length / 2;
    bool isPolindrom = false;
    for (int i = 0; i <= targetCount;)
     {
        if (numberst[i] == numberst[length-1])
        {
            i++;
            length--;
            isPolindrom = true;
        }
        else
        {
            isPolindrom = false;
            break;

        }   
         
     }
     return isPolindrom;
}

bool isPolindrom = GetPolindro(number);
if (isPolindrom)
{
    Console.WriteLine($"{number} -> Ваше число полиндром");
}
else
{
    Console.WriteLine($"{number} -> Ваше число не полиндром");
}


