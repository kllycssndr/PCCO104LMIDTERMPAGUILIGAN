using System;

class Program {
  public static void Main (string[] args) {
    const int baseFanPower = 10;
    int fanSpeed = 0;
    char oscillateOption;

    do { Console.WriteLine("Enter fan speed(1,2,3): ");
      string speedInput = Console.ReadLine();
      if(!int.TryParse(speedInput, out fanSpeed)|| fanSpeed < 1 ||fanSpeed> 3)
      { Console.WriteLine(" Invalid Input. Enter a valid fan speed.");
        continue;}
      
      Console.WriteLine("Enter Oscillation option (Y / N): ");
      string oscillateInput = Console.ReadLine();
      if (!char.TryParse(oscillateInput, out oscillateOption)|| (oscillateOption != 'Y' && oscillateOption != 'N')) 
      { Console.WriteLine("Invalid Input. Enter a valid oscillation option ( Y / N ).");}
      
      break;}

  while (true);
    if (oscillateOption == 'Y')
    { for (int i =  1; i<= baseFanPower * fanSpeed; i++)
      { Console.WriteLine(new string ('∼',i));}}
    else 
    { string steadyOutput = new string ('∼', baseFanPower * fanSpeed);
      for (int i = 0; i<10; i ++)
      {
        Console.WriteLine(steadyOutput);
      }
    }
  }
}