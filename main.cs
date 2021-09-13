using System;

class Program {
  public static void Main (string[] args) {
    //storing both numbers from input
    Console.WriteLine ("Enter a number: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Enter another number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());

    //performing arithmatic operations and displaying output
    int sum = num1 + num2;
    Console.WriteLine("Sum = " + sum);
    
    int diff = num1 - num2;
    Console.WriteLine("Diff = " + diff);
    
    int product = num1 * num2;
    Console.WriteLine("Product = " + product);
    
    int quotient = num1 / num2;
    Console.WriteLine("Quotient = " + quotient);
    
    int remainder = num1 % num2;
    Console.WriteLine("Remainder = " + remainder);
  }
}