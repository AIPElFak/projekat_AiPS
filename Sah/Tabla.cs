using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sah
{
    class Tabla:Sah
    {
        int xSirina,yVisina;
        public Tabla(int sirina, int visina)
        {
            xSirina=sirina;
            yVisina = visina;
        }
        public int sirinaX()
        {
             return xSirina;
        }
        public int visinaY()
        {
            return yVisina;
        }
    }
}