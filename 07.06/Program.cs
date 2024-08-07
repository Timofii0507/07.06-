using System;
using System.Text;
using System.Threading;

namespace system2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Thread numberThread = new Thread(PrintNumbers);


            numberThread.Start();


            numberThread.Join();

            Console.WriteLine("Всі числа виведено.");
        }

        static void PrintNumbers()
        {
            for (int i = 0; i <= 50; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
    }
}