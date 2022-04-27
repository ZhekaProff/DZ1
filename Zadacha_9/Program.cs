// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число: ");
int count = int.Parse(Console.ReadLine());
if ( count > 99)
{
  if(count >99 && count<= 999);
    {
    Console.WriteLine("Третья цифра: "+count%10+""); 
    }
}
else
{
    Console.WriteLine("У числа "+count+" нет третьей цифры!");
}
