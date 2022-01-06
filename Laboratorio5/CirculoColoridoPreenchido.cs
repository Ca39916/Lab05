using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laboratorio5
{
    internal class CirculoColoridoPreenchido : CirculoColorido
    {
        private Color corAdicional;

        public CirculoColoridoPreenchido()
        {
            corAdicional = Color.Aqua; //Criando uma cor adicinal pra class CirculoColoridoPreenchido
        }

        public CirculoColoridoPreenchido(double x, double y, double r, string c, Color d) : base(x, y, r, c)
        {
            corAdicional = d;
        }
        public override string ToString()
        {
            return base.ToString() + ", Cor adicinal= " + corAdicional;
        }
    }
}
