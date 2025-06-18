namespace CarsandUsedCarsLab;

class Program
{
    
    
    public static List<Car> cars = new List<Car>();
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
    
        cars.Add(new Car() {Make= "Chevy",Model ="Malibu" , Price = 1700000 , Year = 2002});
        cars.Add( new Car(){Make = "Lexus", Model = "X2", Price = 1400000 , Year = 2014});
        cars.Add( new Car(){Make = "Tesla", Model = "S", Price = 1200000 , Year = 2019});
        cars.Add( new UsedCar(mileage:54242){Make = "Lexus", Model = "X2", Price = 1400000 , Year = 2014 });
        cars.Add( new UsedCar(mileage:69445){Make = "AppleCar", Model = "PearTop", Price = 2300000 , Year = 2029 });
        cars.Add( new UsedCar(mileage:23409){Make = "Gm", Model = "GMC Sierra truck", Price = 1400000 , Year = 2014 });
        Car mycar = new Car();
        
        mycar.ListCars(cars);

        mycar.RemoveCars(cars, 2);
    }
}