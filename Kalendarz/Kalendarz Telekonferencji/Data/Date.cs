using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalendarz_Telekonferencji.Data
{
    public class Date
    {
        string sDay { get; set; }
        int iMonth { get; set; }
        int iMonthBefore { get; set; } = 0;
        int iMonthPast { get; set; } = 0;
        string sYear { get; set; }

        int iDaysInMonth { get; set; }

        public int iDayCounter = 0;

        string sDayOfWeek { get; set; }

        public string Day { get { return sDay; } }
        public int Month { get { return iMonth; } }
        //public int MonthBefore { get { return iMonthBefore; } }
        //public int MonthPast { get { return iMonthPast; } }
        public string Year { get { return sYear; } }
        public string DayOfWeek { get { return sDayOfWeek; } }

        public int DaysInMonth { get { return iDaysInMonth; } }

        public Date(DateTime dateTime)
        {
            sDay = dateTime.Date.Day.ToString();
            iMonth= dateTime.Date.Month;
            sYear= dateTime.Date.Year.ToString();
            sDayOfWeek= dateTime.Date.DayOfWeek.ToString();
            iDaysInMonth= System.DateTime.DaysInMonth(dateTime.Date.Year, dateTime.Date.Month);
        }

        public int GetDayOfWeekToInt()
        {
            string DayOfWeek = new DateTime(Convert.ToInt32(sYear), iMonth, 1).DayOfWeek.ToString();
            int DayOfWeekInInt=0;
            switch(DayOfWeek)
            {
                case "Monday":
                    DayOfWeekInInt = 1;
                    break;
                case "Tuesday":
                    DayOfWeekInInt = 2;
                    break;
                case "Wednesday":
                    DayOfWeekInInt = 3;
                    break;
                case "Thursday":
                    DayOfWeekInInt = 4;
                    break;
                case "Friday":
                    DayOfWeekInInt = 5;
                    break;
                case "Saturday":
                    DayOfWeekInInt = 6;
                    break;
                case "Sunday":
                    DayOfWeekInInt = 7;
                    break;
            }
            return DayOfWeekInInt;
        }

        public int GetDayOfWeekToIntSelectedDay()
        {
            int DayOfWeekInInt = 0;
            switch (DayOfWeek)
            {
                case "Monday":
                    DayOfWeekInInt = 1;
                    break;
                case "Tuesday":
                    DayOfWeekInInt = 2;
                    break;
                case "Wednesday":
                    DayOfWeekInInt = 3;
                    break;
                case "Thursday":
                    DayOfWeekInInt = 4;
                    break;
                case "Friday":
                    DayOfWeekInInt = 5;
                    break;
                case "Saturday":
                    DayOfWeekInInt = 6;
                    break;
                case "Sunday":
                    DayOfWeekInInt = 7;
                    break;
            }
            return DayOfWeekInInt;
        }

        public string GetDayOfWeekInPolish()
        {

            string DayOfWeekPolish = "";
            switch (DayOfWeek)
            {
                case "Monday":
                    DayOfWeekPolish = "Poniedziałek";
                    break;
                case "Tuesday":
                    DayOfWeekPolish = "Wtorek";
                    break;
                case "Wednesday":
                    DayOfWeekPolish = "Środa";
                    break;
                case "Thursday":
                    DayOfWeekPolish = "Czwartek";
                    break;
                case "Friday":
                    DayOfWeekPolish = "Piątek";
                    break;
                case "Saturday":
                    DayOfWeekPolish = "Sobota";
                    break;
                case "Sunday":
                    DayOfWeekPolish = "Niedziela";
                    break;
            }
            return DayOfWeekPolish;


        }

        public string GetNextMonth()
        {
            var nextMonth = Month + 1;
            if(nextMonth==13)
            {
                iMonth = 1;
                sYear = (Convert.ToInt32(sYear) + 1).ToString();
            }
            else iMonth = nextMonth;

            iDaysInMonth = System.DateTime.DaysInMonth(Convert.ToInt32(sYear), iMonth);
            iDayCounter = 0;
            return sDay = "";
        }

        public string GetPreviousMonth()
        {
            var previousMonth = iMonth - 1;
            if (previousMonth == 0)
            {
                iMonth = 12;
                sYear = (Convert.ToInt32(sYear) - 1).ToString();
            }
            else iMonth = previousMonth;

            iDaysInMonth = System.DateTime.DaysInMonth(Convert.ToInt32(sYear), iMonth);
            iDayCounter = 0;
            return sDay = "";
        }

        public string SetMonthToPolishWord(int month)
        {
            string Month = "";
            switch (month)
            {
                case 1:
                    Month = "STYCZEŃ";
                    break;
                case 2:
                    Month = "LUTY";
                    break;
                case 3:
                    Month = "MARZEC";
                    break;
                case 4:
                    Month = "KWIECIEŃ";
                    break;
                case 5:
                    Month = "MAJ";
                    break;
                case 6:
                    Month = "CZERWIEC";
                    break;
                case 7:
                    Month = "LIPIEC";
                    break;
                case 8:
                    Month = "SIERPIEŃ";
                    break;
                case 9:
                    Month = "WRZESIEŃ";
                    break;
                case 10:
                    Month = "PAŹDZIERNIK";
                    break;
                case 11:
                    Month = "LISTOPAD";
                    break;
                case 12:
                    Month = "GRUDZIEŃ";
                    break;
            }
            return Month;
        }

        public string GetMonthToPolishWord()
        {
            string Month = "";
            if (iMonthBefore == 0 && iMonthPast == 0) Month = SetMonthToPolishWord(iMonth);
            if (iMonthBefore != 0) Month = SetMonthToPolishWord(iMonthBefore)+"/"+ SetMonthToPolishWord(iMonth);
            if(iMonthPast!=0) Month = SetMonthToPolishWord(iMonth)+"/"+SetMonthToPolishWord(iMonthPast);
            return Month;
        }

        public string GetYearForWeekView()
        {
            var year = "";
            year = sYear;
            if (iMonthBefore == 12 && iMonth == 1) year = (Convert.ToInt32(sYear) - 1).ToString()+"/"+ sYear;
            if(iMonth==12&&iMonthPast==1) year = sYear+"/"+(Convert.ToInt32(sYear) + 1).ToString();
            return year;
        }

        public List<int> InitWeek()
        {
            List<int> days = new List<int>();
            var startDay = (Convert.ToInt32(sDay) - GetDayOfWeekToIntSelectedDay())+1;
            if(startDay<=0)
            {
                for (int i = startDay; i < 7-startDay; i++)
                {
                    if (i < 0) days.Add(CheckHowManyDaysInMonthBefore() + i);
                    else if (i==0) days.Add(CheckHowManyDaysInMonthBefore());
                    else days.Add(i);
                }
                iMonthBefore = iMonth - 1;
                if (iMonthBefore == 0) iMonthBefore = 12;
            }
            if(startDay>0 && startDay+6<=DaysInMonth)
            {
                for (int i = startDay; i < startDay+7; i++) days.Add(i);
            }
            if(startDay+6>DaysInMonth)
            {
                int a = 1;
                for (int i = startDay; i < startDay+7; i++)
                {
                    if (i <= DaysInMonth) days.Add(i);
                    else if (i > DaysInMonth)
                    {
                        days.Add(a);
                        a++;
                    }
                }
                iMonthPast = iMonth + 1;
                if (iMonthPast == 13) iMonthPast = 1;
            }
            return days;
        }

        public int CheckHowManyDaysInMonthBefore()
        {
            var Month = iMonth;
            var Year = sYear;
            if (Month - 1 == 0)
            {
                Month = 12;
                Year = (Convert.ToInt32(Year) - 1).ToString();
            }
            else Month = Month - 1;
            var daysMonthBefore = System.DateTime.DaysInMonth(Convert.ToInt32(Year), Month);
            return daysMonthBefore;
        }

        public int CheckHowManyDaysInMonthPast()
        {
            var Month = iMonth;
            var Year = sYear;
            if (Month + 1 == 13)
            {
                Month = 1;
                Year = (Convert.ToInt32(Year) + 1).ToString();
            }
            else Month = Month + 1;
            var daysMonthPast = System.DateTime.DaysInMonth(Convert.ToInt32(Year), Month);
            return daysMonthPast;
        }

        public bool CheckThatPreviousMonthForWeek(List<int> list)
        {
            int day = list[list.Count-1];
            
            for (int i = list.Count-1; i >= 0; i--)
            {
                if (day >= list[i]) day = list[i];
                else return true;
            }
            return false;
        }

        public DateTime GoToPreviousWeek(List<int> list)
        {
            var day = list[0];
            day = day - 1;
            var month = iMonth;
            if (day == 0)
            {
                day = CheckHowManyDaysInMonthBefore();
                month = iMonth-1;
                if (month == 12) sYear = (Convert.ToInt32(sYear) - 1).ToString();
            }
            if (CheckThatPreviousMonthForWeek(list))
            {
                month = iMonth - 1;
                if (iMonth - 1 == 0)
                {
                    sYear = (Convert.ToInt32(sYear) - 1).ToString();
                    month = 12;
                }
                return new DateTime(Convert.ToInt32(sYear), month, day, 0, 0, 0);
            }
            else return new DateTime(Convert.ToInt32(sYear), month, day, 0, 0, 0);
        }

        public bool CheckThatNextMonthForWeek(List<int> list)
        {
            int day = list[0];

            for (int i = 0; i <list.Count; i++)
            {
                if (day <= list[i]) day = list[i];
                else return true;
            }
            return false;
        }

        public DateTime GoToNextWeek(List<int> list)
        {
            var day = list[list.Count-1];
            day = day + 1;
            var month = iMonth;
            if (day == DaysInMonth+1)
            {
                day = 1;
                month = iMonth+1;
                if (month == 1) sYear = (Convert.ToInt32(sYear) + 1).ToString();
            }
            if (CheckThatNextMonthForWeek(list))
            {
                if (iMonthPast == 1)
                {
                    sYear = (Convert.ToInt32(sYear) + 1).ToString();
                    month = 1;
                }
                else
                {
                    if (iMonthPast != 0) month = iMonth + 1;
                    if (iMonthPast == 0) month = iMonth;
                }
                return new DateTime(Convert.ToInt32(sYear), month, day, 0, 0, 0);
            }
            else return new DateTime(Convert.ToInt32(sYear), month, day, 0, 0, 0);
        }

        public DateTime GoToNextDay()
        {
            var day = Convert.ToInt32(Day);
            var month = iMonth;
            var year = Convert.ToInt32(sYear);
            day = day + 1;
            if (day > DaysInMonth)
            {
                month = month + 1;
                day = 1;
            }
            if(month==13)
            {
                month = 1;
                year = year + 1;
            }
            return new DateTime(year, month, day, 0, 0, 0);
        }

        public DateTime GoToPreviousDay()
        {
            var day = Convert.ToInt32(Day);
            var month = iMonth;
            var year = Convert.ToInt32(sYear);
            day = day - 1;
            if (day == 0)
            {
                month = month - 1;
                if(month==0)
                {
                    month = 12;
                    year = year - 1;
                }
                day = DateTime.DaysInMonth(year, month);
            }
            return new DateTime(year, month, day, 0, 0, 0);
        }
    }
}
