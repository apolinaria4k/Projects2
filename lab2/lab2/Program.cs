using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            new B().FuncQuadEqua(1, -34, 43);
        }
    }

    class A
    {
        private float[] x;
        public float[] X { get => x; set => x = value; }
        public float[] FuncLineEqua(float arg1, float arg2)
        {
            if (arg1 != 0)
            {
                x = new float[] { (-1 * arg2) / arg1 };
                return x;
            }
            else
            {
                return null;
            }
        }

    }

    class B : A
    {
        public float[] FuncQuadEqua(float arg1, float arg2, float arg3)
        {
            if (arg1 != 0)
            {
                float D = disc(arg1, arg2, arg3);
                if (D >= 0)
                {
                    X = new float[]
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
