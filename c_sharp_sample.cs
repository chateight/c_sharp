using System;
using System.Collections.Generic;

namespace start_projekt202104
{
    class Program
    {
        static void Main(string[] args)
        {
            Sub ins = new Sub();
            ins.Print(ins.Calc(16));

        }
    }

    interface Inf
    {
        public void Print(string[] strg);
    }

    abstract class Base
        {
        internal List<string> int_list = new List<string>();
        public abstract string[] Calc(int a);
        }

    class Sub : Base, Inf
    {
        internal string[] array;
        public override string[] Calc(int a)
        {
            for (int x = 1; x <= a; x++)
            {
                int_list.Add(x.ToString() + " sqr : " + (x * x).ToString());
            }
            array = int_list.ToArray();
            return array;
        }

        public void Print(string[] str)
        {
            for (int index = 0; index < array.Length; index++)
            {
               Console.WriteLine(str[index]);
            }
        }
    }
}
