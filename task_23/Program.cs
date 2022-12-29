/*Задача 23
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.*/
Console.WriteLine("Введите положительное число  ");
int number = Convert.ToInt32(Console.ReadLine());
int n = 1;
if (number <= 0)
{
Console.WriteLine("Введенное число отрицательное");
return;
}
while(n <= number)
{
  double res = Math.Pow(n, 3);
  Console.WriteLine($"{res}");
  n ++;
}