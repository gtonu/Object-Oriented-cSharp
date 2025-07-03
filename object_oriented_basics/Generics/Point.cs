using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Point<T> where T : INumber<T>
    {
        public T X { get; set; }
        public T Y { get; set; }

        public T PointSum() => X + Y;

    }
}
