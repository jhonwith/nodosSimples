using System;

namespace NodosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList ml =new MyList();
            ml.Add("HOla");
            ml.Add("HOla");
            ml.Add("HOla");
            Console.WriteLine(ml.PrintList());   
        }
    }
}