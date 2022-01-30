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

        public DateFormat(ushort inputyears, ushort inputmonths, ushort inputdays)
        {
            if (inputmonths > 12) throw new Exception("Некорректный номер месяца!");
            if (days > 31) throw new Exception("Некорректный номер дня!");
            if ((months == 4 || months == 6 || months == 9 || months == 11) && days > 30) throw new Exception("Номер дня не соответствует количеству дней в данном месяце");
            if ((years / 4 != 0) && months == 2 && days > 28) throw new Exception("В невисокосный год в феврале 28 дней!");
            if ((years / 4 == 0) && months == 2 && days > 29) throw new Exception("В високосный год в феврале 29 дней!");
            years = inputyears;
            months = inputmonths;
            days = inputdays;
        }

        public static DateFormat FromString(string inputStr)
        {
            string[] stringArray = inputStr.Split('.');
            if (stringArray.Length != 3) throw new Exception("Неверный формат даты! Проверьте правильность заполения полей и повторите попытку.");    
            return new DateFormat((ushort)Convert.ToInt32(stringArray[2]), (ushort)Convert.ToInt32(stringArray[1]), (ushort)Convert.ToInt32(stringArray[0]));
        }

        public override string ToString()
        {
            string _days = days < 10 ? "0" + days.ToString() : days.ToString();
            string _months = months < 10 ? "0" + months.ToString() : months.ToString();
            return _days + "." + _months + "." + years.ToString();
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
            //pass
        }
        private void SubtractMonths()
        {
            //pass
        }
        private void SubtractDays()
        {
            //pass
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

        public bool IsValid()
        {
            if (months > 12) return false;
            if (days > 31) return false;
            if ((months == 4 || months == 6 || months == 9 || months == 11) && days > 30) return false;
            if ((years / 4 != 0) && months == 2 && days > 28) return false;
            if ((years / 4 == 0) && months == 2 && days > 29) return false;
            return true;
        }

        public static bool operator >= (DateFormat date1, DateFormat date2)
        {
            if (date1.years > date2.years) return true;
            if (date1.years == date2.years)
                if (date1.months > date2.months) return true;
                if (date1.months == date2.months)
                    if (date1.days >= date2.days) return true;
            return false;
        }
        public static bool operator <= (DateFormat date1, DateFormat date2)
        {
            if (date1.years < date2.years) return true;
            if (date1.years == date2.years)
                if (date1.months < date2.months) return true;
            if (date1.months == date2.months)
                if (date1.days <= date2.days) return true;
            return false;
        }

        public static bool operator > (DateFormat date1, DateFormat date2)
        {
            if (date1.years > date2.years) return true;
            if (date1.years == date2.years)
                if (date1.months > date2.months) return true;
            if (date1.months == date2.months)
                if (date1.days > date2.days) return true;
            return false;
        }
        public static bool operator < (DateFormat date1, DateFormat date2)
        {
            if (date1.years < date2.years) return true;
            if (date1.years == date2.years)
                if (date1.months < date2.months) return true;
            if (date1.months == date2.months)
                if (date1.days < date2.days) return true;
            return false;
        }

        public static bool operator == (DateFormat date1, DateFormat date2)
        {
            if (date1.years == date2.years && date1.months == date2.months && date1.days == date2.days) return true;
            return false;
        }
        public static bool operator != (DateFormat date1, DateFormat date2)
        {
            if (date1.years == date2.years && date1.months == date2.months && date1.days == date2.days) return false;
            return true;
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}