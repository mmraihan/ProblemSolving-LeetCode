using System.Diagnostics.Metrics;
using System.Numerics;
using System.Threading.Tasks;

namespace boolean
{
    #region Return true
    public class Program
    {
        static void Main(string[] args)
        {
            int x = 5; int y = 3;

            var result = CheckCondition(x, y);
            Console.WriteLine(result);

        }

        static bool CheckCondition(int x, int y)
        {
            return x > y;
        }
    }
    #endregion


}
   
    