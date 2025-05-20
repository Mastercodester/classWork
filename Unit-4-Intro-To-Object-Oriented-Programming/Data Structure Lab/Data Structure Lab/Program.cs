namespace Data_Structure_Lab;

class Program
{
    public static string userInput = "";
    public static string userRev = "";
    public static string newWord= "";
    
    static void Main(string[] args)
    {
        Console.WriteLine("Start of program");
        
        Console.WriteLine("Enter a word to reverse");
        userInput = Console.ReadLine();

        newWord = Reverse(userInput);
        Console.WriteLine(newWord);
        Console.WriteLine("End of program");
    }

    public static string UserInput => userInput;
    
    public static string Reverse(string input)
    {
       
        userRev = input;
        userRev.ToCharArray();
        
        
        return userRev;
    }
}