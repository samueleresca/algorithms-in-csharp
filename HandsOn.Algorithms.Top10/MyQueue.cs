using System;

namespace HandsOn.Algorithms.Top10
{
    public class MyQueue<T>
    {
        private QueueNode<T> firstAdded; // First item added
        private QueueNode<T> lastAdded; // Last item added to the que

        public void Add(T data)
        {
            if (lastAdded == null) throw new Exception("Queue empty");

            var newFirst = new QueueNode<T>(data);
            lastAdded.Next = newFirst;

            lastAdded = newFirst;

            if (firstAdded == null)
            {
                firstAdded = lastAdded;
            }
        }

        public T Remove()
        {
            if (firstAdded == null) throw new Exception("Queue empty");

            T data = firstAdded.Data;
            var next = firstAdded.Next;

            if (firstAdded == null)
            {
                lastAdded = null;
            }

            return data;
        }

        public T Peek()
        {
            if (firstAdded == null) throw new Exception("Queue empty");
            return firstAdded.Data;
        }

        public bool IsEmpty()
        {
            return firstAdded == null;
        }
    }

    public class QueueNode<T>
    {
        public T Data;

        public QueueNode<T> Next;

        public QueueNode(T data)
        {
            Data = data;
        }
    }
}