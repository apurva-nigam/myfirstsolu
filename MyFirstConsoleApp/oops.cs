using System;


namespace MyFirstConsoleApp
{
    class B
    {
        private int num1, num2, result;
        public void AcceptData(int n1,int n2)
        {
            num1 = n1;
            num2 = n2;
        }
        public void AddNumbers()
        {
            result =num1 + num2;
            Console.WriteLine("Sume of the numbers is {0}", result);
        }
    }
    internal class oops
    {
        static void Main(string[] args)
        {
            B obj = new B();
          //obj.AcceptData(10, 20);
            obj.AddNumbers();
        }
    }
}
