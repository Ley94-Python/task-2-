/ Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) 

if (numberA > numberC)
{
Console.WriteLine($"{numberA} = Максимальное число ");
}

else {
    Console.WriteLine($"{numberC} = Максимальное число");
}

if (numberB > numberC)
{
    Console.WriteLine($"{numberB} = Максимальное число ");
}
else {
    Console.WriteLine($"{numberC} = Максимальное число");
}
