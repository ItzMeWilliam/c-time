using System;
using System.Threading;

class MainClass {
    public static void Main (string[] args) {
        while (true) {
            Console.Clear();
            Console.Write(DateTime.Now.ToString("hh:mm:ss"));
            Thread.Sleep(1000);
        }
    }
}