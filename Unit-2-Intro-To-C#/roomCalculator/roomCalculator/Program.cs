using Console = System.Console;

namespace roomCalculator;

class Program
{
    static void Main(string[] args)
    {

        double userLengthInput = 0;
        double userWidthInput = 0;
        double roomArea = 0;
        double roomPerimeter = 0;
        double userInputHeight = 0;
        double roomVolume = 0;
        double floorCeilingArea = 0;
        double wallArea = 0;
        double totalSurfaceArea = 0;
        Console.WriteLine("Start of App");
        Console.WriteLine("Welcome to ClassRoom Calculator");
        Console.WriteLine("Enter Length");
        userLengthInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You Entered" + " "+ userLengthInput);
        Console.WriteLine("\n Enter Width");
        userWidthInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You Entered" + " " + userWidthInput );
        Console.WriteLine("\n Enter Height");
        userInputHeight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("You Entered" + " " + userInputHeight );
        if (roomArea <= 250)
        {
            roomArea = userWidthInput * userLengthInput;
            Console.WriteLine("Your ClassRoom Square footage is" +" "+ roomArea);
        
            roomPerimeter = userLengthInput * 4;
            Console.WriteLine("Your ClassRoom Perimeter is" +" "+ roomPerimeter);
            
            roomVolume = userWidthInput * userLengthInput * userInputHeight;
            Console.WriteLine("Your ClassRoom Volume is" +" "+ roomVolume);
            
            floorCeilingArea = 2 * (userWidthInput * userLengthInput);
            wallArea = 2 * (userWidthInput * userLengthInput) + 2 * (userWidthInput * userLengthInput);
            totalSurfaceArea = wallArea + floorCeilingArea;
            Console.WriteLine("Your ClassRoom Surface Size is" +" "+ totalSurfaceArea);
            
            Console.WriteLine("You have a small room size");

        }if(roomArea>250 && roomArea <= 650){
            roomArea = userWidthInput * userLengthInput;
            Console.WriteLine("Your ClassRoom Square footage is" +" "+ roomArea);
        
            roomPerimeter = userLengthInput * 4;
            Console.WriteLine("Your ClassRoom Perimeter is" +" "+ roomPerimeter);
            
            roomVolume = userWidthInput * userLengthInput * userInputHeight;
            Console.WriteLine("Your ClassRoom Volume is" +" "+ roomVolume);
            
            floorCeilingArea = 2 * (userWidthInput * userLengthInput);
            wallArea = 2 * (userWidthInput * userLengthInput) + 2 * (userWidthInput * userLengthInput);
            totalSurfaceArea = wallArea + floorCeilingArea;
            Console.WriteLine("Your ClassRoom Surface Size is" +" "+ totalSurfaceArea);
            
            Console.WriteLine("You have a medium room size");
        }else if (roomArea > 650)
        {
            roomArea = userWidthInput * userLengthInput;
            Console.WriteLine("Your ClassRoom Square footage is" +" "+ roomArea);
        
            roomPerimeter = userLengthInput * 4;
            Console.WriteLine("Your ClassRoom Perimeter is" +" "+ roomPerimeter);
            
            roomVolume = userWidthInput * userLengthInput * userInputHeight;
            Console.WriteLine("Your ClassRoom Volume is" +" "+ roomVolume);
            
            floorCeilingArea = 2 * (userWidthInput * userLengthInput);
            wallArea = 2 * (userWidthInput * userLengthInput) + 2 * (userWidthInput * userLengthInput);
            totalSurfaceArea = wallArea + floorCeilingArea;
            Console.WriteLine("Your ClassRoom Surface Size is" +" "+ totalSurfaceArea);
            
            Console.WriteLine("You have a large room size");
            
        }
















        Console.WriteLine("End of App");
    }
}