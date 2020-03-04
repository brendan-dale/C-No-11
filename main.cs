using System;
using System.Collections.Generic;

class Program {
  static void Main () {


   try
   { 
      List<int> numbers = new List<int>() { 2, 53, 456, 87, 456, 54, 90, 890, 45, 25, 65 };

      Console.WriteLine("Enter a number which will be used to divide every number in my list: ");
      int userNumber = Convert.ToInt32(Console.ReadLine()); 

      foreach (int number in numbers)
      {
        int result = number / userNumber;
        Console.WriteLine(result);
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
    finally
    {
      Console.WriteLine("Program continues at this point.");
    }

  Console.WriteLine("Here's the rest of the program.");

  }
}