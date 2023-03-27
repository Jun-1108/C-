using System;

namespace Stack
{
    public class App
    {
        public static void Main()
        {
            Stack stack = new Stack(10);

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            var data = stack.Pop();
            System.Console.WriteLine(data);
            data = stack.Pop();
            System.Console.WriteLine(data);
            data = stack.Pop();
            System.Console.WriteLine(data);
            data = stack.Pop();
            System.Console.WriteLine(data);

        }
    }
}

namespace Stack
{
    public class Stack
    {
        private int[] arr;
        private int top;

        public Stack(int size)
        {
            this.arr = new int[size];
            this.top = -1;
        }

        public void Push(int data)
        {
            if (this.IsFull())
            {
                throw new ApplicationException("Stack is Full");
            }
            else
            {
                this.arr[++top] = data;
            }
        }

        public int Pop()
        {
            int rtnData = -1;
            if (this.IsEmpty())
            {
                throw new ApplicationException("Stack is Empty");
            }
            else
            {

                rtnData = this.arr[this.top];
                this.arr[this.top] = 0;
                this.top--;
            }
            return rtnData;
        }

        public int Peek()
        {
            if (this.IsEmpty())
            {
                throw new ApplicationException("Stack is Empty");
            }
            else
            {
                return this.arr[this.top];
            }
        }

        public bool IsFull()
        {
            return this.top == this.arr.Length - 1;
        }

        public bool IsEmpty()
        {
            return this.top == -1;
        }
    }
}
