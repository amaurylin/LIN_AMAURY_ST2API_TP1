using System;

namespace tp1
{
    class Exo
    {

        //Exercice 1.1
        public void Multiplication()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)

                {
                    Console.Write(i * j + "\t");

                }

                Console.Write("\n");
            }

        }



        //Exercice 1.2
        public void Odd()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)

                {
                    if (i * j % 2 != 0)
                    {
                        Console.Write(i * j + "\t");
                    }

                }

                Console.Write("\n");
            }
        }



        //Exercice 1.3
        public void AskUserForParameter()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            for (int i = 1; i <=  10; i ++)
            {
                Console.Write(i * result + "\t");
            }
        }



        //Exercice 2.1
        public void Prime()
        {
            for (int x = 2; x < 10000; x++)
            {
                int isPrime = 0;
                for (int y = 1; y < x; y++)
                {
                    if (x % y == 0)
                    {
                        isPrime++;
                    }

                    if (isPrime == 2) break;
                }

                if (isPrime != 2)
                {
                    Console.WriteLine(x);
                }

            }
        }



        //Exercice 2.2
        public static int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }


 
        //Exercice 2.3
        public static int Factorial(int n)
        {
            int result = 1;
            for (int i=1; i <= n; i++)
            {
                result = result * i;
            }

            Console.Write(result);
            return result;

        }



        //Exercice 3
        private static int PowerFunction(int n)
        {
            try
            {
                int res = 0;
                int ten = 10;
                for (int x = 3; x > -3; x--)
                {
                    res = ten / x;
                }
            }

            catch(DivideByZeroException e)
            {
                Console.Write("division par 0 impossible",e);
            }

            return (int)(Math.Pow(n, 2) - 4);
            }



        //Exercice 4.1
        public void Rectangle()
        {
            Console.WriteLine("Enter row:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your column:");
            int m = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {
                    if ((j==1 || j==m) && (i==1 || i ==n))
                    {
                        Console.Write("0");
                    }
                    else if (j==1 || j == m)
                    {
                        Console.Write("|");
                    }
                    else if (i==1 || i== n)
                    {
                        Console.Write("-");
                    }
                    else { Console.Write(" "); }
                   
                   
                }
                Console.WriteLine();
                
            }
        }

        //Exercice 4.2
        public void Rectangle2(int n, int m)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= m; j++)
                {

                    if ((i == 1 || i == n) && (j == 1 || j == m))
                    {
                        Console.Write("0");
                    }
                    else if (i == 1 || i == n)
                    {
                        Console.Write("-");
                    }
                    else if (j == 1 || j == m)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        if (((i - 2) - (j + 1)) % 3 == 0)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");

                        }
                    }

                }
                Console.WriteLine();
            }
        }


        //Exercice 5
        
        public void ChrismasTree()
        {
            int spaces = 15;
            int asterix = 1;
            int center = spaces ;

            for (int i = 1; i <= spaces; i++)
            {
                int indent = spaces - i;
                
                for (int j = 1; j <= indent; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= asterix; j++)
                {
                
                    Console.Write("*");
                
             
                }
                Console.WriteLine();
                asterix = asterix +2;
          
            }
            for(int i = 0; i < 1; i++)
            {
                for (int j = 1; j <= center; j++)
                {
                    if(j==center)
                    {
                        Console.WriteLine("||");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }


        static void Main( String[] args)
        {
            Exo d = new Exo();
            //      1.1
            //d.Multiplication();

            //      1.2
            //d.Odd();

            //      1.3
            //d.AskUserForParameter();

            //      2.1
            //d.Prime();
                
            //      2.2
            //Console.Write(Fib(4));

            //      2.3
            //Factorial(4);
            //Factorial(6);
            //                  c. it was too much
            //                  d. its a function that call himself

            //      3
            //PowerFunction(3);

            //      4.1         We ask user to enter number of row and column, that's why the question 
            //                  "what does a (1,5); (4,1); (5,7) or (3,3) rectangle look like?" is not printed, user must enter himself 
            //d.Rectangle();
 

            //      4.2
            //d.Rectangle2(6, 9);

            d.ChrismasTree();

        }
    }
}
