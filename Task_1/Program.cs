//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет

//12821 -> да

//23432 -> да


namespace Task_1
{
    internal class Program
    {
        public static bool Palindrome(int[] arr)
        {
            int begin = 0;
            int end = arr.Length - 1;
            bool result = true;
            while(result)
            {
                result = arr[begin] == arr[end];
                begin++;
                end--;
                if (begin >= arr.Length - 1 || end <= 0) break;
                if(!result) break;
            }
            return result;
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Write numbers for Palindrome test: ");
                string str = Console.ReadLine();      

                int[] array = new int[str.Length];
                for (int i = 0; i < str.Length; i++)
                {
                    array[i] = (int)char.GetNumericValue(str[i]);
                    Console.WriteLine(array[i]);
                }
                
                if (!Palindrome(array)) Console.Write("This is MADNESS (NOT PALINDROME)");
                else Console.WriteLine("This is SPARTA! (PALINDROME)");
                       
                break;
            }
        }
    }
}