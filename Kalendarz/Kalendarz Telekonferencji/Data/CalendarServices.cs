using CalendarDatabase.Entity;
using CalendarDatabase.Interfaces;
using Kalendarz_Telekonferencji.Data.Interfaces;
using Kalendarz_Telekonferencji.Mapper;
using Kalendarz_Telekonferencji.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalendarz_Telekonferencji.Data
{
    public class CalendarServices : ICalendarServices
    {
        private readonly ICalendarRepository mCalendarRepository;

        private readonly CalendarMapper mCalendarMapper;

        public CalendarServices(ICalendarRepository calendarRepository, CalendarMapper calendarMapper)
        {
            mCalendarRepository = calendarRepository;
            mCalendarMapper = calendarMapper;
        }

        public async Task<List<CalendarViewModel>> GetAllCalendarsAsync()
        {
            var calendarEntity = await mCalendarRepository.GetAllAsync();

            return mCalendarMapper.Map(calendarEntity);
        }

        public async Task<CalendarViewModel> GetCalendarByIdAsync(int Id)
        {
            var calendarEntity = await mCalendarRepository.GetCalendarByIdAsync(Id);
            return mCalendarMapper.Map(calendarEntity);
        }

        public async Task SaveCalendarAsync(CalendarViewModel calendarViewModel)
        {
            await mCalendarRepository.SaveCalendarAsync(mCalendarMapper.Map(calendarViewModel));
        }

        public async Task<List<CalendarViewModel>> GetCalendarsByDayAsync(DateTime date)
        {
            return mCalendarMapper.Map(await mCalendarRepository.GetCalendarsByDayAsync(date));
        }

        public async Task<List<CalendarViewModel>> GetCalendarsByMonthAsync(DateTime date)
        {
            return mCalendarMapper.Map(await mCalendarRepository.GetCalendarsByMonthAsync(date));
        }

        public async Task DeleteCalendarAsync(int Id)
        {
            await mCalendarRepository.DeleteCalendarAsync(Id);
        }

        public async Task SaveEditedCalendarAsync(int Id, CalendarViewModel calendarViewModel)
        { 
            var entity=mCalendarMapper.Map(calendarViewModel);
            await mCalendarRepository.SaveEditedCalendarAsync(Id, entity);
        }
    }
}
