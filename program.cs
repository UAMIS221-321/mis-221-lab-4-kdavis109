using System;

class Triangle 
{
  static void Main() 
{
    while (true) 
{
      Console.WriteLine("Enter 1 to display full triangle");
      Console.WriteLine("Enter 2 to display partial triangle");
      Console.WriteLine("Enter 3 to exit");

      int choice;
      if (int.TryParse(Console.ReadLine(), out choice)) 
{
        if (choice == 1) 
{
          int numRows = new Random().Next(3, 10);
          for (int i = 1; i <= numRows; i++)
{
            for (int j = 1; j <= i; j++) 
{
            Console.Write("O ");
}
            Console.WriteLine();
}
} 
     else if (choice == 2) 
{
      int numRows = new Random().Next(3, 10);
      for (int i = 1; i <= numRows; i++) 
{
      for (int j = 1; j <= i; j++) 
{
        if (new Random().Next(2) == 0) 
{
            Console.Write("O ");
} 
      else
{
      Console.Write("  ");
}
}
      Console.WriteLine();
}
} 
      else if (choice == 3) 
{
       break;
} 
      else 
{
      Console.WriteLine("Invalid choice, please try again");
}
} 
      else 
{
      Console.WriteLine("Invalid input, please enter a number");
}
}
}
}
