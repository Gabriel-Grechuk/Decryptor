using System;
//using System.Text;

namespace DecryptIO
{
    // Class to manage console output.
    class IO
    {
        public static void Print(string str)
        {
            Console.Write(str);
        }

        public static void Println(string str)
        {
            Console.WriteLine(str);
        }

        public static void Error(string str)
        {
            Console.WriteLine("[ERROR] " + str);
        }

        public static void Success(string str)
        {
            Console.WriteLine("[OK] " + str);
        }
    }
}
