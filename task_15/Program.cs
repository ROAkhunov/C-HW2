//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите порядковый номер дня недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber<8 && dayNumber>0)
{
    if (dayNumber==6 || dayNumber==7)
    {
       System.Console.WriteLine("выходной"); 
    }
    else System.Console.WriteLine("не выходной");
}
else System.Console.WriteLine("Нет дня недели с таким номером");