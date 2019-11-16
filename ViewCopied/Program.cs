using System;
using System.Threading;
using System.IO;

namespace ViewCopied
{
    class Program
    {
        private static void ShowFile(string sourceFileName)
        {
            FileStream fs = new FileStream(sourceFileName, FileMode.Open);    //открытие для чтения
            StreamReader strread = new StreamReader(fs);

            var size = fs.Length;   //длина

            byte[] buf = new byte[1024];
            string str;

            while ( (str = strread.ReadLine() ) != null)
            {
                Console.WriteLine(str);
                Thread.Sleep(1000);
            }
            fs.Close();
        }
        static void Main(string[] args)
        {
            EventWaitHandle testEvent = new EventWaitHandle(false, EventResetMode.AutoReset, "testEvent");

            Console.WriteLine("Waiting Copy...");
            testEvent.WaitOne();

            string sourceFileName = "Z:\\os\\lab3\\testdest\\poka.txt";
            Console.WriteLine("Viewing file: " + sourceFileName);
            ShowFile(sourceFileName);
        }
        
    }
}
