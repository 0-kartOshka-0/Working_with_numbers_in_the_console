using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_2
{
    
    class Program
    {
        static Random random = new Random();
        static void Decore()
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
        static int[] RandomArr(int size) // Функция для генерации случайного массива
        {
            
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(1, 25); // Генерация случайного числа от 1 до 100
            }
            return array;
        }
        static void Arr(int[] array) // Функция для вывода массива на экран
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static int Sum(int[] array)// Функция для нахождения суммы не кратных 5 элементов массива
        {
            int sum = 0;
            foreach (int num in array)
            {
                if (num % 5 != 0)
                {
                    sum += num;
                }
            }
            return sum;
        }
        static void Swap(ref int[] array)// Функция для обмена первой и второй половин массива
        {
            int temp;
            int mid = array.Length / 2;
            for (int i = 0; i < mid; i++)
            {
                temp = array[i];
                array[i] = array[mid + i];
                array[mid + i] = temp;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите размерность первого массива: ");
                int size1 = int.Parse(Console.ReadLine());
                Console.Write("Введите размерность второго массива: ");
                int size2 = int.Parse(Console.ReadLine());

                int[] arr1 = RandomArr(size1);
                int[] arr2 = RandomArr(size2);
                Decore();
                Console.WriteLine("Первый массив:");
                Arr(arr1);
                Console.WriteLine("Второй массив:");
                Arr(arr2);
                Decore();
                int sum1 = Sum(arr1);
                int sum2 = Sum(arr2);
                Console.WriteLine($"Сумма не кратных 5 элементов первого массива: {sum1}");
                Console.WriteLine($"Сумма не кратных 5 элементов второго массива: {sum2}");
                Decore();
                if (sum1 < sum2)
                {
                    Swap(ref arr1);
                }
                else
                {
                    Swap(ref arr2);
                }
                Console.WriteLine("Первый массив после обмена:");
                Arr(arr1);
                Console.WriteLine("Второй массив после обмена:");
                Arr(arr2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return;
            }
            Decore();
            Console.ReadLine();
        }
    }
}
