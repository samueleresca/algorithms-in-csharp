using System;

namespace HandsOn.Algorithms.Top10
{
    public class MyStack<T>
    {
        private StackNode<T> top;

        public T Pop()
        {
            if (top == null) throw new Exception("Stack empty");
            T item = top.Data;
            top = top.Next;

            return item;
        }

        public void Push(T data)
        {
            StackNode<T> newNode = new StackNode<T>(data) { Next = top };
            top = newNode;
        }

        public T Peek()
        {
            if (top == null) throw new Exception("Stack empty");
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }

    public class StackNode<T>
    {
        public T Data;

        public StackNode<T> Next;

        public StackNode(T data)
        {
            Data = data;
        }
    }
}