using CalendarDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CalendarDatabase.Interfaces
{
    public interface ICalendarRepository
    {
        Task SaveChangesAsync();
        Task<List<Calendar>> GetAllAsync();
        Task AddNewAsync(Calendar calendar);
        Task<Calendar> GetCalendarByIdAsync(int Id);
        Task SaveCalendarAsync(Calendar calendar);
        Task<List<Calendar>> GetCalendarsByDayAsync(DateTime date);
        Task<List<Calendar>> GetCalendarsByMonthAsync(DateTime date);
        Task DeleteCalendarAsync(int Id);
        Task SaveEditedCalendarAsync(int Id, Calendar calendar);
    }
}
