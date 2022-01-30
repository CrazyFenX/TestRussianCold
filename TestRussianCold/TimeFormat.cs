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

        public TimeFormat(ushort inputhours, ushort inputminutes, ushort inputseconds)
        {
            if (inputhours > 23) throw new Exception("Некорректное число часов!");
            if (inputminutes > 59) throw new Exception("Некорректное число минут!");
            if (inputseconds > 59) throw new Exception("Некорректное число секунд!");
            hours = inputhours;
            minutes = inputminutes;
            seconds = inputseconds;
        }
        public static TimeFormat FromString(string inputStr)
        {
            string[] stringArray = inputStr.Split(':');
            if (stringArray.Length < 2 || stringArray.Length > 3) throw new Exception("Неверный формат даты! Проверьте правильность заполения полей и повторите попытку.");
            if (stringArray.Length == 3)
                return new TimeFormat((ushort)Convert.ToInt32(stringArray[0]), (ushort)Convert.ToInt32(stringArray[1]), (ushort)Convert.ToInt32(stringArray[2]));
            return new TimeFormat((ushort)Convert.ToInt32(stringArray[0]), (ushort)Convert.ToInt32(stringArray[1]), 0);
        }
        public override string ToString()
        {
            string _hours = hours < 10 ? "0" + hours.ToString() : hours.ToString();
            string _minutes = minutes < 10 ? "0" + minutes.ToString() : minutes.ToString();
            string _seconds = seconds < 10 ? "0" + seconds.ToString() : seconds.ToString();
            return _hours + ":" + _minutes + ":" + _seconds;
        }

        private void AddHours(ushort addValue)
        {
            hours += addValue;
        }
        private void AddMinutes(ushort addValue)
        {
            if (minutes + addValue > 59)
                this.AddHours((ushort)((minutes + addValue) / 60));
            minutes = (ushort)((minutes + addValue) % 60);
        }
        private void AddSeconds(ushort addValue)
        {
            if (seconds + addValue > 59)
                this.AddMinutes((ushort)((seconds + addValue) / 60));
            seconds = (ushort)((seconds + addValue) % 60);
        }

        public void Add(ushort hours = 0, ushort minutes = 0, ushort seconds = 0)
        {
            this.AddHours(hours);
            this.AddMinutes(minutes);
            this.AddSeconds(seconds);
        }
        public void Subtract()
        {
            throw new NotImplementedException();
        }
        public bool IsValid()
        {
            return (hours > 23) || (minutes > 59) || (seconds > 59) || (hours < 0) || (minutes < 0) || (seconds < 0);
        }
        public static bool operator >= (TimeFormat time1, TimeFormat time2)
        {
            if (time1.hours > time2.hours) return true;
            if (time1.hours == time2.hours)
                if (time1.minutes > time2.minutes) return true;
                else if (time1.minutes == time2.minutes)
                    if (time1.seconds >= time2.seconds) return true;
            return false;
        }
        public static bool operator <= (TimeFormat time1, TimeFormat time2)
        {
            if (time1.hours < time2.hours) return true;
            if (time1.hours == time2.hours)
                if (time1.minutes < time2.minutes) return true;
                else if (time1.minutes == time2.minutes)
                    if (time1.seconds <= time2.seconds) return true;
            return false;
        }

        public static bool operator > (TimeFormat time1, TimeFormat time2)
        {
            if (time1.hours > time2.hours) return true;
            if (time1.hours == time2.hours)
                if (time1.minutes > time2.minutes) return true;
                else if (time1.minutes == time2.minutes)
                    if (time1.seconds > time2.seconds) return true;
            return false;
        }
        public static bool operator < (TimeFormat time1, TimeFormat time2)
        {
            if (time1.hours < time2.hours) return true;
            if (time1.hours == time2.hours)
                if (time1.minutes < time2.minutes) return true;
                else if (time1.minutes == time2.minutes)
                    if (time1.seconds < time2.seconds) return true;
            return false;
        }

        public static bool operator == (TimeFormat time1, TimeFormat time2)
        {
            if (time1.hours == time2.hours && time1.minutes == time2.minutes && time1.seconds == time2.seconds) return true;
            return false;
        }
        public static bool operator != (TimeFormat time1, TimeFormat time2)
        {
            if (time1.hours == time2.hours && time1.minutes == time2.minutes && time1.seconds == time2.seconds) return false;
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