using System;

namespace netcorecrasher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World for non-root!");
            // throw new Exception("Testing managed crash.");
            System.Runtime.InteropServices.Marshal.ReadInt32(IntPtr.Zero);
        }
    }
}
