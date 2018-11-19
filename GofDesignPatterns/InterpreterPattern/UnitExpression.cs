using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class UnitExpression : IExression
    {
        public void Interpret(Context context)
        {
            if (context.IsValid)
            {
                int units = context.Input % 100;
                units = units % 10;
                // TODO: change on dictionary and enums
                context.Output += " ";
                switch (units)
                {
                    case 1:
                        context.Output += "One";
                        break;
                    case 2:
                        context.Output += "Two";
                        break;
                    case 3:
                        context.Output += "Three";
                        break;
                    case 4:
                        context.Output += "Four";
                        break;
                    case 5:
                        context.Output += "Five";
                        break;
                    case 6:
                        context.Output += "Six";
                        break;
                    case 7:
                        context.Output += "Seven";
                        break;
                    case 8:
                        context.Output += "Eight";
                        break;
                    case 9:
                        context.Output += "Nine";
                        break;
                    default:
                        context.Output += String.Empty;
                        break;
                }
            }
        }
    }
}
