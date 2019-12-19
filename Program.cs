using System;


namespace UserInput__CS
{
    class Program
    {
        static void Main(string[] args)
        {
            String X;
            
            Console.Write("Masukkan Input Kalimat : ");
            X = Console.ReadLine();
            Console.WriteLine("\nAnda Menulis = '{0}'\n\n", X);

            Console.ReadLine();
        }
    }
}
