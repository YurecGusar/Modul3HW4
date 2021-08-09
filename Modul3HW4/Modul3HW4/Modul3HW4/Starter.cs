using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    public class Starter
    {
        private Class1 _delegatTask = new Class1();
        private Class2 _linqTask = new Class2();
        public void Run()
        {
            _delegatTask.RunTask();
            Console.WriteLine();
            _linqTask.RunTask();
        }
    }
}
