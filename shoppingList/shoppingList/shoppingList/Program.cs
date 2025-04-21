namespace shoppingList;

class Program
{//Display at least 8 item names and prices.
    //

    static void Main(string[] args)
    {
        Console.WriteLine("Start of Program");

        string isUsersDone = "";
        double totalSum = 0;
        Dictionary<string, List<double>> inventoryList = new Dictionary<string, List<double>>()
        {
            /*
            Item            Price
            ==============================
            apple           $0.99
            banana          $0.59
            cauliflower     $1.59
            dragonfruit     $2.19
            Elderberry      $1.79
            figs            $2.09
            grapefruit      $1.99
            honeydew        $3.49
            */

            { "apple", new List<double> { 0.99 } },
            { "banana", new List<double> { 0.59 } },
            { "cauliflower", new List<double> { 1.59 } },
            { "dragonfruit", new List<double> { 2.19 } },
            { "elderberry", new List<double> { 1.79 } },
            { "figs", new List<double> { 2.09 } },
            { "grapefruit", new List<double> { 1.99 } },
            { "honeydew", new List<double> { 3.49 } },

        };


        List<KeyValuePair<string, double>> cart = new List<KeyValuePair<string, double>>();
        string userPick = "";

        Console.WriteLine("Welcome to Chirpus Market!");


        Console.WriteLine("Inventory List:");
        Console.WriteLine("Item" + "   " + "Price");
        Console.WriteLine("=============");
        foreach (var item in inventoryList)
        {
            Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
        }

        do
        {
        

        Console.WriteLine("What item would you like to buy?");
       
       
            
        
        switch (userPick)
        {
        

            
            /*
            Item            Price
            ==============================
            apple           $0.99
            banana          $0.59
            cauliflower     $1.59
            dragonfruit     $2.19
            Elderberry      $1.79
            figs            $2.09
            grapefruit      $1.99
            honeydew        $3.49
            */
            

            case "apple":
                cart.Add(new KeyValuePair<string, double>("apple", 0.99));
                Console.WriteLine("Apple has been added to your cart.");
                break;
            case "banana":
                cart.Add(new KeyValuePair<string, double>("banana", 0.59));
                Console.WriteLine("Banana has been added to your cart.");
                break;
            case "cauliflower":
                cart.Add(new KeyValuePair<string, double>("cauliflower", 1.59));
                Console.WriteLine("cauliflower has been added to your cart.");
                break;
            case "dragonfruit":
                cart.Add(new KeyValuePair<string, double>("dragonfruit", 2.19));
                Console.WriteLine("dragonfruit have been added to your cart.");
                break;
            case "elderberry":
                cart.Add(new KeyValuePair<string, double>("elderberry", 1.79));
                Console.WriteLine("elderberry have been added to your cart.");
                break;
            case "figs":
                cart.Add(new KeyValuePair<string, double>("figs", 2.09));
                Console.WriteLine("figs have been added to your cart.");
                break;
            case "grapefruit":
                cart.Add(new KeyValuePair<string, double>("grapefruit", 1.99));
                Console.WriteLine("grapefruit have been added to your cart.");
                break;
            case "honeydew":
                cart.Add(new KeyValuePair<string, double>("honeydew", 3.49));
                Console.WriteLine("honeydew have been added to your cart.");
                break;
            default:
                Console.WriteLine("Invalid item, please try again.");
                break;
        }
     

        do
        {
            Console.WriteLine("Would you like to order anything else (y/n)?");
            isUsersDone = Console.ReadLine().ToLower();
        } while (isUsersDone != "y" &&  isUsersDone != "n");
       


    }while(isUsersDone == "y"); 




    Console.WriteLine("\nYour Cart:");
        foreach (var item in cart)
        {
            Console.WriteLine($"{item.Key}: ${item.Value}");
            totalSum    += item.Value;
            Console.WriteLine("Your cart Total:"+ totalSum);
        }
        //Would you like to order anything else (y/n)?
        
    
        
        Console.WriteLine("End of Program");
    }
    
    
     
     // /*do 
     //        {
     //            // Ask the user for the student name and grade
     //            Console.Write("Enter student name: ");
     //            string studentName = Console.ReadLine(); // Get student name// Ask the user for the student name
     //            //Console.Write("Enter grade: ");
     //            // Because the user might enter n non-numeri grade causing an exception
     //            // We should handle the exception so the program doesn't end
     //            //    with a message that will*/ scare the human
                // We can use a try/catch to handle the exception
                // When the user enters a non-numeric grade:
                //      1. ignore it and keep going - We are doing this
                //                                    don't put student in dictionary
                //      2. Give them another chance to enter it
                //      3. Set the grade to 0

                // We need to define grade outside any block so it can be used by all code
//                 double grade =/* 0;
//                 string userGrade = "";
//                 List<double> grades = new List<double>();
//                 try {  // A statement inside this try block might cause an exception
//                     // We need to get multiple grades for each student and store themin a List
//                     string whatTheyTyped = "";
//                     while (whatTheyTyped != "end") // Loop until the user enter "end"
//                     {
//                         Console.Write("Enter grade or end: ");
//                         // Get the user input as a string in case we need it later
//                         whatTheyTyped = Console.ReadLine();
//                         if (whatTheyTyped == "end")
//                         {
//                             break; // exit the loop - continue would be OK too
//                         }
//                         grade = Double.Parse(whatTheyTyped); // convert the user input to number
//                         grades.Add(grade); // Add the grade entered to list
//                     }
//                     // at then end of this look the grades list has all the grade
//                 }
//                 catch (FormatException exceptionObject) // if it throws a FormatException ...
//                 {
//                     Console.WriteLine("The data you entered ("+ userGrade + ") is not a valid number");
//                     Console.WriteLine("The data is ignored");
//                     // Skip adding the student to the dictionary 
//                     continue;  // skip the rest of the loop processing
//                 }
//
//                 // Add the data to our Dictionary only if we have a valid grade
//                 // Dictionary[key}     = value;
//                 gradeBook[studentName] = grades; // adding the list of grades for the student
//                 // We need to find out if they have more students to enter
//                 // We want to be sure they only enter responses we expect
//                 // Loop until we get a valid response...
//                 // for-loop - Do we know how many times we want to loop? NO
//                 // while    - Do we loop based on a condition? YES - Can we loop 0 times? - NO
//                 // do-while - Do we loop based on a condition? YES - Do we need loop at least once? - YES
//                 do
//                 {
//                     Console.WriteLine("Are you done? (y/n)");
//                     // Get a response from the user and convert to lowercase 
//                     userResponse = Console.ReadLine().ToLower();
//                     // We are checking userResponse AFTER we get it from the user
//                 } while (userResponse != "y" && userResponse != "n");
//                 
//             } while (userResponse != "y");  // Loop while they are not done (done == "y")*/
            
    
    
}