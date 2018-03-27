using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest7Computer1
{
    class Computer2
    {
        private int a;
        private int b;
        private int resultaat;

        public Computer2(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Som()
        {
            resultaat = a + b;
            return resultaat;
        }

        public int Verschil()
        {
            resultaat = a - b;
            return resultaat;
        }

        public int Product()
        {
            resultaat = a * b;
            return resultaat;
        }
    }
}
