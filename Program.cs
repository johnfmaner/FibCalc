namespace FibCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            int n; // Nth value of Fib Sequence 

            // get user's input, prompt again if the input isn't between 1-73 
            do
            {
                Console.WriteLine("Provide the Nth number of the Fibonacci sequence you'd like, between 1-73: ");

                string inputNumber = "1";
                inputNumber = Console.ReadLine();

                // catch bad input exceptions  
                try
                {
                    n = int.Parse(inputNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine("'{0}' cannot be parsed as a number.", inputNumber);
                    Console.WriteLine("Provide the Nth number of the Fibonacci sequence you'd like, between 1-73: ");
                    inputNumber = Console.ReadLine();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The input number is too large.");
                    Console.WriteLine("Provide the Nth number of the Fibonacci sequence you'd like, between 1-73: ");
                    inputNumber = Console.ReadLine();
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("The input number is too large.");
                    Console.WriteLine("Provide the Nth number of the Fibonacci sequence you'd like, between 1-73: "); 
                    inputNumber = Console.ReadLine();
                }
                finally
                {
                    n = int.Parse(inputNumber);
                }

            }
            while (n < 0 || n > 73); 


            // now calculate the nth value 
            long final = 1; // can only store up to n=73, otherwise rolls over to negative 

            {
                if (n != 1 || n != 2) // compute for non trivial values of n 
                { 
                    int index = 3;
                    long nMinusOne = 1;
                    long nMinusTwo = 1;

                    while (index <= n) // case for n>= 3 
                    {
                        final = nMinusOne + nMinusTwo;
                        nMinusTwo = nMinusOne;
                        nMinusOne = final;
                        index++;
                    }
                }
                else // handle base cases of n=1 or n=2, since these are always 1 
                {
                    final = 1; 
                }
            }

            // show the user 
            Console.WriteLine("Here you are, the {0}th value of the Fibonacci sequence is: {1} ", n,final);
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
    }
}