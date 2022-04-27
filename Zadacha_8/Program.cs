// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.Write("Введите проверямое число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите делитель: "); 
int number1 = int.Parse(Console.ReadLine()); 
if (number % number1 == 0)
{
    Console.WriteLine("Число: "+number+" кратно числу "+number1+"");
}
else
{   
    int remains = number % number1; 
    Console.WriteLine("Число " + number + " не кратно числу "+number1+"");
    Console.WriteLine("Остаток от деления: "+remains+"");
}
