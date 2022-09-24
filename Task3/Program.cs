// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

for(int index = 1; index <= number; index++)
{
    double result = Math.Pow(index,3);
    Console.Write($"{result} ");
}