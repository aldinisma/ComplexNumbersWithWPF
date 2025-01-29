using ComplexLib;

namespace TestComplex
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckToStringOfComplexNumber()
        {
            var c = new ComplexLib.ComplexNumber();
            c.Real = 1;
            c.Img = 2;
            var s = c.ToString();

            Assert.AreEqual(s, "1 + 2i");
        }

        [Test]
        public void checkPolarform()
        {
            ComplexNumber number = new ComplexNumber();
            number.Real = 3;
            number.Img = 4;

            var s = number.PrintPolar(number);

            Assert.AreEqual(s, "5(cos(53,13) + i*sin(53,13))");
        }

        [Test]
        public void checkAdd()
        {
            ComplexCalculator calc = new ComplexCalculator();
            ComplexNumber n1 = new ComplexLib.ComplexNumber();
            n1.Real = 5;
            n1.Img = 6;
            ComplexNumber n2 = new ComplexLib.ComplexNumber();
            n2.Real = 2;
            n2.Img = 7;

            var sum = calc.Add(n1, n2);

            Assert.AreEqual(sum.ToString(), "7 + 13i");
        }
        [Test]
        public void checkSub()
        {
            ComplexCalculator calc = new ComplexCalculator();
            ComplexNumber n1 = new ComplexLib.ComplexNumber();
            n1.Real = 5;
            n1.Img = 6;
            ComplexNumber n2 = new ComplexLib.ComplexNumber();
            n2.Real = 9;
            n2.Img = 2;

            var dif = calc.Sub(n1, n2);

            Assert.AreEqual(dif.ToString(), "-4 + 4i");
        }

        [Test]
        public void checkMul()
        {
            ComplexCalculator calc = new ComplexCalculator();
            ComplexNumber nr1 = new ComplexLib.ComplexNumber();
            nr1.Real = 5;
            nr1.Img = 6;
            ComplexNumber nr2 = new ComplexLib.ComplexNumber();
            nr2.Real = 9;
            nr2.Img = 2;

            var product = calc.Mul(nr1, nr2);

            Assert.AreEqual(product.ToString(), "33 + 64i");
        }

        [Test]
        public void checkDivisionWithZero()
        {
            ComplexCalculator calc = new ComplexCalculator();
            ComplexNumber nr1 = new ComplexLib.ComplexNumber();
            nr1.Real = 5;
            nr1.Img = 6;
            ComplexNumber nr2 = new ComplexLib.ComplexNumber();
            nr2.Real = 0;
            nr2.Img = 0;

            Assert.Throws<DivideByZeroException>(() =>
            {
                calc.Div(nr1, nr2);
            });
        }
        [Test]
        public void checkDiv()
        {
            ComplexCalculator calc = new ComplexCalculator();
            ComplexNumber nr1 = new ComplexLib.ComplexNumber();
            nr1.Real = 1;
            nr1.Img = 2;
            ComplexNumber nr2 = new ComplexLib.ComplexNumber();
            nr2.Real = 3;
            nr2.Img = 4;

            var product = calc.Div(nr1, nr2);

            Assert.AreEqual(product.ToString(), "0,44 + 0,08i");
        }
        
    }
}