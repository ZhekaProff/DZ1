// Показать четные числа от 1 до N
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int i = 2;
while ( i <= n)
{
    Console.Write(i);
    Console.Write(" ");
    i = i + 2;
}