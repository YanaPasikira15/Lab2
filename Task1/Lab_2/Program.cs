using System;

class Rectangle
{
    // Поля класу
    private double side1;
    private double side2;
    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    // Метод для обчислення площі
    public double CalculateArea()
    {
        return side1 * side2;
    }

    // Метод для обчислення периметра
    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }
    public double Area
    {
        get { return CalculateArea(); }
    }
    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Запит довжини сторін
        Console.Write("Введіть довжину першої сторони: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введіть довжину другої сторони: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(side1, side2);

        // Виведення результатів
        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");
    }
}
