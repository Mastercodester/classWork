using System;
 // Give me access to the systems generic collections stuff

namespace Day_2_Dictionary_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************
             * Example use of a Dictionary with array/List value
             *********************************************************/

            // Ask the user for a name and a grade
            // Store them in a Dictionary

            // Dictionary to hold name (key) and grade (value)
            //         key     value
            //         type    type    name      = new Dictionary<key-type, value>();
           // Dictionary<string, double> gradeBook = new Dictionary<string, double>();
         //  Dictionary<string, double> gradeBook = new Dictionary<string, double>();
          Dictionary<string, List<double>> gradeList = new Dictionary<string, List<double>>();
            // Lets add 3 students - loop 3 times for-loop
            //Loop until the user satisfies a condition instead of a specific # of times
            //Replace the for loop  with either a while-loop or do-while()
            //do we want loop at least once ? Yes do-while loop ...No- while
            // Is ok to loop 0-times? Yes -while loop ...No - do-while loop
            //
            // In this case we have to ask the user at least once to enter some data

            //HOw do we want the user to let us know they are done?
            //create an on/off switch
            //Prompt - ask if they are done
            //Set a condition based on what they tell us
            //Define data used in the loop Before the loop so its accessible 
            //           both inside and outside loop
            //scope- where can a variable be used - only in the blocks its defined
            //for (int i = 0; i < 3; i++)

            string userResponse = "";
            do
            {

                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
                Console.Write("Enter grade: ");
                
                //Because the user might enter n non-numeri grade causing an exception
                //We should handle the exception so the program doesn't end
                // with a message that will scare the human 
                //We can use a try/catch to handle the exception
                //When the user enters a non numeric grade
                // 1. ignore it - we are doing this
                //                    not even put them in the dictionary
                // 2. give them another chance to enter it
                // 3. Set the grade to 0
                double grade = 0;
                string userGrade = "";
                string whatTheyTyped = "";
              
                    List<double> grades = new List<double>();
                try
                {// A statement inside this  try block might cause an exception
                    // Awe need to get multiple grades and store them in a list
                    while (whatTheyTyped != "end") {}
                 Console.Write("Enter grade or end");
                 whatTheyTyped = Console.ReadLine();
                 if (whatTheyTyped == "end")
                 {
                     break;
                 }
grade = Double.Parse(whatTheyTyped);
                 userGrade = Console.ReadLine(); // Get student grade
                     grade = Double.Parse(userGrade);
                }
                catch (FormatException exceptionObject)// if it throws a FormatException
                {
                    
                    Console.WriteLine("The data you entered" + userGrade + "is not a valid number.");
                    Console.WriteLine("The data is ignored.");
                    //skip adding the student to the dictionary 
                    continue; //(skip the rest of the loop processing )
                }

                // Add the data to our Dictionary
                // Dictionary[key}     = value;
                gradeList[studentName] = grade; // gradeBook.Add(studentName, grade) // may cause an exception


                //We need to find out if they have more students to enter
                //We want to be sure they only enter responses we expect
                //Loop until we get a valid response ......
                //for-loop- do we know how many times we want o loop?
                //while- Do we loop based on acondition? Can we loop 0 times?
                //do-while - Do we loop based on a condition-  Do we need the loop at least once?
                // Console.Write("Are you done? y/n");
                //Get a response from the user and convert to lowercase

                //We are checking userResponse Before

                do
                {
                    Console.WriteLine("Are you done? (y/n)");
                    userResponse = Console.ReadLine().ToLower();

                } while (userResponse != "y" && userResponse != "n");
            
            /*if (userResponse != "y" || userResponse != "n")
            {
                Console.WriteLine("Sorry, we only accept 'y' or 'n'");
            }*/
            
            
        } while (userResponse != "y"); // Loop while they are not done (done = "y")

            // Display the entrys in our Dictionary
            // Use a KeyValuePair type to get an entry from teh Dictionary
            foreach (KeyValuePair<string, double> anEntry in grade)
            {
                Console.WriteLine(anEntry.Key + " has a grade of " + anEntry.Value);
            }

            Console.WriteLine("Please press enter to end program...");
            Console.Read();
        }
    }
}