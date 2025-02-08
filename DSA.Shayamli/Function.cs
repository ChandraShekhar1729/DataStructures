namespace DSA.Shayamli
{
    public class Function
    {
        public int getRandomNum()
        {
            var Random = new Random();
            return  Random.Next(1, 100);
        }
    }
}
