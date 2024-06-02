using System;

// //====================wstep
// namespace Lab_05
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var k1 = new Kwota(100,"PLN");
//             var k2 = new Kwota(100,"PLN");
//
//             //var eq = k1 == k2;
//             var eq = k1 + k2;
//         }
//     }
//
//     public class Kwota
//     {
//         public decimal wartosc { get; private set; }
//         public string waluta { get; private set; }
//
//         public Kwota(decimal wartosc, string waluta)
//         {
//             this.wartosc = wartosc;
//             this.waluta = waluta;
//         }
//
//         public static bool operator == (Kwota left, Kwota right)
//         {
//             if (left is null || right is null)
//                 return false;
//
//             if (left.waluta != right.waluta)
//                 return false;
//
//             return left.wartosc == right.wartosc;
//         }
//
//         public static bool operator !=(Kwota left, Kwota right)
//         {
//             return !(left == right);
//         }
//
//         public static Kwota operator +(Kwota left, Kwota right)
//         {
//             if (left is null || right is null)
//                 throw new ArgumentNullException("Kwota nie moze byc pusta");
//
//             if (left.waluta != right.waluta)
//                 throw new ArgumentNullException("Nie mozna dodawac kwot o roznych walutach");
//
//             return new Kwota(left.wartosc + right.wartosc, left.waluta);
//         }
//     }
// }


// //====================zad 1
// namespace Lab_05
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var mathOperations = new MathOperations();
//             var r1 = mathOperations.Add(1, 1);
//             var r2 = mathOperations.Add(2d, 2d);
//         }
//     }
//
//     public class MathOperations
//     {
//         public int Add(int num1, int num2)
//         {
//             return num1 + num2;
//         }
//
//         public double Add(double num1, double num2)
//         {
//             return num1 + num2;
//         }
//     }
// }

//====================zad 3
namespace Lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new ComplexNum(5, 2);
            var c2 = new ComplexNum(3, -7);

            // var c3 = c1 + c2;
            // var c3 = c1 - c2;
            var c3 = c1 * c2;

            Console.WriteLine($"Wynik: {c3}");
        }
    }

    public class ComplexNum
    {
        public double Real { get; private set; }
        public double Imaginary { get; private set; }

        public ComplexNum(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNum operator +(ComplexNum left, ComplexNum right)
        {
            var realVal = left.Real + right.Real;
            var imVal = left.Imaginary + right.Imaginary;
            return new ComplexNum(realVal, imVal);
        }

        public static ComplexNum operator -(ComplexNum left, ComplexNum right)
        {
            var realVal = left.Real - right.Real;
            var imVal = left.Imaginary - right.Imaginary;
            return new ComplexNum(realVal, imVal);
        }

        public static ComplexNum operator *(ComplexNum left, ComplexNum right)
        {
            double realVal = (left.Real * right.Real) - (left.Imaginary * right.Imaginary);
            double imaginaryVal = (left.Real * right.Imaginary) + (left.Imaginary * right.Real);

            return new ComplexNum(realVal, imaginaryVal);
        }

        public override string ToString()
            => $"{Real} + {Imaginary}i";
    }
}