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