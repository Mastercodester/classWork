using Console = System.Console;

namespace NUMBERANALYZER;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start of App");
        
        double userNumberInput = 0;
        string userNameInput = "";
        
        Console.WriteLine("Welcome to Number Analyzer");
        Console.WriteLine("\n Please enter your Name ");
        userNameInput = Console.ReadLine();
        Console.WriteLine("Hello," + " " + userNameInput + " " + "Enter Number");
        userNumberInput   = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(userNameInput + ", " + "You Entered" + " "+ userNumberInput);

        if (userNumberInput < 61 && userNumberInput % 2 == 1)
        { 
            
            Console.WriteLine(userNameInput + ", " + " The Number is Odd and less than 60");
        
        }

        if (userNumberInput is >= 3 and <= 25 && userNumberInput % 2 == 0)
        {
            
            Console.WriteLine(userNameInput + ", " +" The Number is Even and less than 25");
            
        }if (userNumberInput is >= 27 and <= 61 && userNumberInput % 2 == 0)
         
        Console.WriteLine(userNameInput + ", " + " The Number is Even and between 26 and 60 inclusive");
       
        if (userNumberInput > 61 && userNumberInput % 2 == 0)
        {
           
            Console.WriteLine(userNameInput + ", "+" The Number is Even and greater than 60");
        }else if (userNumberInput > 61 && userNumberInput % 2 == 1)
        {Console.WriteLine(userNameInput + ", " + " The Number is Odd and greater than 60");
        }


















        Console.WriteLine("End of App");
    }
}