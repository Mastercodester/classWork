namespace Day_7_Array_Example;

using System;

class Program
    {
        /**************************************************************************************
         * This app will receive up to 10 numbers from the user
         *
         * After the user has indicated they have no more numbers to enter
         *             or 10 numbers have been entered...
         *               
         * We will display each or the numbers entered with an indicator if number odd or even,
         *                 their sum and average
         *
         * Since we need to do something after we have all the numbers,
         *     rather than as we get each number
         *
         * We need to store the number the user entered and process them all when user is done
         *
         * We need to have some way for the user to tell us they are done entering numbers
         *****************************************************************************************/

        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to my app!");       // Verify the app started

            
            //const marks the variable as a constant
            //a constant cannot be changed once it is assignes a value
            //CONSTANT NAMES SHOULD BE ALL UPPERCASE WITH _ TO SEPARATE THE PARTS OF A NAME
            // Define a constant to use to reference the size of the array
            const int ARRAY_SIZE = 5;  // use this every where you want to code the size of the array

            // Define an array to hold up to 10 numbers entered by the user
            double[] theNumbers = new double[ARRAY_SIZE];  //define an array of 10 doubles

            // Define a variable to hold the user input
            string whatUserTyped = "";

            // Define a variable to hold the sum of number
            double theSum = 0;

            // Define a variable to hold the number of variables entered by the user
            int numberEntered = 0;

            
            //when you need to process a array from start to end 
            // use a for-loop
            //for(int i=0; i<size-of array; i++) - use i as the index into the array inside the loop
            
            // Set up a loop to get ARRAY_SIZE numbers, one at a time or responses indicating the user is done
            for (int i = 0; i < ARRAY_SIZE; i++)//instead of Array_size theNumbers.Length is ok too
            {
                // if (moreInput!= true) // alternate coding size
                if (!moreInput()) // if they don't have any more input...moreInput() is a method returning true or false
                {
                    break;  // exit the for-loop
                }
                // At this point we know the user has a number to enter

                // Call the method to get a numeric value and store it in the current array element indicated by i
                theNumbers[i] = GetANumber();  // get the number and store in the next array element

                numberEntered++;  // Count a number being entered
                //end of for-loop - break send us to end
            }
            // Since the variable i has the number of times through the loop
            // Can we use it after the loop to store the number of values entered?
            //
            // numberEntered = i;
            //
            // NO! i is defined in the for loop - so it can be used inside the for-loop (scope)

            // So now the array has all the numbers entered by the user

            Console.WriteLine("So I received "+ numberEntered + " numbers from you");

            // Go through the array and display each number, whether it's odd or even
            // Only process the numbers that were entered. i.e. NOT arrayname.length
            for (int i = 0; i < numberEntered; i++)
            {
                
                //
                // the ternary operator: condition? value-if-true : value-if-false
                //
                // (is array element evenly disible by 2? yas-even : no-odd)
                // theNumbers[i] % 2 == 0 ? "Even" : "Odd"
                //
                //%-modulus operator - returns the remainder after an integer divide
                //
                //   6%2 return 0
                // 7 % 2 return 1
                //101 % 33 - return 2 (100/33 - 3 with the remainder of 2)
                // 
                // if you divide a number by 2 and remainder is 0, it's even
                //                              remainder is 1, it's odd
                Console.WriteLine("Element #: " + i + " is: " + theNumbers[i] 
                                + " it is " + (theNumbers[i] % 2 == 0 ? "Even" : "Odd"));

                theSum = theSum + theNumbers[i];
            }

            Console.WriteLine("The sum of the numbers is: " + theSum);
            Console.WriteLine("The avg of the numbers is: " + theSum / numberEntered);

            Console.WriteLine("\nThanks for using my app!"); // Verify the app ended

            Console.WriteLine("\nPress enter to end program...");
            Console.ReadLine();
        } // End of Main()

        /****************************************************************
         * Helper methods used by Main()
         ******************************************************************/

        // return a boolean value to indicate if teh user has more input
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
                Console.WriteLine("Do you have any numbers to enter (Y/N)?");
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

        // method starts with a method signature:  return-type name(parameters)

        // This method will get a numeric value from the user
        // It must be static because it will be used by the static method Main() (more later)
        // this method receives no parameters and returns a double (a double can also hold an int value)
        static double GetANumber()
        {
            // define a variable for the return value
            double theValue = 0;

            // Ask the user for a numeric value and have them keep trying until we get one

            bool isValidNumber = false;  // Determine is user entered a valid value

            // Loop until we get a valid numeric value

            do  // do loop is used so we ask the user for a number at least once
            {
                // Prompt the user to enter a numeric value
                Console.WriteLine("Please enter a number");

                // Get the input from the user
                string userInput = Console.ReadLine();

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
                    theValue = double.Parse(userInput); // Could cause an Exception
                    isValidNumber = true;  // if .Parse() worked we have a valid number
                }
                // catch (Exception exceptionBlock) will handle every Exception that can occur
                catch (FormatException exceptionBlock) // Handle a FormatException in previous try block
                //pretty much like errors-FormatException
                {
                    Console.WriteLine("\n----- Uh-oh Uh-oh Uh-oh ------");
                    Console.WriteLine("There is problem with " + userInput);
                    Console.WriteLine(exceptionBlock.Message); // Display the system message for the error
                    Console.WriteLine("------ Uh-oh Uh-oh Uh-oh ------\n");
                }
            } while (!isValidNumber); // Loop while we don't have a valid number

            // return the double value from the user input
            return theValue;
        } // End of getANumber() method
    } // End of class Program