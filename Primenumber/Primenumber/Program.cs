using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime number from 1 to 1000 :\n");

            for (int i = 2; i <= 1000; i++)
            {
                bool isPrimeNumber = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }

                }
                if (isPrimeNumber)
                {

                    Console.WriteLine(i + "  ");
                }
            }
        }
    }
}