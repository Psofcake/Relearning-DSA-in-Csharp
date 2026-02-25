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
                for (int j = 0; j < arr.Length-i-1; j++) {
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
        // ★ j의 범위를 arr.Length -i -1로 하는 이유
        // 한 바퀴 (i = 0)를 돌면
        //→ 가장 큰 값이 맨 뒤로 이동해서 자리가 확정됨

        // 두 바퀴(i = 1)를 돌면
        //→ 뒤에서 두 번째 값도 확정됨
        //…

        //즉, i번 반복 후에는 뒤쪽 i개의 값은 이미 정렬 완료되어있으므로
        //이미 확정된 영역을 건너뛰기 위해 -i를 한다.


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

        //병합 정렬 : 작은 그룹으로 나누고 정렬한 뒤, 다시 병합 O(n log n)
        internal static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right) return;

            int mid=(left+right)/2;
                
            MergeSort(arr,left, mid);
            MergeSort(arr, mid+1, right);
            Merge(arr, left, mid, right);
        }
        internal static void Merge(int[] arr, int left, int mid, int right)
        {
            int[] temp = new int[right - left + 1];

            int i = left;
            int j = mid + 1;
            int k = 0;

            while (i <= mid && j <= right)
            {
                if (arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }
            while (i<= mid) temp[k++] = arr[i++];
            while (j<= right) temp[k++]= arr[j++];

            for(int t=0; t<temp.Length; t++) arr[left+t]=temp[t];
        }
        
        /*static void Main(string[] args)
        {
            int[] arr = { 5, 3, 8, 4, 2 };

            MergeSort(arr, 0, arr.Length - 1);
            Console.Write(string.Join(" ", arr));
        }*/
    }
}
