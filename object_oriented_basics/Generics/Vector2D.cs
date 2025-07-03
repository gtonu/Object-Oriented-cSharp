using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public struct Vector2D<T> where T : INumber<T>
    {
        public T XcoOrdinate { get; set; }
        public T YcoOrdinate { get; set; }


    }
}
