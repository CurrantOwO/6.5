using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { -21, -22, 23, 45, 27, 367, 232, -245, 35943, 989 };
            int a;
            for (int i = 0; i < 5; i++) {
                a = num.Count / 2;
                num.Insert(a, 0);
            }
            num.RemoveAt(0);
            num.RemoveAt(num.Count - 1);
            for(int i = 0; i < num.Count; i++) { Console.Write(num[i]+"\t"); }
        }
    }
}
