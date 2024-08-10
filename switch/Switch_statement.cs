// See https://aka.ms/new-console-template for more information
namespace using_switch
{
    public class Switch_statement
    {
        public void Calc(int n, int a, int b)
        {
            if (n == 0)
            {
                Console.WriteLine("0 is not a valid option");
            }
            else
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine($"{a} + {b} = {a + b} ");
                        break;
                    case 2:
                        Console.WriteLine($"{a} - {b} = {a - b}" );
                        break;
                    case 3:
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"{a} * {b} = {a / b}");
                        break;
                    default:
                        Console.WriteLine("choose a valid option");
                        break;
                }
            }
        }
    }
}
