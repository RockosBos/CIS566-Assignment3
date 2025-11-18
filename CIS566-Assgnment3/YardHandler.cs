using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS566_Assgnment3
{
    internal class YardHandler : ConversionHandler
    {
        public YardHandler(String conversion, double input)
        {
            if (conversion == "Yards")
            {
                result = input * 1093.61;
            }
            else
            {
                successor = new FeetHandler(conversion, input);
                result = successor.getResult();
            }
        }
    }
}
