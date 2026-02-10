using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class Practice0210_2
    {
        /*static void Main(string[] args)
        {
            int[] array = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSort(array);
            Console.WriteLine("Sorted array : "+string.Join(", ", array));
        }*/

        // string.Join(", ",array)의 기능
        // : 컬렉션의 요소들을 지정한 구분자로 연결해 하나의 문자열로 만들어주는 C# 표준 메서드.
        
        // 배열,리스트 등의 값들을 하나의 문자열로 합치되, 지정한 구분자를 끼워 만든다.
        // → array의 값들을 문자열로 변환, 각 값 사이에 ", " 넣음
        // 하나의 문자열 "11, 12, 22, 25, 34, 64, 90"로 만들어 반환



        // 버블 정렬 알고리즘을 사용하여 배열을 정렬하기.
        static void BubbleSort(int[] arr) {
            int temp;
            int length = arr.Length;
            for (int i=0; i<length-1; i++)
            {
                for (int j = 0; j < length-i-1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
        }
    }
}
