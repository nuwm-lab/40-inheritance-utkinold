using System;

class Triangle
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public double A1 { get; set; }
    public double B1 { get; set; }
    public double C1 { get; set; }
    public void InputSides()
    {
        Console.WriteLine("Введіть сторону a (усі сторони рівні):");
        A = double.Parse(Console.ReadLine());
        B = A;
        C = A;


        A1 = B1 = C1 = 60;
    }


    public void Perimeter()
    {
        double P = A + B + C;
        Console.WriteLine($"Периметр трикутника: {P}");
    }


    class Triangle1 : Triangle
    {
        public double angle { get; set; }


        public void InputSide1()
        {
            Console.WriteLine("Введіть сторону a:");
            A = double.Parse(Console.ReadLine());
        }

        public void InputAngle1()
        {
            Console.WriteLine("Введіть перший кут (A1):");
            A1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть другий кут (B1):");
            B1 = double.Parse(Console.ReadLine());

            C1 = 180 - (A1 + B1);
        }


        public void CalculateOtherSides()
        {
            double radA = A1 * Math.PI / 180;
            double radB = B1 * Math.PI / 180;
            double radC = C1 * Math.PI / 180;

            B = A * Math.Sin(radB) / Math.Sin(radA);
            C = A * Math.Sin(radC) / Math.Sin(radA);
        }


        public void Perimeter1()
        {
            double P = A + B + C;
            Console.WriteLine($"Периметр трикутника: {P}");
        }

        public void DisplayInfo1()
        {
            Console.WriteLine($"Сторони: a={A}, b={B}, c={C}");
            Console.WriteLine($"Кути: A={A1}, B={B1}, C={C1}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Рівносторонній трикутник ===");
            Triangle t1 = new Triangle();
            t1.InputSides();
            t1.Perimeter();

            Console.WriteLine("\n=== Трикутник із заданою стороною і двома кутами ===");
            Triangle1 t2 = new Triangle1();
            t2.InputSide1();
            t2.InputAngle1();
            t2.CalculateOtherSides();
            t2.DisplayInfo1();
            t2.Perimeter1();
        }
    }
}
