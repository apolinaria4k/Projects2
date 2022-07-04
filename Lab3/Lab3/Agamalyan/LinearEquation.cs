using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agamalyan
{
    class LinearEquation
    {
        private List<float> x;
        public List<float> X { get => x; set => x = value; }
        public List<float> FuncLineEqua(float arg1, float arg2)
        {
            if (arg1 != 0)
            {
                x = new List<float> { (-1 * arg2) / arg1 };
                return x;
            }
            else
            {
                return null;
            }
        }
    }
}
