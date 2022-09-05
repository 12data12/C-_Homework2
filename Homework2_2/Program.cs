// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write(" Enter number ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
Console.WriteLine(" The third figure is "+anyNumberText[2]);
}
else {
  Console.WriteLine("There is no third figure "); 
}