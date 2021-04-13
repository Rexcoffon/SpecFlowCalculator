using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public Calculator()
        {
            Operands = new List<int>();
        }

        public List<int> Operands { get; set; }

        public string Add()
        {

            int? result = null;
            foreach (var item in Operands)
            {
                if (result.HasValue)
                {
                    result += item;
                }
                else
                {
                    result = item;
                }
            }

            return result.ToString();
        }

        public string Sub()
        {
            int? result = null;
            foreach (var item in Operands)
            {
                if (result.HasValue)
                {
                    result -= item;
                }
                else
                {
                    result = item;
                }
            }

            return result.ToString();
        }

        public string Multi()
        {
            int? result = null;
            foreach (var item in Operands)
            {
                if (result.HasValue)
                {
                    result *= item;
                }
                else
                {
                    result = item;
                }
                
            }
            return result.ToString(); ;
        }

        public string Div()
        {
            string result;
            try
            {
                int? divVar = null;
                foreach (var item in Operands)
                {
                    if(divVar.HasValue)
                    {
                        divVar /= item;
                    }
                    else
                    {
                        divVar = item;
                    }
                    
                }
                result = divVar.ToString();
            }
            catch (DivideByZeroException)
            {
                result = "Impossible de diviser par 0";
            }

            return result.ToString();
        }
    }
}
