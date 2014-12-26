using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList newList = new ArrayList();
            
            Console.WriteLine("Size of ArrayList: " +newList.Count);

            Console.WriteLine("Trying to add values... ");

            newList.Add(5);

            int count = newList.Count;

            Console.WriteLine(newList[0]);

            Console.ReadKey();
        }
    }
}
