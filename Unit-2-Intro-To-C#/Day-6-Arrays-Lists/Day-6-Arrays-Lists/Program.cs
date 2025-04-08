namespace Day_6_Arrays_Lists;

// This program will ask for three numbers
//      add them together and display the total

class Program
{
    static void Main(string[] args)
    {
        // Define the variables to hold the numbers we need to add
        int[] numbers = new int[3]; // numbers.Length=3; 2 is the largest allowable index
        // Define a variable to hold the sum of the numbers
        int sum = 0;

        Console.WriteLine("--- Starting program ---");
//normally we process an array from beginnig to end
// (from the first element  to last element, one at a time)
//
// a for loop will loop through a process counting as it does so
// a for loop is an excellent tool for processing an array from start to end
//
//arrayName.Length represents the number of elements in a array


//
// index loop as
// start long as the index increment the
// at 0 is not outside array index for each loop
        for (int i = 0; i < numbers.Length; i++) //i= 0, 1,2 inside loop and 3 when exit loop
        { Console.WriteLine("Please enter a number:  "); // Asking for the number
        numbers[i] = int.Parse(Console.ReadLine());// get a string
                                                   // convert it to an int
                                                   // store it in numbers[i]
        }

// verify the array received the number correctly
// Go through the array one element at a time and display the element

        for (int i = 0; i < numbers.Length; i++) 
        {Console.WriteLine("Element # "+ i + "is" + numbers[i]);
            sum = sum + numbers[i];
        }

        





    
       
        // Tell the requester the sum/total (display)
        Console.WriteLine("The sum is: " + sum);
        
        
        // Tell the requester the  average of the numbers
        // divides the sum by the number of elements (arrayname.length)
        
        // note the cast of sum to a double so we get decimal places in the results
        Console.WriteLine("the average of the number is: " + (double) sum / numbers.Length);
        
        
        //sum/ numbers.length
        //int/ int ---> integer arithmetic - divide gives two parts quotient and remainder
        // int                                      7/3 - quotient = 2 remainder = 1
        
        //(double) sum / numbers.length
        //convert sum
        //to double/int ---->
        
        // convert int to double ( c# does this automatically)
        // double  / double ---> floating point artmetic

        Console.WriteLine("--- Ending program ---");
    }
}