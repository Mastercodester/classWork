using System.Collections;
using System.Xml.Schema;

namespace CarsandUsedCarsLab;

public class Car
{
    private string make = "";
    private string model = "";
    private int year = 0;
    private decimal price = 0;

    
    public  string Make { get => make; set => make = value; }
    
    public  string Model { get => model; set => model = value; }
    public  int Year { get => year; set => year = value; }
    public  decimal Price { get => price; set => price = value; }

    public Car()
    {
    }

    public Car(string make, string model, int year, decimal price)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.price = price;
    }



    public void ListCars(List<Car> cars)
    {
/*
 * Add a public static method to Car called ListCars that loops through the list and prints out each member
 * and its index in the list.
 * (Hint: Use a regular for loop, not a foreach loop so you  can print out the index.)
   
 */       
        
        
        
       /*Car nc = new Car(Make, Model, Year, Price);
        for(var item in  nc)
        {
            Console.WriteLine($"{Make}", $"{Model}", $"{Year}", $"{Price}");
        }*/


       for (int i = 0; i < cars.Count; i++)
       {
          string carMake = cars[i].Make;
          string carModel = cars[i].Model;
          string carYear = cars[i].Year.ToString();
          string carPrice = cars[i].Price.ToString();
           Console.WriteLine(carMake);
           Console.WriteLine(carModel);
           Console.WriteLine(carYear);
           Console.WriteLine(carPrice);
       }
       

   
}



    public void RemoveCars(List<Car> cars, int removeindex)
    {
        cars.RemoveAt(removeindex);
        
        Console.WriteLine("cars removed" + removeindex);
    }



    public override string ToString()
    {
        return base.ToString();
    }
}