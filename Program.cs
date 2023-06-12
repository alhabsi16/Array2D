namespace aaaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculate();
            Average();

        }

        static void calculate()
        {
            int sum = 0;
            int[,] my2D = new int[3, 2];
            my2D[0, 0] = 5;
            my2D[0, 1] = 8;
            my2D[1, 0] = 10;
            my2D[1, 1] = 11;
            my2D[2, 0] = 20;
            my2D[2, 1] = 21;

            //Console.WriteLine(my2D.Length);

            for (int raw = 0; raw < my2D.GetLength(0); raw++)
            {
                for (int col = 0; col < my2D.GetLength(1); col++)
                {
                    //Console.Write(my2D[raw, col] + "  ");
                    sum = sum + my2D[raw, col];

                }

            }
            Console.WriteLine(" Total sum = " + sum);
            Console.WriteLine();
        }

        static void Average()
        {
           
            int[,] my2D = new int[3, 2];
            my2D[0, 0] = 5;
            my2D[0, 1] = 8;
            my2D[1, 0] = 10;
            my2D[1, 1] = 11;
            my2D[2, 0] = 20;
            my2D[2, 1] = 21;

            //Console.WriteLine(my2D.Length);

            for (int raw = 0; raw < my2D.GetLength(0); raw++)
            {
                float sum = 0;
                int count = 0;

                for (int col = 0; col < my2D.GetLength(1); col++)
                {
                    //Console.Write(my2D[raw, col] + "  ");
                    sum = sum + my2D[raw, col];
                    count++;
                   
                }
                float Average = sum / count;
                Console.WriteLine(" Average = " + Average);
            }
        }
    }
}