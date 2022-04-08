using System;


namespace ConsoleApp8
{
    public delegate string Hell(string name);
    class SomeClass
    {
        public string SayHello(string s)
        {
            return $"Привет, {s}!";
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClass = new SomeClass();
            Hell hD = new Hell(someClass.SayHello);
            Console.WriteLine(hD("Вася"));
            Console.ReadKey();
        }
    }
}
