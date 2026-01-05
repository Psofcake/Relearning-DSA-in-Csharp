using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class SearchAlgorithm
    {
        // 선형 탐색 (순차적으로 배열 요소를 확인)
        internal int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target) //타겟과 일치하는 요소를 찾으면 해당 인덱스를 반환.
                    return i;
            }
            return -1; // 없으면 -1 반환
        }

        // 이진 탐색 (정렬된 배열에서 사용★★★, 탐색 간격을 반복적으로 반으로 나누어 효율적임.)
        internal int BinarySearch(int[] arr, int target) // [0]3, [1]4, [2]5, [3]6 [4]7
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right) { 
                int mid = left + (right-left)/ 2;

                if (arr[mid] == target)
                    return mid; // 값을 찾으면 반환
                if(arr[mid] < target)
                    left = mid + 1; // 타겟이 중앙값보다 크면 중앙값+1부터 뒤쪽까지 재탐색
                else
                    right = mid - 1; //타겟이 중앙값보다 작으면 앞쪽부터 중앙값-1까지 재탐색
            }
            return -1; // 없으면 -1 반환
        }
    }
}
