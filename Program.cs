namespace recursive_function
{
    public class Recursive
    {

        public static void Main(string[] args)
        {

            factorial();



            /* Console.WriteLine("Enter the nth Fibonacci number: ");
            int n = int.Parse(Console.ReadLine());

             Console.WriteLine("The nth Fibonacci number is: {0}", Fib(n));

            Console.WriteLine("The Fibonacci series up to the nth number is:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0} ", Fib(i));
            }
            Console.WriteLine();*/
            
        }
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

        static void factorial()
        {
            int fact = 1;
            Console.WriteLine("Enter the number that you want to calculte it is factorial :");
            int Num =int.Parse(Console.ReadLine());
            for (int i = Num;i>=1;i--)
            {
                fact =fact * i;
            }

            Console.WriteLine(" The factorial of " + Num + "! = " + fact);
        }

    }
}