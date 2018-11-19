using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Enter a 3 digit number from 100 to 999");
            userInput = Console.ReadLine();

            Context context = new Context(userInput);
            if (context.ValidateInput(userInput))
            {
                List<IExression> tree = new List<IExression>();
                tree.Add(new HundredExpression());
                tree.Add(new TensExpression());
                tree.Add(new UnitExpression());

                foreach (IExression item in tree)
                {
                    item.Interpret(context);
                }

                Console.WriteLine($"Original Input {context.Input} is interpreted as {context.Output}");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            Console.ReadLine();
        }
    }
}
