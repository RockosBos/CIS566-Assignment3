using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS566_Assgnment3
{
    internal class FeetHandler : ConversionHandler
    {
        public FeetHandler(String conversion, double input)
        {
            if (conversion == "Feet")
            {
                result = input * 3280.84;
            }
            else
            {
                result = input;
            }
        }
    }
}
