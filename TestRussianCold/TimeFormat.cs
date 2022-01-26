using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRussianCold
{
    class TimeFormat : IFormat
    {
        private ushort hours;
        private ushort minutes;
        private ushort seconds;

        //public enum monthss { JAN = 1, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC };

        public TimeFormat(ushort inputhours, ushort inputminutes, ushort inputseconds)
        {
            if (inputhours > 23) throw new Exception("Некорректное число часов!");
            if (inputminutes > 59) throw new Exception("Некорректное число минут!");
            if (inputseconds > 59) throw new Exception("Некорректное число секунд!");
        }

        public override string ToString()
        {
            return hours.ToString() + ":" + minutes.ToString() + ":" + seconds.ToString();
        }

        public void Add(ushort a, ushort b, ushort c)
        {
            throw new NotImplementedException();
        }

        public void Subtract()
        {
            throw new NotImplementedException();
        }

        public void IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
