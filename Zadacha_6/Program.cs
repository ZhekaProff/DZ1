// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99");
int count = int.Parse(Console.ReadLine());
Console.Write("Наибольшая цифра: ");
int count1 = count % 10;
int count2 = count / 10;
    if ( count1 >= count2)
    {
        Console.Write(count1);
    }
else
{
    Console.Write(count2);
}