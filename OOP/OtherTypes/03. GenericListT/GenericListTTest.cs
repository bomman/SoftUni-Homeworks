using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GenericListT
{
    class GenericListTTest
    {
        static void Main()
        {
            GenericListT<string> list = new GenericListT<string>(6);
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Remove(2);
            list.Add("6");
            list.Insert("5", 3);
            list.Add("DoubleUp");          
            Console.WriteLine(list.ElementAt(2));       
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list);
            Console.WriteLine(list.IndexOf("5"));
            Console.WriteLine(list.Contains("2"));

            var attribute = list.GetType().GetCustomAttributes(typeof(VersionAttribute),false);
            Console.WriteLine("Version: {0}",attribute[0]);
        }
    }
}
