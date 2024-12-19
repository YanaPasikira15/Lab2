using System;

class Point
{
    // Поля класу
    private double x;    // Координата X
    private double y;    // Координата Y
    private string name; // Назва точки
    public Point(double x, double y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }
    public double X
    {
        get { return x; }
    }
    public double Y
    {
        get { return y; }
    }
    public string Name
    {
        get { return name; }
    }
}

class Figure
{
    private Point[] points; // Масив точок для багатокутника
    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 }; // Трикутник
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 }; // Чотирикутник
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 }; // П'ятикутник
    }
    // Метод для обчислення довжини сторони
    private double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2)); 
    }
    // Метод для обчислення периметра
    public double CalculatePerimeter()
    {
        double perimeter = 0;

        for (int i = 0; i < points.Length; i++)
        {
            perimeter += GetSideLength(points[i], points[(i + 1) % points.Length]);
        }

        return perimeter; // Повертаємо загальний периметр
    }
    public string GetName()
    {
        return $"Багатокутник з {points.Length} сторонами"; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення точок
        Point point1 = new Point(0, 0, "A");
        Point point2 = new Point(0, 5, "B");
        Point point3 = new Point(5, 5, "C");
        Point point4 = new Point(5, 0, "D");
        Point point5 = new Point(2.5, 2.5, "E"); 
        Figure triangle = new Figure(point1, point2, point3);
        Figure quadrilateral = new Figure(point1, point2, point3, point4);
        Figure pentagon = new Figure(point1, point2, point3, point4, point5);
        // Обчислення та виведення периметрів
        Console.WriteLine($"{triangle.GetName()}: Периметр = {triangle.CalculatePerimeter()}");
        Console.WriteLine($"{quadrilateral.GetName()}: Периметр = {quadrilateral.CalculatePerimeter()}");
        Console.WriteLine($"{pentagon.GetName()}: Периметр = {pentagon.CalculatePerimeter()}");
    }
}
