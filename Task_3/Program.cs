// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3-> 1, 8, 27
// 5-> 1, 8, 27, 64, 125

namespace Task_3
{
    internal class Program
    {
        static int[] GetCubeNumber(int number)
        {
            int[] squaresNumbers = new int[number];

            for (int i = 1; i <= number; i++) 
            {
                squaresNumbers[i - 1] = i * i * i;
            }
            return squaresNumbers;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int num = int.Parse(Console.ReadLine());

            int[] result = GetCubeNumber(num);
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}