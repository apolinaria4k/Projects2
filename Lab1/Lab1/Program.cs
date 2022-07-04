using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        class A
        {
            private int sur;
            private int rus;

            public int getSur()
            {
                return sur;
            }
            public int getRus()
            {
                return rus;
            }
            public void setSur(int value)
            {
                sur = value;
            }
            public void setRus(int value)
            {
                rus = value;
            }
        }

        class B : A
        {
            public B (object a){
                this.a = a;
            }
            public object a;
        }

        class C: B
        {
            public C(object a, object b) : base(a)
            {
                this.b = b;
            } 
            public object b;
        }

        static void Main()
        {
            //A a1 = new A();
            //A a2 = new A();
            //B b4 = new B(a1);
            //B b5 = new B(b4);
            //C c3 = new C(b5, a2);

            C c = new C(new A(), new B(new B(new A())));
            //        c3     a2      b5     b4    a1

        }
    }
}
