using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class Practice0208_1
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            string input = Console.ReadLine();  //문자열 입력하기
            string output = ReverseStr(input);  //주어진 문자열 뒤집기
            Console.WriteLine(output);  //출력
        }*/

        static string ReverseStr(string str)
        {
            char[] CharArray = str.ToCharArray(); //문자 배열로 변환
            Array.Reverse(CharArray); //배열 뒤집기
            return new string(CharArray); //다시 문자열로 변환
        }
    }
}
