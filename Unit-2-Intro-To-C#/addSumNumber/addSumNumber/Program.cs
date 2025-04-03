namespace addSumNumber;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--------Start of Program--------");
        
        //Ask the User for 3 numbers one at a time
        //to produce a sum
        
        //Do this 3 times( Loop ex)
        //          Ask user to enter a number
        //          get the number from the user
        //          add the number to a sum 
        //
        //2. Display the sum of the numbers
        
        
        //Data we need
        //
        //1.a place to hold the number entered by the user
        //2. a place to hold the sum of the numbers
        //
        
        //Define a place to hold the number entered by the user
        int firstNumber = 0;
        
        
        //Define  a place to hold the sum of numbers
        int sum = 0;
        
        
        //Loop through our process 3 times
        //If you know the number of times you want to loop
        // Use a for-loop
        //
        //Syntax of a for loop: for (int variable = initial -value; variable < #-times-to-Loop; variable ++){}
        
        
        //1. initialization-part 2a loop - condition - part   2b increment
        
        //the for-loop is controlled by the variable in it
        //
        // 1. int variable = initial-value - initializes the variable (usually to 0)
        // 2. the condition following the variable definition is tested:
        //      a. if true - perform the process between the {} for the for-loop
        //        b.      ++increment the variable according the last  part of the loop go back to #2
        //      c. if false - exit the loop after the closing brace }
        //


        for (int i = 0; i < 3; i++) // i=0, 1, 2inside the loop - 3 casues it to exit
        {
            
            //Ask the user to enter a number
            Console.Write("Enter first number: ");
            //Get the number they enter
            string Response = Console.ReadLine();
            firstNumber = int.Parse(Response);
        
            //Alternate way way to get the number without using a string variable
            //Combine multiple statements into one
            // firstNumber = int.Parse(Console.ReadLine());
       
            // Add the number to the sum
            sum = sum + firstNumber; // sum += firstNumber; works too


            
        }

        //2. Display the sum of the numbers
        Console.WriteLine("\nSum of the numbers is: " + sum);

    
        
        
        
        
        
        
        
        
        
        
        Console.WriteLine("--------End of Program--------");
    }
}