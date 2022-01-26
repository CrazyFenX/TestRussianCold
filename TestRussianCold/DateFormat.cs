using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRussianCold
{
    class DateFormat : IFormat
    {
        private ushort years;
        private ushort months;
        private ushort days;

        //public enum monthss { JAN = 1, FEB, MAR, APR, MAY, JUN, JUL, AUG, SEP, OCT, NOV, DEC };

        public DateFormat(ushort inputyears, ushort inputmonths, ushort inputdays)
        {
            if (inputmonths > 12) throw new Exception("Некорректный номер месяца!");
            if (days > 31) throw new Exception("Некорректный номер дня!");
            if ((months == 4 || months == 6 || months == 9 || months == 11) && days > 30) throw new Exception("Номер дня не соответствует количеству дней в данном месяце");
            if ((years / 4 != 0) && months == 2 && days > 28) throw new Exception("В невисокосный год в феврале 28 дней!");
            if ((years / 4 == 0) && months == 2 && days > 29) throw new Exception("В високосный год в феврале 29 дней!");
            years = inputyears;
            months = inputdays;
            days = inputdays;
        }

        private bool IsValid()
        {
            if (months > 12) return false;
            if (days > 31) return false;
            if ((months == 4 || months == 6 || months == 9 || months == 11) && days > 30) return false;
            if ((years / 4 != 0) && months == 2 && days > 28) return false;
            if ((years / 4 == 0) && months == 2 && days > 29) return false;
            return true;
        }

        public override string ToString()
        {
            return years.ToString() + "." + months.ToString() + "." + days.ToString();
        }
        private void AddYears(ushort addValue)
        {
            years += addValue;
        }
        private void AddMonths(ushort addValue)
        {
            if (months + addValue > 12)
                this.AddYears((ushort)((months + addValue) / 12));
            months = (ushort)((months + addValue) % 12 + 1);
        }
        private void AddDays(ushort addValue)
        {
            int dayCount = 31;
            if ((months == 4 || months == 6 || months == 9 || months == 11)) dayCount = 30;
            else if ((years / 4 != 0) && months == 2) dayCount = 28;
            else if ((years / 4 == 0) && months == 2) dayCount = 29;

            if (days + addValue > dayCount)
                this.AddMonths((ushort)((days + addValue) / dayCount));
            days = (ushort)((days + addValue) % (dayCount + 1));
        }

        private void SubtractYears()
        {

        }
        private void SubtractMonths()
        {

        }
        private void SubtractDays()
        {

        }

        public void Add(ushort years = 0, ushort months = 0, ushort days = 0)
        {
            if (years > 0) AddYears(years);
            if (months > 0) AddMonths(months);
            if (days > 0) AddDays(days);
        }

        public void Subtract()
        {
            throw new NotImplementedException();
        }

        void IFormat.IsValid()
        {
            throw new NotImplementedException();
        }
    }
}