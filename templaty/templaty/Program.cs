using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace templaty
{
    class Program
    {
        List<Action> arr = new List<Action>();

        void Main(string[] args)
        {

        }
        void foo<T>(T t)
        {
            arr.Add(() => { t; });
        }
        void foo2()
        {

        }
        void foo3(int i)
        {

        }
    }
}
