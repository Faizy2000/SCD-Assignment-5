using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace collectionarray
{
    public class Program
    {
       

        public static void Main(string[] args)
        {
            ArrayList personList = new ArrayList();
            personList.Add("Faizan");
            personList.Add("Mustafa");
            personList.Add("Qamar");
            Console.WriteLine("=====Original List======");
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine(personList[i]);
            }
            personList.Insert(1, "Faizy");
            Console.WriteLine("=====Modify List======");
            for (int i = 0; i < personList.Count; i++)
            {
                Console.WriteLine(personList[i]);
            }
            Console.Read();
        }
    }
}
