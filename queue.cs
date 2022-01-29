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
			strQ.Enqueue("F");
			strQ.Enqueue("a");
			strQ.Enqueue("i");
			strQ.Enqueue("z");
			strQ.Enqueue("a");
			strQ.Enqueue("n");

			Console.WriteLine("Total elements: {0}", strQ.Count);

			while (strQ.Count > 0)
				Console.WriteLine(strQ.Dequeue());

			Console.WriteLine("Total elements: {0}", strQ.Count);



			//peek()//
			Console.WriteLine("  ");
			Console.WriteLine("  ");
			Console.WriteLine("  ");
			Console.WriteLine(" THIS IS PEEK METHOD ");

			strQ.Enqueue("F");
			strQ.Enqueue("a");
			strQ.Enqueue("i");
			strQ.Enqueue("z");
			strQ.Enqueue("a");
			strQ.Enqueue("n");

			Console.WriteLine("Total elements: {0}", strQ.Count); 
			if (strQ.Count > 0)
			{
				Console.WriteLine(strQ.Peek()); 
				
			}

			Console.WriteLine("Total elements: {0}", strQ.Count); 
		}
	}
}