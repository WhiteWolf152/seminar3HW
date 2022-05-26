/*Задача 19:
 Напишите программу, которая принимает на вход пятизначное число и проверяет, 
 является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/


// Цикл проверки введённой переменной 

string numberUser()
{
    bool readNumUser = true;
    string numbS = "";

    while (readNumUser)
    {
        Console.Write("Введите число в диапазоне 9999 < 100000 : ");
        numbS = Console.ReadLine();

        if (int.TryParse(numbS, out int numbI) )
        {
            if (numbS.Length != 5 || numbS[0] == '-') Console.WriteLine("Введёно не верное число ");
            else readNumUser = false;
        }  
    }
    return numbS;
}

// Функция Формирования результата 

string polindromResult(int sum, string number)
{
    string result = (sum == 2 )? ($"Ваше число {number} - это полиндром ") : ($"Ваше число {number} - это не полиндром");
return result;
}


// Функцмя проверки на полимер и вывод результата 

string polindromTest(string number)
{
    int sum =0;
    string result = "";
    for (int i = 0; i < 2; i++)
    {
        if (number[i] == number[number.Length-i-1]) sum++;
    }
    result = polindromResult(sum,number);

return result;
}

// Тело программы

string number = numberUser();

Console.WriteLine(polindromTest(number));

Console.ReadLine(); 