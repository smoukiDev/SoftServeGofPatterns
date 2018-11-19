using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class Context
    {
        private string stringInput;
        private int input;
        private string output;
        private bool isValid = false;

        public Context(string inputValue)
        {
            this.stringInput = inputValue;
        }

        public int Input
        {
            get
            {
                return this.input;
            }
        }

        public string Output
        {
            get
            {
                return this.output;
            }
            set
            {
                this.output = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return this.isValid;
            }
        }

        public bool ValidateInput(string inputValue)
        {
            if(int.TryParse(inputValue, out this.input))
            {
                if (this.input >= 100 || this.input <= 999)
                {
                    isValid = true;
                    return true;
                }
                else
                {
                    isValid = false;
                    return false;
                }
            }
            else
            {
                isValid = true;
                return false;
            }
        }
    }
}
