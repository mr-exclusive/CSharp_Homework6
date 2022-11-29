// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double k, double b) GetCoeffForLineEquation()
{
    Console.WriteLine("Enter coefficients for a line: ");
    Console.Write("k = ");
    double k = double.Parse(Console.ReadLine());

    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());

    return (k: k, b: b);
}

void FindIntersectionOf2Lines((double k, double b) coeff1, (double k, double b) coeff2)
{
    if (coeff1.k == coeff2.k)
    {
        if (coeff1.b == coeff2.b)
        {
            Console.WriteLine("The lines match.");
        }
        else
        {
            Console.WriteLine("The lines are parallel.");
        }
    }
    else
    {
        double intersectX =  (coeff2.b - coeff1.b) / (coeff1.k - coeff2.k);
        double intersectY = coeff1.k * intersectX + coeff1.b;

        Console.WriteLine($"The lines intersect at the point ({intersectX}, {intersectY}).");
    }
}

Console.Clear();

(double k, double b) coeff1 = GetCoeffForLineEquation();
Console.WriteLine($"First line y = {coeff1.k} * x + {coeff1.b}");

Console.WriteLine();

(double k, double b) coeff2 = GetCoeffForLineEquation();
Console.WriteLine($"Second line y = {coeff2.k} * x + {coeff2.b}");

Console.WriteLine();

FindIntersectionOf2Lines(coeff1, coeff2);