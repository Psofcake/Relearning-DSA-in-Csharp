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

        //퀵정렬 : 피벗을 이용한 분할 정복 전략, 평균 O(n log n)
        //left는 정렬을 시작할 첫 인덱스(0), right는 정렬을 끝낼 마지막 인덱스(arr.Length-1)를 넣는다. 부분 정렬도 가능
        internal void QuickSort(int[] arr, int left, int right) 
        {
            int i=left, j=right;
            int pivot = arr[(left + right) / 2]; //가운데 피벗을 사용

            while (i <= j) //i가 계속 증가, j가 계속 감소해서 i보다 작아지면 중단
            {
                while (arr[i] < pivot) i++; //피벗보다 큰 값을 찾을때까지 i가 증가.
                while (arr[j] > pivot) j--; //피벗보다 작은 값을 찾을때까지 j 감소.

                if (i <= j)
                {
                    // 양쪽의 요소를 서로 교환
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;

                    //다음 요소 검사
                    i++; 
                    j--;
                }
            }

            // 재귀 호출
            if (left < j)
                QuickSort(arr, left, j);
            if (i < right)
                QuickSort(arr, i, right);
        }
    }
}
