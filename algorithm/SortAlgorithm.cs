using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class SortAlgorithm
    {
        //버블정렬 : i회차 정렬 n번, j위치의 요소 검사 n번 → O(n^2) 시간복잡도
        internal void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++) {
                for (int j = 0; j < arr.Length-1; j++) {
                    if (arr[j] > arr[j + 1]) //오름차순 정렬 시 조건
                    {
                        //인접 요소의 값을 서로 교환
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
