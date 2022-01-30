using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace While
{
    class conditional
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter the Number Between 1 to 7");
            day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine(".....Monday.....");
                    break;
                case 2:
                    Console.WriteLine(".....Tuesday.....");
                    break;
                case 3:
                    Console.WriteLine(".....Wednesday.....");
                    break;
                case 4:
                    Console.WriteLine(".....Thursday.....");
                    break;
                case 5:
                    Console.WriteLine(".....Friday.....");
                    break;
                case 6:
                    Console.WriteLine(".....Saturday.....");
                    break;
                case 7:
                    Console.WriteLine(".....Sunday.....");
                    break;
            }
        }
    }
}
//////////////////////////////////////////////////////////////////////////
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Queuecollection
{
	public class Program
	{
		public static void Main(string[] args)
		{

			Queue<string> strQ = new Queue<string>();
			strQ.Enqueue("M");
			strQ.Enqueue("u");
			strQ.Enqueue("s");
			strQ.Enqueue("t");
			strQ.Enqueue("a");
			strQ.Enqueue("f");
			strQ.Enqueue("a");

			Console.WriteLine("Total elements: {0}", strQ.Count);

			while (strQ.Count > 0)
				Console.WriteLine(strQ.Dequeue());

			Console.WriteLine("Total elements: {0}", strQ.Count);



			//peek()//
			Console.WriteLine("  ");
			Console.WriteLine("  ");
			Console.WriteLine("  ");
			Console.WriteLine(" THIS IS PEEK METHOD ");
            strQ.Enqueue("M");
			strQ.Enqueue("u");
			strQ.Enqueue("s");
			strQ.Enqueue("t");
			strQ.Enqueue("a");
			strQ.Enqueue("f");
			strQ.Enqueue("a");

			Console.WriteLine("Total elements: {0}", strQ.Count); 
			if (strQ.Count > 0)
			{
				Console.WriteLine(strQ.Peek()); 
				
			}

			Console.WriteLine("Total elements: {0}", strQ.Count); 
		}
	}
}