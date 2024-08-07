using System;
using System.Text;
using System.Threading;

namespace _07._06
{ 
    class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.CursorVisible = false;
        Console.Write("Введіть початок діапазону: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Введіть кінець діапазону: ");
        int end = int.Parse(Console.ReadLine());


        Thread numberThread = new Thread(() => PrintNumbers(start, end));


        numberThread.Start(); 


        numberThread.Join();

        Console.WriteLine("Всі числа виведено.");
    }

    static void PrintNumbers(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(100);
        }
    }
}
}