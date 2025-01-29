using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexLib
{
    public class ComplexCalculator
    {
        public ComplexNumber Add(ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.Real + b.Real;
            double imgPart = a.Img + b.Img;

            ComplexNumber sum = new ComplexNumber();
            sum.Real = realPart;
            sum.Img = imgPart;
            return sum;
        }

        public ComplexNumber Sub(ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.Real - b.Real;
            double imgPart = a.Img - b.Img;

            ComplexNumber dif = new ComplexNumber();
            dif.Real = realPart;
            dif.Img = imgPart;
            return dif;
        }

        public ComplexNumber Mul(ComplexNumber a, ComplexNumber b)
        {
            double realPart = a.Real * b.Real - a.Img * b.Img;
            double imgPart = a.Real * b.Img + a.Img * b.Real;

            ComplexNumber product = new ComplexNumber();
            product.Real = realPart;
            product.Img = imgPart;
            return product;
        }

        public ComplexNumber Div(ComplexNumber a, ComplexNumber b)
        {
            double denominator = b.Real * b.Real + b.Img * b.Img;
            if (denominator == 0)
            {
                throw new DivideByZeroException("Division durch Null ist nicht erlaubt!");
            }

            double realPart = (a.Real * b.Real + a.Img * b.Img) / denominator; 
            double imgPart = (a.Img * b.Real - a.Real * b.Img) / denominator;

            ComplexNumber quotient = new ComplexNumber();
            quotient.Real = realPart;
            quotient.Img = imgPart;
            return quotient;
        }
    }
}
