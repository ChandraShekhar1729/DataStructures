using DSA.Chandrashekhar;
using DSA.Shayamli;

namespace DSA.Test
{
    class Program
    {
        static void Main(string[] args)
        {   
            // These Two instances will be always there as there are used to create the instances of the console Projects
            Functions chandu = new Functions();
            Function shayamli = new Function();

            Console.WriteLine(shayamli.getRandomNum());
        }
    }
}