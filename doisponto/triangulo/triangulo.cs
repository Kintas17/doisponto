using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo
{
    class triangulo
    {
        public Ponto P1 = new Ponto();
        public Ponto P2 = new Ponto();
        public Ponto P3 = new Ponto();

        public double Perimetro => P1.Distancia(P2) + P1.Distancia(P3) + P2.Distancia(P3);

        public double Area => Math.Sqrt(Perimetro/2*(Perimetro/2 - P1.Distancia(P2))*(Perimetro / 2 - P1.Distancia(P3))*(Perimetro / 2 - P2.Distancia(P3))); 
    }
}
