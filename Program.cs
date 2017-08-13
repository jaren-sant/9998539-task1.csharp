using System;

namespace _9998539_task1.csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Would you like to convert from Celcius to Fahrenheit or Fahrenheit to Celcius?");
            Console.WriteLine("Press 'c' to convert to Celcius or 'f' to convert to Fahrenheit.");
            var type = Console.ReadLine();
            Console.WriteLine("What is the value to be converted?");
            var valueString = Console.ReadLine();
            var isnumber = Double.TryParse(valueString, out double valueDouble);
            if(isnumber) {
                if(type == "c" ) {
                    Console.WriteLine(valueDouble+" degrees Fahrenheit is equal to "+((valueDouble-32)*5/9)+" degrees Celcius.");
                }
                else{
                    if(type == "f") {
                    Console.WriteLine(valueDouble+" degrees Celcius is equal to "+(valueDouble*9/5-32)+" degrees Fahrenheit.");
                    }
                    else{
                        Console.WriteLine("We cannot convert your value as you have provided us with an incorrect conversion type.");
                    }
                }
            }
            else{
                Console.WriteLine("The value you have entered is not a number, please enter a number next time.");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
