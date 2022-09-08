//Напишите программу, которая принимает на вход координаты двух точек и
//находит расстояние между ними в 3D пространстве.

//A (3,6,8); B(2, 1, -7), -> 15.84

//A(7, -5, 0); B(1, -1, 9)-> 11.53


namespace Task_2
{
    internal class Program
    {
        static double GetDistanceBetweenTwoPoint3D(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2)); // квадратный корень, возведение в степень
            return distance;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите значение X1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Z1");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение X2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение Z2");
            int z2 = Convert.ToInt32(Console.ReadLine());

            double result = GetDistanceBetweenTwoPoint3D(x1, y1, z1, x2, y2, z2);
            Console.WriteLine($"Расстояние между точками({x1}, {y1}, {z1} и {x2}, {y2}, {z2}) равно {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}"); // округление
        }
    }
}