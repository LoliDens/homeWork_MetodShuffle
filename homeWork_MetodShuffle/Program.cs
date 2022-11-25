using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_MetodShuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = new string[10] { "1", "2", "3", "4", "5", "6", "7","8","9","10" };
            Console.Write("Изначальный массив: ");
            PrintArray(numbers);

            ShuffleArray(numbers);
            Console.Write("\nПеремешаный массив: ");
            PrintArray(numbers);
            Console.ReadKey();
        }

        static void PrintArray(string[] array) 
        {
            for(int i = 0; i < array.Length; i++) 
            {
                Console.Write(array[i] + " ");
            }           
        }

        static void ShuffleArray(string[] array) 
        {
            Random random = new Random();
            string temporeryElement = "";

            for (int i = 0; i < array.Length; i++)
            {
                int randomIndex = random.Next(array.Length);
                temporeryElement = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = temporeryElement;
            }              
        }
    }
}
