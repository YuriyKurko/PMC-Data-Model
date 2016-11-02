using DLLProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Stopwatch stopWatch = new Stopwatch();

            while(true)
            {
                Console.WriteLine("Select example <1> or <2>");
                int exampleNumber = Convert.ToInt32(Console.ReadLine());

                switch (exampleNumber)
                {
                    case 1:
                        stopWatch.Start();
                        Example1();
                        stopWatch.Stop();
                        Console.WriteLine("Elapsed time: " + stopWatch.Elapsed);
                        break;
                    case 2:
                        stopWatch.Start();
                        Example2();
                        stopWatch.Stop();
                        Console.WriteLine("Elapsed time: " + stopWatch.Elapsed);
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please select 1 or 2.");
                        break;
                }

                stopWatch.Reset();
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }

        }

        static void Example1()
        {
            Random random = new Random();

            Console.WriteLine("Example 1");

            Containers<decimal> containers = new Containers<decimal>();
            for (int i = 0; i < 3; i++)
            {
                Container<decimal> container = new Container<decimal>();
                for (int j = 0; j < 2; j++)
                {
                    Matrix<decimal> matrix = new Matrix<decimal>();
                    if (j < 1)
                    {
                        for (int k = 0; k < 100; k++)
                        {
                            Position<decimal> position = new Position<decimal>();
                            if(k == 0)
                            {
                                for (int m = 0; m < 50; m++)
                                {
                                    position.Add(new Point2D<decimal>(random.Next(), random.Next()));
                                }
                                matrix.Add(position);
                            }
                            else if(k == 1)
                            {
                                for (int m = 0; m < 200; m++)
                                {
                                    position.Add(new Point2D<decimal>(random.Next(), random.Next()));
                                }
                                matrix.Add(position);
                            }
                            else
                            {
                                matrix.Add(position);
                            }
                        }
                    }
                    else
                    {
                        

                        for (int k = 0; k < 100; k++)
                        {
                            Position<decimal> position = new Position<decimal>();
                            if (k < 2)
                            {
                                for (int m = 0; m < 10; m++)
                                {
                                    position.Add(new Point1D<decimal>(random.Next()));
                                }
                                matrix.Add(position);
                            }
                            else
                            {
                                matrix.Add(position);
                            }

                        }
                    }
                    container.Add(matrix);
                }
                containers.Add(container);
            }

            Console.WriteLine(containers.PrintResult(containers));
        }

        static void Example2()
        {
            Random random = new Random();

            Console.WriteLine("Example 2");

            Containers<double> containers = new Containers<double>();
            for (int i = 0; i < 10; i++)
            {
                Container<double> container = new Container<double>();
                for (int j = 0; j < 10; j++)
                {
                    Matrix<double> matrix = new Matrix<double>();
                    if (j < 5)
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            Position<double> position = new Position<double>();
                            for (int m = 0; m < 5; m++)
                            {
                                position.Add(new Point2D<double>(Math.Round(random.NextDouble(),4), Math.Round(random.NextDouble(),4)));
                            }
                            matrix.Add(position);
                        }
                    }
                    else
                    {
                        for (int k = 0; k < 10; k++)
                        {
                            Position<double> position = new Position<double>();
                            for (int m = 0; m < 5; m++)
                            {
                                position.Add(new Point1D<double>(Math.Round(random.NextDouble(), 4)));
                            }
                            matrix.Add(position);
                        }
                    }
                    container.Add(matrix);
                }
                containers.Add(container);
            }
 
            Console.WriteLine(containers.PrintResult(containers));
        }
    }
}

