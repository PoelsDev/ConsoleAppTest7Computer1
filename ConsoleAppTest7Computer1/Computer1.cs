using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest7Computer1
{
    class Computer1
    {
        private int a;
        private int b;
        private int resultaat;
        public int Resultaat
        {
            get { return resultaat; }
        }       

        public Computer1(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Som()
        {
            resultaat = a + b;
        }

        public void Verschil()
        {
            resultaat = a - b;
        }

        public void Product()
        {
            resultaat = a * b;
        }
    }
}
