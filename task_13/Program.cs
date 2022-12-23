// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число: ");
int number=Convert.ToInt32(Console.ReadLine());
if (number>99)
{
   while (number>999)
   {
    number=number/10;
   } 
int result=number%10;
System.Console.WriteLine("третья цифра числа: "+ result);
}
else System.Console.WriteLine("третьей цифры нет");