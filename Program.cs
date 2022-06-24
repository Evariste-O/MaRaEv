using System;
  public class Program{
    public static void main{
      Console.WriteLine("Fahrtdauer eingeben pls:");
      var input = Console.ReadLine();
      if (!Int32.TryParse(input, out var duration)) {
        return;
      }
      Console.WriteLine("Fahrtpreis eingeben:");
      input = Console.ReadLine();
      if (!Int32.TryParse(input, out var price)) {
        return;
      }
      Console.WriteLine(duration*price);
  } 
}
