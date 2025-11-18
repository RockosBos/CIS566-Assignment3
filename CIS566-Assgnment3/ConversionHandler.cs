using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS566_Assgnment3
{
    internal abstract class ConversionHandler
    {
        protected ConversionHandler successor;
        protected double result;

        void setSucessor(ConversionHandler successor)
        {
            this.successor = successor;
        }

        public double getResult()
        {
            return result;
        }

    }
}
