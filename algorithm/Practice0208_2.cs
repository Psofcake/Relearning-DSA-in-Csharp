using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class Practice0208_2
    {
        /*static void Main(string[] args)
        {
            int[] numbers = { 1,3,5,7,9 };
            int max = FindMaximum(numbers); //정수 배열에서 최대 숫자 찾기
            Console.WriteLine(max);
        }*/
        static int FindMaximum(int[] numbers) 
        {
            int max = numbers[0];
            
            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i]>max) max = numbers[i];
            }

            //foreach (int number in numbers) { if (number > max) max = number; } 위와 동일
            return max;
        }
    }
}
