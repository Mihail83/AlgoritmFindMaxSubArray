using System;
using Xunit;
using AlgoritmFindMaxSubArray;
using System.Collections.Generic;

namespace AlgoritmFindMaxSubArray.XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void FindMaxSubArray_PlusAndMinus()
        {
            var subArray = new MaxSubArray();

            var subArrayResult = subArray.FindMaxSubArray(new int[] { -5, 20, -4, 10, -18 });

            Assert.Equal<List<int>>(new List<int>{20,-4,10 }, subArrayResult);
        }

        [Fact]
        public void FindMaxSubArray_MinusOnly()
        {
            var subArray = new MaxSubArray();

            var subArrayResult = subArray.FindMaxSubArray(new int[] { -5, -20, -4, -10, -18 });

            Assert.Equal<List<int>>(new List<int> { -4 }, subArrayResult);
        }
        [Fact]
        public void FindMaxSubArray_PlusOnly()
        {
            var subArray = new MaxSubArray();

            var subArrayResult = subArray.FindMaxSubArray(new int[] { 5, 20, 4, 10, 18 });

            Assert.Equal<List<int>>(new List<int> { 5, 20, 4, 10, 18 }, subArrayResult);
        }

    }
}
