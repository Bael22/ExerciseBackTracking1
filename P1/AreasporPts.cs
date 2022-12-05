using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    internal class AreasporPts
    {
        public static int PtsIntersectados(double a, double b,int cant)
        {
            int ptsTriangulo = 0; int ptsrectangulo = 0;
            Random r = new Random();
            for (int z = 1; z <= cant; z++)
            {
                double x = r.NextDouble() * (a - (-a)) + (-a);
                double y = r.NextDouble() * (b - (-b)) + (-b);

                if (x <= 3 && y <= 4 && x >= -4 && y >= -4)
                {
                    ptsrectangulo++;
                    //if (((2 * x / 7) + 6) >= y && (-3 * x + 6) <= y && ((8 * x - 16) / 5) <= y)
                    if ((0.29 * x + 3.14) >= y && (-3 * x - 10) <= y && (1.6 * x - 0.8) <= y)
                    {
                        ptsTriangulo++;
                    }
                }

            }
            Console.WriteLine("Hay " + ptsTriangulo + " puntos que cayeron dentro del triangulo\n");
            Console.WriteLine("Hay " + ptsrectangulo + " puntos que cayeron dentro del rectangulo\n");
            return ptsTriangulo;
        }
    }
}
