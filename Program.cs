using System;


namespace MagicSquare
{
    class Program
    {
       
        static void Main(string[] args)
        {
            const int field_sz = 25;
            const int x_sz = field_sz;
            const int y_sz = field_sz;

            Magic1 m = new Magic1(field_sz);
            for (int y = 0; y < y_sz; y++)
            {
                for (int x = 0; x < x_sz; x++)
                {
                    if ( m.spell_21(x, y) )
                    {
                        Console.Write("#");
                    }
                    else {
                        Console.Write(".");
                    }
                   
                }
                Console.WriteLine();
            }
        }
    }
}
