namespace StringExamples;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start of app");
        //
        // strings in C# are a special data type - they don't work like you think they should
        //
        //string literals are enclosed in ""
        //if (condition) {
        //what to do if condition is true
        //}
        //else{
        //what to do if candition is false
        //}
        // string variables sometimes requires special processing
        // you can't use <> to compare strings
        //
        //
        //C# provides several methos to operate on strings:
        //
        //.equals(string) - compare the string to left the . to string inside()
        // . compareTo(string) - return a number indicating how the first string relates to the second
        //
        //                          return a negative number if the first string is less than the second 
        //                           return a zero if the first string is equal 2 the second 
        //                           return a positive number if the first string is greater than the second 
        
        
        
        

        string string1 = "a";
        string string2 = "a";
        
        Console.WriteLine(string1);
        Console.WriteLine(string2);
        
        if (string1.CompareTo(string2) > 0)
        {

            Console.WriteLine("string 1 is greater than string 2");
        }
        else
        {
            Console.WriteLine("String 1 is not greater than  string 2");

        }
    
        
        if (string1.CompareTo(string2) == 0)
        {

            Console.WriteLine("String 1 is not equal to string 2");
        }
        else
        {
            Console.WriteLine("String 1 is  greater than  string 2");

        }





    }//end of main
}// end of class program