namespace Circle_Objects;

public class Circle
{
    private double radius;


    public Circle(double radius)
    {
    }



    public double CalculateDiameter()
    {

        return radius * 2;
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public double CalculateArea()
    {
       double pow = 2 * radius;
       return pow;
    }

    public void Grow()
    {
    }

    public double GetRadius()
    {
        return radius;
    }
}