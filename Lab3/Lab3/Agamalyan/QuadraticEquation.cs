using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using core;

namespace Agamalyan
{
    class QuadraticEquation : LinearEquation, EquationInterface
    {
        public List<float> solve(float arg1, float arg2, float arg3)
        {
            if (arg1 != 0)
            {
                float D = disc(arg1, arg2, arg3);
                if (D >= 0)
                {
                    X = new List<float>
                    {
                            (-arg2 + (float)Math.Sqrt(D)) / (2 * arg1),
                            (-arg2 - (float)Math.Sqrt(D)) / (2 * arg1)
                    };
                    return X;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return FuncLineEqua(arg2, arg3);
            }
        }
        protected float disc(float arg1, float arg2, float arg3)
        {
            return arg2 * arg2 - 4 * arg1 * arg3;
        }
    }
}
