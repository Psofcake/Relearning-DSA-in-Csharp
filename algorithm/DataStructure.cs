using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class DataStructure
    {
        //배열과 리스트의 차이
        /* 배열
         * 정적 크기 : 배열의 크기는 생성 후 고정되며 연속적인 메모리 위치에 저장
         * 0 기반 인덱싱 : 배열의 인덱스는 0부터 시작
         * 동종 요소 : 동일한 타입의 값만 담을 수 있다.
         */

        /* 리스트
         * 동적 크기 : 필요에 따라 크기가 늘거나 줄어들 수 있는 동적 배열
         * 전통적인 배열에 비해 더 많은 유연성 제공
         * 제네릭을 활용한 List<T> 클래스는 지정된 유형의 리스트를 생성할 수 있다.
         */
        
        static void Main(string[] args)
        {
            //배열
            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };

            //리스트
            List<int> numberList = new List<int> { 1,2,3,4,5 };
            numberList.Add(6);

            //딕셔너리
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                {"Alice", 36 }, {"Bob", 28 }
            };

            //스택
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            int top = stack.Pop(); // top==2

            //큐
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            int first = queue.Dequeue(); //first==1

            //집합(해시셋)
            HashSet<int> numberSet = new HashSet<int>();
            numberSet.Add(1);
            numberSet.Add(2);
            numberSet.Add(1); //동일한 값은 중복으로 추가되지 않음.(고유성이 중요한 경우 적합)
        }
    }
}
