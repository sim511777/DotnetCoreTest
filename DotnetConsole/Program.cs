using System;
using System.Linq;

namespace DotnetConsole {
    class Program {
        static void Main (string[] args) {
            foreach (var jul in Enumerable.Range(1, 9)) {
                foreach (var dan in Enumerable.Range(2, 8)) {
                    System.Console.Write("{0}*{1}={2,2} ", dan, jul, dan * jul);
                }
                System.Console.WriteLine();
            }
        }
    }
}