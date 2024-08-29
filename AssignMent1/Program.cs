using System;

public class Rectangle
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

   
    public double CalculateArea()
    {
        return length * width;
    }
}

public class Square
{
    private double side;

    
    public Square(double side)
    {
        this.side = side;
    }

        public double CalculateArea()
    {
        return side * side;
    }
}

class Program
{
    static void Main()
    {
        
        Rectangle rect = new Rectangle(15, 13);
        Console.WriteLine("Area of the rectangle: " + rect.CalculateArea());

        
        Square sq = new Square(5);
        Console.WriteLine("Area of the square: " + sq.CalculateArea());
    }
}
