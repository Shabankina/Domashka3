// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int num = number;
int a = 0;
int b = 0;
int c = 0;
int d = 0;
int i = 0;
int newNumber = 0;

if (num != 0)
{
    a = num % 10;
    num = num / 10;
}
if (num != 0);
{
    b = num % 10;
    num = num / 10;    
}  
if (num != 0);
{
    c = num % 10;
    num = num / 10;    
}
if (num != 0);
{
    d = num % 10;
    num = num / 10;    
}
if (num != 0);
{
    i = num % 10;
    num = num / 10;   
}
newNumber = int.Parse(a.ToString() + b.ToString() + c.ToString() + d.ToString() + i.ToString());

if (number - newNumber == 0)
{
    Console.Write("Число палиндром");
    return;
}
    if (number - newNumber != 0);
    {
        Console.Write("Число НЕ палиндром");
    } 
    
 