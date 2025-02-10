using System.Reflection.Metadata.Ecma335;

namespace DSA.Chandrashekhar
{
    public class Functions
    {
        // Method to find the max and Min in an Array

        public int[] FindMinAndMax(int[] arr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            foreach( var item in arr)
            {
                if (item > max)
                {
                    max = item;
                }
                if (item < min)
                {
                    min = item;
                }
            }
            return new int[] { min, max };
        }  
        
        // Find the second largest and smallest number in an array 
        //public int[]? FindSecMinAndMax(int[] arr)
        //{
        //   if(arr.Length<=1) { return arr; }
        //     int max = int.MinValue;
        //    int min = int.MaxValue;
        //    int secMax = int.MinValue;
        //    int secMin = int.MaxValue;
        //    foreach( var item in arr)
        //    {
        //        if()
        //    }
        //}

        // Reverse the arraay

        public int[] ReversedArray(int[] arr)
        {
            if (arr.Length <= 1) { return arr; }
            int startIndex = 0;
            int EndIndex = arr.Length - 1;

            foreach( var item in arr)
            {
                int temp = arr[startIndex];
                arr[startIndex] = arr[EndIndex];
                arr[EndIndex] = temp;
                startIndex++;
                EndIndex--;
            }
            return arr;
        }
    }
}
