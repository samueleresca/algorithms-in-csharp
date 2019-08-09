using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.LinkedLists
{
    public class DetectPalindromeLinkedListTests
    {
        [Fact]
        public void should_detect_NOT_palindrome_list()
        {
            var node = new MyLinkedListNode<int>
            {
                Value = 2,
                Next = new MyLinkedListNode<int>
                {
                    Value = 4,
                    Next = new MyLinkedListNode<int> { Value = 3, Next = new MyLinkedListNode<int> { Value = 2 } }
                }
            };
            DetectPalindromeLinkedList.IsPalindrome(node).ShouldBeFalse();
        }

        [Fact]
        public void should_detect_palindrome_list()
        {
            var node = new MyLinkedListNode<int>
            {
                Value = 2,
                Next = new MyLinkedListNode<int>
                {
                    Value = 3,
                    Next = new MyLinkedListNode<int> { Value = 3, Next = new MyLinkedListNode<int> { Value = 2 } }
                }
            };
            DetectPalindromeLinkedList.IsPalindrome(node).ShouldBeTrue();
        }
    }
}