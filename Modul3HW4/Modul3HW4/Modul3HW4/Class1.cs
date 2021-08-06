using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class Class1
    {
        public Func<int, int, int> SumDelHandler { get; set; }

        public int SumOfSums(int a, int b)
        {
            var result = 0;
            var sumDelList = SumDelHandler.GetInvocationList();
            foreach (var item in sumDelList)
            {
                if (item != null)
                {
                    var test = item as Func<int, int, int>;
                    result += test.Invoke(a, b);
                }
            }

            return result;
        }
    }
}
