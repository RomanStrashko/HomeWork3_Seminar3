// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());
int index = number / 10000;
int index1 = ((number % 10000) / 1000);
int index2 = ((number % 100) % 10);
int index3 = (number % 10);

if(index == index3 || index1 == index2)
{
    Console.WriteLine($"Число {number} палиндром");
} 
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}