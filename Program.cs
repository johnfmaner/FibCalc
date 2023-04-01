namespace FibCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            // get user's input 
            Console.WriteLine("Provide the Nth number of the Fibonacci sequence you'd like: ");
            string inputNumber = Console.ReadLine();

            int n; // Nth value of Fib Sequence 

            // catch bad inputs 
            try
            {
                n = int.Parse(inputNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("'{0}' cannot be parsed as a number.", inputNumber);
            }
            catch (OverflowException)
            {
                Console.WriteLine("The input number is too large.");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("The input number is too large.");
            }

            // parse input into an Int now that we know it's valid 
            n = int.Parse(inputNumber);

            // check that we don't have negatives 
            if (n < 0)
            {
                throw new Exception("Negative number is not allowed");
            }

            // now calculate the nth value 
            int final = 1;

            {
                if (n != 1 || n != 2) // compute for non trivial values of n 
                { 
                    int index = 3;
                    int nMinusOne = 1;
                    int nMinusTwo = 1;

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

            Console.WriteLine("Here you are, the {0}th value of the Fibonacci sequence is: {1} ", n,final);
            Console.WriteLine("Press any key to close the program...");
            Console.ReadKey();
        }
    }
}