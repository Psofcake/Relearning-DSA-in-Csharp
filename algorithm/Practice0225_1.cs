using System;

namespace algorithm
{
    internal class Practice0225_1
    {
        //배열을 사용해 스택 구현하기. (푸시, 팝, 출력)
        /*static void Main(string[] args)
        {
            MyStack myStack = new MyStack(5);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Display();

            Console.WriteLine("Popped : "+myStack.Pop());
            myStack.Display();
        }*/
    }

    public class MyStack
    {
        private int[] arr;
        private int top;
        private int size;

        public MyStack(int size)
        {
            this.size = size;
            arr = new int[size];
            top = -1;
        }
        public void Push(int item) {
            if (top == size - 1) Console.WriteLine("Stack overflow");
            else arr[++top] = item;
        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }
            return arr[top--];
        }

        public void Display() {
            if (top == -1) { 
                Console.WriteLine("Stack is empty");
                return;
            }
            for (int i = top; i >= 0; i--) 
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
