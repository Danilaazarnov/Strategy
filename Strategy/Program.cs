using System;

namespace strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Programming state = new Programming(4, "Программирование", new CSharp());
            state.style();
            state.ppstyle = new Cpp();
            state.style();

            Console.ReadLine();
        }
    }
    interface ppstyle
    {
        void style();
    }

    class CSharp : ppstyle
    {
        public void style()
        {
            Console.WriteLine("Программирование на C#");
        }
    }

    class Cpp : ppstyle
    {
        public void style()
        {
            Console.WriteLine("Программирование на C++");
        }
    }
    class Programming
    {
        protected int destiny;
        protected string type;

        public Programming(int num, string name, ppstyle kind)
        {
            this.destiny = num;
            this.type = name;
            ppstyle = kind;
        }
        public ppstyle ppstyle { private get; set; }
        public void style()
        {
            ppstyle.style();
        }
    }
}
