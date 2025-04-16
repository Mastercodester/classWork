namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        const int ARRAY_SIZE = 2; 
        string[] theWords = new String[ARRAY_SIZE]; 
        int wordsEntered = 0;
        
        Console.WriteLine("Start of program");
        
        /*
        Console.WriteLine("Enter a sentence:");
       
        string sentence = Console.ReadLine();
        
        string[] words = sentence.Split(' ');
        */
        
        for (int i = 0; i < ARRAY_SIZE; i++)//instead of Array_size theNumbers.Length is ok too
        {
            // if (moreInput!= true) // alternate coding size
            if (!moreInput()) // if they don't have any more input...moreInput() is a method returning true or false
            {
                break;  // exit the for-loop
            }
            // At this point we know the user has a number to enter

            // Call the method to get a numeric value and store it in the current array element indicated by i
            theWords[i] = GetWords();  // get the number and store in the next array element

            wordsEntered++;  // Count a number being entered
            //end of for-loop - break send us to end
        }
      
        Console.WriteLine("End of program");
        
    }
    static bool moreInput()
        {
            bool   isThereInput  = false;  // Hold teh return value (indicate if we have valid input)

            string whatUserTyped = "";     // Hold what the user enters

            bool   getInput      = true;   // Control the user interaction loop(do-while)

            
            //do-while - loop while the condition is true
            // the condition is on the while part of the loo[m at the bottom of loop
            // you will always loop at least once with a do-while
            //(the loop condition is not checked until the end of the loop)
            //(unlike for-loop or while-loop where the condition is checked before you loop even once)
            //
            //We use a do-while loo[ because we need to ask the user at least once is they have any input
            do
            {
                // Ask the user if they have any numbers to enter (Y/N)
                Console.WriteLine("Do you have any sentences to enter (Y/N)?");
                whatUserTyped = Console.ReadLine();

                
                // convert the user input to all uppercase - so we dont have to worry about case
                whatUserTyped = whatUserTyped.ToUpper();

                
                // extract the first character from the user input- substring(start-index, #-of-chars)
                string firstChar = whatUserTyped.Substring(0, 1);

                if (firstChar == "Y")
                {
                    getInput = false;  //Done getting input - set loop control variable to false
                    isThereInput = true;// indicate user has more input - set the input indicator to true
                }
                else
                {
                    if (firstChar == "N")
                    {
                        getInput = false; //Done getting input 
                        isThereInput = false;// user has nomore input
                    }
                }
            } while (getInput); // Loop while we get input(while getInput == true)
// while(getInput == true) // alternate way of coding
//it's not necessary when you have bool variable since the variable can only be true or false
// so the variable name will be true or false no need to == or !=
            return isThereInput;
        }
    
       static string GetWords()
        {
            // define a variable for the return value
            String theValue = "";

            // Ask the user for a numeric value and have them keep trying until we get one

            bool isValidNumber = false;  // Determine is user entered a valid value

            // Loop until we get a valid numeric value

            do  // do loop is used so we ask the user for a number at least once
            {
                // Prompt the user to enter a numeric value
                Console.WriteLine("Enter a sentence:");
       
                string sentence = Console.ReadLine();
        
               

  
                List<string> wordsList = new List<string>();
                string[] words = sentence.Split(' ');
                wordsList.AddRange(words);

              
                foreach (string word in wordsList)
                {
                    Console.WriteLine(word);
                }


                //some statements may cause an exception during processing
                // an exception is a error that ocurs when the program runs (aka runtime exception)
                //when an exception occurs a crytic (to normal people) error message is displayed and
                // the programs stops
                //
                //YOu can handle an exception that might occur in the program and let the program continue
                // with a try/catch blocks
                //
                //you put  code that might cause exceptions in a try block
                //followed by one or more catch blocks for the exception
                // catch (exception to handle name for exception object)
                //
                // the exception object contains information about the exception you might want to use
                
                
                try // We want to handle an Exception that might occur in this block of code
                //exception is error
                {
                    // Convert the user input to a double
                   // Could cause an Exception
                    isValidNumber = true;  // if .Parse() worked we have a valid number
                }
                // catch (Exception exceptionBlock) will handle every Exception that can occur
                catch (FormatException exceptionBlock) // Handle a FormatException in previous try block
                //pretty much like errors-FormatException
                {
                    Console.WriteLine("\n----- Uh-oh Uh-oh Uh-oh ------");
                    Console.WriteLine("There is problem with " + sentence);
                    Console.WriteLine(exceptionBlock.Message); // Display the system message for the error
                    Console.WriteLine("------ Uh-oh Uh-oh Uh-oh ------\n");
                }
            } while (!isValidNumber); // Loop while we don't have a valid number

            // return the double value from the user input
            return theValue;
        } // End of getANumber() method
}