using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller22065986203
{
    internal class circulo
    {
        float r;
        public circulo(float r)
        {
            this.r = r;
        }
        public float Area()
        {
            return (r * r * 3.1416f);
        }           
    }
}
