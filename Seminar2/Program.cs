/*Задача 1
int CutNumber(int num)
{
    int hundreds = num / 100;
    int  units = num % 10;
    int result = hundreds * 10 + units;

    return result;
}

int randNumber = new Random().Next(100,1000);

int newNumber = CutNumber(randNumber);
Console.WriteLine($"New version if {randNumber} is {newNumber}");
*/

/*Задача 2*/
/*
bool IsMultiplayed(int num, int div1, int div2)
{
    
    if(num % div1 == 0  && num % div2 == 0)
    {
        return   true;
    }
else
    {
        return  false;
     }
}

/*bool IsMultiplayedBest(int num, int div1, int div2)
{
    return num % div1 == 0  && num % div2 == 0
}
*/
/*
Console.Write("input a number for checking: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("input a  first divider: ");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a  second divider: ");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool result = IsMultiplayed(number, divider1, divider2);
Console.WriteLine(result);

Задача 3*/
/*
int BiggestNum(int num)
{
    int tens = num / 10;
    int units = num % 10;
    if (units > tens)
    return units;
    else
    return tens;
}
int ramdNumber = new Random().Next(10.100);
int big = BiggestNum(ramdNumber);
Console.WriteLine($"the biggest sing of number {ramdNumber} is {big}");


Задача 4 */
/*
bool Square0rNot(int num1,  int num2)
{
    return (num1 / num2 ==  num2 || num2 / num1 == num1);
}
Console.Write("please insert first number : ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("please insert second number : ");
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = Square0rNot(num1, num2);
if (result)
{Console.WriteLine($ "Number {num1} or number {num2} is  square of the other number" );
}
else
   { Console.WriteLine($ "Number {num2} or number {num2} is  not  square of the other number" );
}
*/
/*Домашнее задание;*/
/*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.*/

/*int Prompt(string message)
 {
System.Console.Write(message) ;
string value = Console.ReadLine();
int result =  Convert.ToInt32(Console.ReadLine());
return result;
 }
int number = Prompt("Введите трехзначное число > "); 
if (number < 100 || number >= 1000) 
{
Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод") ;
return;
}
Console.WriteLine($"Введенное число '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}'");*/

/* Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
/*
int Prompt(string message) 
{
Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(Console.ReadLine()); 
return result;
}
int GetThirdRank(int number) 
{
     while (number > 999) 
     { number /= 10;
} 
return number % 10;
}
bool ValidateNumber(int number)
 {
     if (number < 100) 
     {
Console.WriteLine("Третьей цифры нет");
 return false;
}
 return true;
}
int number = Prompt("Введите число > ");
 if (ValidateNumber(number))
  {
Console.WriteLine(GetThirdRank(number));
}
*/
/*Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.*/
/*
int Prompt(string message) 
{
Console.Write(message);
string value = Console.ReadLine(); 
int result = Convert.ToInt32(Console.ReadLine()); 
return result;
}
bool IsWeekend(int weekDay) 
{
if (weekDay > 5) 
{
return true;
}
 return false;
}
bool ValidateWeekday(int number)
{
if (number > 0 && number <= 7) 
{
return true; 
}
Console.WriteLine("Это не день недели!"); 
return false;
}
int weekDay = Prompt("Введите день недели >"); 
if (ValidateWeekday(weekDay))
 {
if (IsWeekend(weekDay)) 
{
Console.WriteLine("Наконец-то выходной"); 
}
 else 
 {
    Console.WriteLine("Придется поработать"); } }
