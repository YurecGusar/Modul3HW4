using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class Class1
    {
        public Func<int, int, int> SumAction { get; set; }
        public void RunTask()
        {
            SumAction += (x, y) => x + y;
            SumAction += (x, y) => x + y;
            var totalSum = 0;

            MyTryCach(() => totalSum = GetTotalSum(2, 2));

            Console.WriteLine(totalSum);
        }

        private int GetTotalSum(int a, int b)
        {
            var sum = SumAction.GetInvocationList();
            var result = 0;
            foreach (var item in sum)
            {
                var newItem = (Func<int, int, int>)item;
                result += newItem.Invoke(a, b);
            }

            return result;
        }

        private void MyTryCach(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
