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
    }
}
