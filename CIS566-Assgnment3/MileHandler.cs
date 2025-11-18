using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS566_Assgnment3
{
    internal class MileHandler : ConversionHandler
    {

        public MileHandler(String conversion, double input)
        {
            if(conversion == "Miles")
            {
                result = input * 0.621371;
            }
            else 
            { 
                successor = new YardHandler(conversion, input);
                result = successor.getResult();
            }
        }
    }
}
