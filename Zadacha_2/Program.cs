// По заданному номеру дня недели вывести его название
Console.Write("Введите номер дня недели от 0 до 6: ");
int day = int.Parse(Console.ReadLine());
if ( day < 0 && day > 7)
{
    Console.Write("В неделе только семь дней Друг!");
}
if ( day == 0)
{
    Console.Write("Понедельник");
}
if ( day == 1)
{
    Console.Write("Вторник");
}
if ( day == 2)
{
    Console.Write("Среда");
}
if ( day == 3)
{
    Console.Write("Четверг");
}
if ( day == 4)
{
    Console.Write("Пятница");
}
if ( day == 5)
{
    Console.Write("Суббота");
}
if ( day == 6)
{
    Console.Write("Воскресенье");
}