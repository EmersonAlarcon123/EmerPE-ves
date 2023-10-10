using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller22065986203
{
    internal class triangulo
    {
        float a, b;
        public triangulo(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public float Area()
        {
            return (a * b) / 2;
        }
    }
}
