using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRussianCold
{
    class Service
    {
        private bool DateInRange(DateFormat dateFrom, DateFormat dateTo, DateFormat dateTest) => dateFrom <= dateTest && dateTest <= dateTo;
        private bool TimeInRange(TimeFormat timeFrom, TimeFormat timeTo, TimeFormat timeTest) => timeFrom <= timeTest && timeTest <= timeTo;

        public bool DateTimeInRange(DateFormat dateFrom, TimeFormat timeFrom, DateFormat dateTo, TimeFormat timeTo, DateFormat dateTest, TimeFormat timeTest)
        {
            if (dateFrom > dateTo) throw new Exception("Дата начала периода должна быть меньше Даты окончания!");
            if ((dateFrom == dateTo) && (timeFrom > timeTo)) throw new Exception("Время начала периода должна быть меньше Времени окончания!");

            //В каком случае нужно сравнивать только даты, а в каком даты и время?
            if (dateFrom < dateTest && dateTest < dateTo) return true;

            if ((dateFrom == dateTest && timeFrom <= timeTest && dateTest < dateTo) || (dateFrom < dateTest && dateTest == dateTo && timeTest <= timeTo)) return true;
            return DateInRange(dateFrom, dateTo, dateTest) && TimeInRange(timeFrom, timeTo, timeTest);
        }
    }
}