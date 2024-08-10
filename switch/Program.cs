// See https://aka.ms/new-console-template for more information
namespace using_switch
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            int n, a, b;
            var c = new Switch_statement();
            Console.WriteLine("enter the value of a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("operations available :" +
                " 1. Addition " +
                "2. Subtraction " +
                "3. Multiplication " +
                "4. Division");
            n = int.Parse(Console.ReadLine());
            c.Calc(n, a, b);    
        }
    }
}
