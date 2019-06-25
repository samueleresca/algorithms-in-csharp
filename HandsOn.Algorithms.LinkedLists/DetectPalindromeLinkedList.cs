using System.Collections.Generic;

namespace HandsOn.Algorithms.LinkedLists
{
    public class DetectPalindromeLinkedList
    {

        public static bool IsPalindrome(MyLinkedListNode<int> head)
        {
            var result = cloneAndReverse(head);
            return isEqual<int>(result, head);
        }


        private static MyLinkedListNode<T> cloneAndReverse<T>(MyLinkedListNode<T> n)
        {
            MyLinkedListNode<T> head = null;
            while (n != null)
            {
                var clonedNode = new MyLinkedListNode<T> { Value = n.Value, Next = head };
                head = clonedNode;
                n = n.Next;
            }

            return head;
        }

        private static bool isEqual<T>(MyLinkedListNode<T> n1, MyLinkedListNode<T> n2)
        {
            while (n1 != null && n2 != null)
            {
                if (!n1.Value.Equals(n2.Value))
                {
                    return false;
                }

                n1 = n1.Next;
                n2 = n2.Next;
            }

            return n1 == null && n2 == null;
        }
    }


    public class MyLinkedListNode<T>
    {
        public T Value;
        public MyLinkedListNode<T> Next;
    }
}