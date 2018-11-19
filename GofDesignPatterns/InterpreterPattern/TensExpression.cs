using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class TensExpression : IExression
    {
        public void Interpret(Context context)
        {
            if (context.IsValid)
            {
                int tens = context.Input % 100;
                tens = tens / 10;
                // TODO: change on dictionary and enums
                context.Output += " ";
                switch (tens)
                {
                    case 1:
                        context.Output += "One Ten and";
                        break;
                    case 2:
                        context.Output += "Twenty";
                        break;
                    case 3:
                        context.Output += "Thirty";
                        break;
                    case 4:
                        context.Output += "Forty";
                        break;
                    case 5:
                        context.Output += "Fifty";
                        break;
                    case 6:
                        context.Output += "Sixty";
                        break;
                    case 7:
                        context.Output += "Seventy";
                        break;
                    case 8:
                        context.Output += "Eighty";
                        break;
                    case 9:
                        context.Output += "Ninety";
                        break;
                    default:
                        context.Output += String.Empty;
                        break;
                }
            }
        }
    }
}
