/* Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.  */
 
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int d1 = 0;
int d2 = 0;
int d4 = 0;
int d5 = 0;

if(number  < 0)
  {
    Console.WriteLine ("Это число отрицательное");
    return;
  }
if(number / 5 < 2000 || number /5 >= 20000)
  {
     Console.WriteLine ("Это число не 5-ти значное");
     return;
  }
else  
  d1 = number / 10000;
  d2 = number / 1000 % 10;
  d4 = number / 10 % 10;
  d5 = number % 10;
if(d1 == d5 && d2 == d4)
  Console.WriteLine("Это число палиндром");
else
  Console.WriteLine("Это число НЕ палиндром");
