using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexLib
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Img { get; set; }

        public ComplexNumber() 
        {
            Real = 0;
            Img = 0;
        }

        public override string ToString()
        {
            // Beide Negativ
            if (Real < 0 && Img < 0)
            {
                return $"{Math.Round(Real, 2)} {Math.Round(Img, 2)}i";
            }
            // Real negativ, Imaginär positiv
            else if (Real < 0 && Img >= 0)
            {
                return $"{Math.Round(Real, 2)} + {Math.Round(Img, 2)}i";
            }
            // Real positiv, Imaginär negativ
            else if (Real >= 0 && Img < 0)
            {
                return $"{Math.Round(Real, 2)} {Math.Round(Img, 2)}i";
            }

            return $"{Math.Round(Real, 2)} + {Math.Round(Img, 2)}i";
        }

        public string PrintPolar(ComplexNumber a)
        {
            double r = Math.Sqrt(a.Real * a.Real + a.Img * a.Img); // Phythagoras
            double bogenmaß = Math.Atan2(a.Img, a.Real); // Winkel in Bogenmaß (RADIANT)
            double winkel = bogenmaß * (180 / Math.PI); // Umrechnung in Grad

            return $"{Math.Round(r, 2)}(cos({Math.Round(winkel, 2)}) + i*sin({Math.Round(winkel, 2)}))"; // Polarform
        }


    }
}
