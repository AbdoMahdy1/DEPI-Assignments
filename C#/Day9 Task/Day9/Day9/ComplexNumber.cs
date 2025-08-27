using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    internal class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        public static ComplexNumber operator*(ComplexNumber left, ComplexNumber right)
        {
            return new ComplexNumber
            {
                Real = (left?.Real??0) * (right?.Real??0),
                Imag = (left?.Imag??0) * (right?.Imag??0)
            };
        }
    }
}
