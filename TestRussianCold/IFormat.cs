using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRussianCold
{
    public interface IFormat
    {
        public void Add(ushort a, ushort b, ushort c);
        public void Subtract();
        public bool IsValid();
    }
}
