namespace CarsandUsedCarsLab;

public class UsedCar : Car
{
    private double mileage = 0.0;


    public double Mileage
    {
        get => mileage;
        set => mileage = value;
    }





    public UsedCar(double mileage)
    {
        this.mileage = mileage;
    }

    public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
    {
        this.mileage = mileage;
        Make = make;
        Model = model;
        Year = year;
        Price = price;
        
    }

    
    
    public override string ToString()
    {
        return base.ToString();
    }
}