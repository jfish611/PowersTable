using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont)
            {
                Console.WriteLine("Please enter an integer (between 1-1289)\n\n");
                int input = int.Parse(Console.ReadLine());
                if (input > 0 && input < 1290)
                {

                    Console.WriteLine(" Number\t\tSquared\t\tCubed");
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write("=");
                        }
                        Console.Write("\t\t");
                    }

                    Console.WriteLine();
                    for (int k = 1; k <= input; k++)
                    {
                        int sqrd = k * k;
                        int cubed = sqrd * k;
                        //Console.WriteLine(String.Format($"{2,5}{2,5}{2,5}",{k} ))
                        Console.WriteLine($"{k,7}\t\t{sqrd,7}\t\t{cubed,7}");
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid number. Try again.");
                    continue;
                }

                Console.WriteLine("Enter 'X' to exit, otherwise any button to continue.");
                if (Console.ReadLine().ToLower() == "x")
                {
                    cont = false;
                }
                
            }
          
        }
    }
}
