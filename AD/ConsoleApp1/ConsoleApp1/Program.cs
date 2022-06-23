using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MessageBox.Show("all done!");
            Console.Title = "App";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************");
            Console.WriteLine("****Hello yall*******");
            Console.WriteLine("*********************");
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ReadLine();
        }
    }
}
