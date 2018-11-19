using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class HundredExpression : IExression
    {
        
        public void Interpret(Context context)
        {
            if (context.IsValid)
            {
                int hundreds = context.Input / 100;
                // TODO: change on dictionary and enums
                switch (hundreds)
                {
                    case 1:
                        context.Output += "One Hundred";
                        break;
                    case 2:
                        context.Output += "Two Hundred";
                        break;
                    case 3:
                        context.Output += "Three Hundred";
                        break;
                    case 4:
                        context.Output += "Four Hundred";
                        break;
                    case 5:
                        context.Output += "Five Hundred";
                        break;
                    case 6:
                        context.Output += "Six Hundred";
                        break;
                    case 7:
                        context.Output += "Seven Hundred";
                        break;
                    case 8:
                        context.Output += "Eight Hundred";
                        break;
                    case 9:
                        context.Output += "Nine Hundred";
                        break;
                    default:
                        context.Output += string.Empty;
                        break;
                }
            }
        }
    }
}
