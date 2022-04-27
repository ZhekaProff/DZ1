// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзнчное число: ");
int count = int.Parse(Console.ReadLine());
int count1 = count / 100;
int count2 = count % 10;
Console.WriteLine("Ваше новое число: "+count1+""+count2+"");