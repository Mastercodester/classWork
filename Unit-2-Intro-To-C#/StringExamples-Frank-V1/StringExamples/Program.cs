namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        /***************************************************************************************************
         * Strings in C# are a special data type - they don't work like you think they should
         *
         * String literals are enclosed in " "
         *
         * A literal is something that says what it is:  1 1.24 "Bob"
         *
         * string variables sometimes require special processing
         *        you can't use < > to compare strings
         *        Beware: Early versions of C# do not allow use of == with strings
         *
         * C# provides several methods to operate on strings:
         *
         * a method is a program that process data in an object/variable
         *    .equals(string) - compare the string to left of the . to string inside () for equals
         *     .CompareTo(string) - return a number indicating how the first string relates to the second
         *                          return a negative number if first string is less than the second
         *                          return a zero if first string is equal the second
         *                          return a positive number if first string is greater than the second
         ***************************************************************************************************/
        // if (condition) {
        //    What to do if condition is true
        // }
        // else {
        //    What to do if condition is false
        // }
        string string1 = "a";
        string string2 = "b";
        
        Console.WriteLine("string1 is: " + string1);
        Console.WriteLine("string2 is: " + string2);
        
        if (string1.CompareTo(string2) > 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is greater than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT greater than string2");
        }
        if (string1.CompareTo(string2) < 0) // if the first string is greater than second string
        {
            Console.WriteLine("string1 is less than string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT less than string2");
        }
        if (string1.CompareTo(string2) == 0) // if the first string is equal second string
        {
            Console.WriteLine("string1 is equal string2");
        }
        else
        {
            Console.WriteLine("string1 is NOT equal string2");

            string sentence = "my name is frank";
            Console.WriteLine("there are" + sentence.Length + "characters");
            
            bool contains = sentence.Contains("frank");// true if the sentence contains frank
            Console.WriteLine("DOes sentence contains Frank:" + contains);
            Console.WriteLine("DOes sentence contains Frank:" + sentence.Contains("Marquise"));

            string nameInSentence = sentence.Substring(11, 5);
            Console.WriteLine("Name is:" + nameInSentence);
            
            Console.WriteLine("does the sentnces starts with the word MY " + sentence.StartsWith("My"));
            Console.WriteLine("does the sentnces starts with the word my " + sentence.StartsWith("my"));
            Console.WriteLine("does the sentnces end with the word C# " + sentence.StartsWith("C#"));
            
            
            Console.WriteLine("result when sentence.trim is used");
            
            Console.WriteLine("does the sentnces starts with the word MY " + sentence.StartsWith("My"));
            Console.WriteLine("does the sentnces starts with the word my " + sentence.StartsWith("my"));
            Console.WriteLine("does the sentnces end with the word C# " + sentence.StartsWith("C#"));
        }
        // Some methods that process strings
        // to see a list of all methods available to an object - just type objectName.
        //.Length - returns the number of characters in a string
        //.contains(string)- returns true if the string given is inside the string u are looking at
        // .substring(starting index, length) extract characters from the string strtating at the start index
        //                                      for the numbers of characters indicated by the length
        // Start index starts at zero not 1
        //                          whenever you see the word position thats when it starts  counting at 1
        //
        // .startsWith(string) - retunr true if string starts with chars (case senstive)
        // .endsWith(string) - retunr true if string ends with chars (case senstive)
        //. trim() - remove any leading or trailing spaces 
        //
        //
        
        
    } // End of Main()
}  // End of class Program