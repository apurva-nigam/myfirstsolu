using System;
namespace MyFirstConsoleApp
{
    class Demo
    {
        private int temp;
        public int Num1
        {
            set
            {
                this.temp = value;
            }
            get
            {
                return this.temp; 
            }
        }
    }
    internal class Constructor
    {
        static void Main(string[]args)
        {
            Demo obj = new Demo();
            obj.Num1 = 100;
            Console.WriteLine(obj.Num1);
        }
    }
}
