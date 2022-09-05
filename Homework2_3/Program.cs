// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день 

Console.Write(" Enter the number of day of week ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("It is a weekend! Huzzah!");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("Hmmm... There is no such day of the week");
  }
  else Console.WriteLine("Oh no... It is not a weekend :(");
}

CheckingTheDayOfTheWeek(dayNumber);