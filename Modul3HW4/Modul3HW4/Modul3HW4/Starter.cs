using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class Starter
    {
        private int _res;
        public void Run()
        {
            var task2 = new LINQTest();
            task2.LINQStart();
            var class1 = new Class1();
            class1.SumDelHandler += Sum;
            class1.SumDelHandler += Sum;
            MyTryCach(() => _res = class1.SumOfSums(2, 2));
            Console.WriteLine(_res);
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void MyTryCach(Action del)
        {
            try
            {
                del.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
