using CalendarDatabase.Entity;
using CalendarDatabase.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CalendarDatabase.Repository
{
    public class CalendarRepository : ICalendarRepository
    {
        protected readonly CalendarDBContextDatabase dbContext;
        protected DbSet<Calendar> DBSet => dbContext.Calendar;

        public CalendarRepository(CalendarDBContextDatabase calendarDBContext)
        {
            dbContext = calendarDBContext;
        }

        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task<List<Calendar>> GetAllAsync()
        {
            List<Task<Calendar>> list = new List<Task<Calendar>>();
            var entities = DBSet;
            foreach (var entity in entities)
            {
                list.Add(Task.Run(()=>entity));
            }
            var results = await Task.WhenAll(list);
            return results.ToList();
        }

        public async Task AddNewAsync(Calendar calendar)
        {
            await DBSet.AddAsync(calendar);
            await SaveChangesAsync();
        }

        public async Task<Calendar> GetCalendarByIdAsync(int Id)
        {
            var foundEntity = await Task.Run(()=>DBSet.Where(x => x.Id == Id).FirstOrDefault());
            return foundEntity;
        }

        public async Task<List<Calendar>> GetCalendarsByDayAsync(DateTime date)
        {
            var foundEntities = await Task.Run(()=>DBSet.Where(x => x.Year == date.Year.ToString()).Where(x => x.Month == date.Month).Where(x => x.Day == date.Day.ToString()).
                                OrderBy(x=>x.TimeStart).ToList());
            return foundEntities;
        }

        public async Task<List<Calendar>> GetCalendarsByMonthAsync(DateTime date)
        {
            var foundEntities = await Task.Run(() => DBSet.Where(x => x.Year == date.Year.ToString()).Where(x => x.Month == date.Month).
                                OrderBy(x=>x.Day).ThenBy(x=>x.TimeStart).ToList());
            return foundEntities;
        }

        public async Task SaveCalendarAsync(Calendar calendar)
        {
                await DBSet.AddAsync(calendar);
                await SaveChangesAsync();
        }

        public async Task DeleteCalendarAsync(int Id)
        {
            var foundEntity = await Task.Run(()=>DBSet.Where(x => x.Id == Id).FirstOrDefault());
            if(foundEntity!=null)
            {
                DBSet.Remove(foundEntity);
                await SaveChangesAsync();
            }
        }

        public async Task SaveEditedCalendarAsync(int Id, Calendar calendar)
        {
            var foundEntity = await Task.Run(()=>DBSet.Where(x => x.Id == Id).FirstOrDefault());
            if (foundEntity != null)
            {
                foundEntity.Day = calendar.Day;
                foundEntity.Month = calendar.Month;
                foundEntity.Year = calendar.Year;
                foundEntity.TimeStart = calendar.TimeStart;
                foundEntity.TimeEnd = calendar.TimeEnd;
                foundEntity.TypeOfConference = calendar.TypeOfConference;
                foundEntity.WhoIsConcern = calendar.WhoIsConcern;
                foundEntity.OtherInformation = calendar.OtherInformation;
                foundEntity.Url = calendar.Url;
                await SaveChangesAsync();
            }
        }
       
    }
}
