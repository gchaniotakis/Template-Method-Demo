using System;

namespace TemplateMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var cornbread = new Cornbread();
            cornbread.Make();

            var dinkel = new Dinkel();
            dinkel.Make();

            Console.Read();
        }
    }
}