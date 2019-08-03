using System.Collections.Generic;
using Shouldly;
using Xunit;

namespace HandsOn.Algorithms.LinkedLists
{
    public class DeleteDuplicatesFromListTests
    {

        [Fact]
        public void should_remove_duplicates_from_list()
        {
            var myList = new List<int> { 1, 2, 2, 3 };
            var result = DeleteDuplicatesFromList.DeleteDuplicates(myList);
            result.Count.ShouldBe(3);
        }

        [Fact]
        public void should_remove_duplicates_from_list_no_removal()
        {
            var myList = new List<int> { 1, 2, 4, 3 };
            var result = DeleteDuplicatesFromList.DeleteDuplicates(myList);
            result.Count.ShouldBe(4);
        }

    }
}