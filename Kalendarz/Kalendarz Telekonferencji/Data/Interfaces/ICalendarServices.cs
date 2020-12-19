using CalendarDatabase.Entity;
using Kalendarz_Telekonferencji.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalendarz_Telekonferencji.Data.Interfaces
{
    public interface ICalendarServices
    {
        Task<List<CalendarViewModel>> GetAllCalendarsAsync();
        Task<CalendarViewModel> GetCalendarByIdAsync(int Id);
        Task SaveCalendarAsync(CalendarViewModel calendarViewModel);
        Task<List<CalendarViewModel>> GetCalendarsByDayAsync(DateTime date);
        Task<List<CalendarViewModel>> GetCalendarsByMonthAsync(DateTime date);
        Task DeleteCalendarAsync(int Id);
        Task SaveEditedCalendarAsync(int Id, CalendarViewModel calendarViewModel);
    }
}
