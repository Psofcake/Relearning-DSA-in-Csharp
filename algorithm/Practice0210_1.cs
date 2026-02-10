using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class Practice0210_1
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number.");
            int number = Convert.ToInt32(Console.ReadLine()); //입력된 값을 숫자로 변환
            bool isPrime = PrimeCheck(number);  //숫자가 소수인지 확인
            Console.WriteLine(number+(isPrime?" is a prime number.":" is not a prime number."));
        }*/
        static bool PrimeCheck(int number) {
            if(number <=1) return false; //1 이하는 소수가 아님.
            for(int i = 2; i<=Math.Sqrt(number); i++)
            {
                //2부터 그 숫자의 제곱근까지의 모든 정수로 나누어 소수성을 확인.
                if(number%i==0) return false; //나머지가 없으면 약수가 존재하므로 소수가 아님.
            }
            return true;
        }
    }
}
