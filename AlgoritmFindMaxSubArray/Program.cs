using System;
using System.Collections.Generic;


namespace AlgoritmFindMaxSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new MaxSubArray();
            var subArray= result.FindMaxSubArray(new int[]{ -5, 20, -4, 10, -18 });
            foreach (var n in subArray)
            {
                Console.Write(n+" ");
            }
        }        
    }
    public class MaxSubArray
    {
        int minIndex = 0;
        int maxIndex = 0; 
        int maxSum = 0;
        int checkAllMinus = 0;
        
        public  List<int> FindMaxSubArray(int[] array)
        {
            checkAllMinus = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                checkAllMinus = array[i] > checkAllMinus ? array[i]:checkAllMinus;
                int sum = 0;
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        minIndex = i;
                        maxIndex = j;
                    }
                }
            }
            var resultList = new List<int>();
            if (checkAllMinus < 0) 
                resultList.Add(checkAllMinus);            
            else            
                for (int i = minIndex; i <= maxIndex; i++)
                    resultList.Add(array[i]);

            return resultList;
        }
    }
}
