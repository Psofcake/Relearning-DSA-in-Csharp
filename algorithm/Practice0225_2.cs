using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithm
{
    internal class Practice0225_2
    {
        //연결 리스트를 뒤집는 메서드 작성해보기
        /*static void Main(string[] args)
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.Add(1);
            myLinkedList.Add(2);
            myLinkedList.Add(3);
            myLinkedList.Add(4);
            myLinkedList.Add(5);
            Console.WriteLine("Original List : ");
            myLinkedList.Display();

            myLinkedList.Reverse();
            Console.WriteLine("Reversed List : ");
            myLinkedList.Display();
        }*/
    }

    public class Node   // 링크드 리스트의 각 노드
    {
        public int Data;
        public Node Next;

        public Node(int data) 
        {
            Data = data;
            Next = null;
        }
    }

    public class MyLinkedList   // 연결 리스트
    {
        public Node Head;
        public void Add(int data)   // Add기능 만들기
        {
            // 새 노드 생성
            Node newNode = new Node(data);

            //헤드가 비어있는 경우 헤드 = 새 노드
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            //헤드부터 마지막 노드까지 탐색, 마지막 노드의 Next에 새 노드 삽입
            Node current = Head;
            while (current.Next != null) { 
                current = current.Next;
            }
            current.Next = newNode;
        }

        public void Reverse()   // 연결 리스트 뒤집기
        {
            Node prev = null;
            Node current = Head;
            Node next = null;

            while (current != null)
            {
                next = current.Next; // next에 현재 노드가 가리키던 다음 노드를 임시 저장
                current.Next = prev; // current가 prev를 가리키도록 연결
                prev = current; // prev에 현재 노드 저장
                current = next; // 다음 노드로 이동해서 작업 반복
            }
            Head = prev;
        }
        public void Display()
        {
            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Data+" ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

}
