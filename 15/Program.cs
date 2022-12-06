// Задача 15 про дни недели
Console.Clear();
Console.Write("ввведите день недели цифрой ");
int d = int.Parse(Console.ReadLine());
if ((d > 0) & (d <= 7 ))
    if ((d > 0) & (d <6 ))
    {
    Console.WriteLine("Будний");
    }
    else
    {Console.WriteLine("weeend");}
else
{
  Console.WriteLine("Errrrrrrrooor");  
}
