using AutoMapper;
using CalendarDatabase.Entity;
using Kalendarz_Telekonferencji.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalendarz_Telekonferencji.Mapper
{
    public class CalendarMapper
    {
        private IMapper mMapper;
        public CalendarMapper()
        {
            mMapper = new MapperConfiguration(config =>
            {
                config.CreateMap<Calendar, CalendarViewModel>()
                .ReverseMap();
            }).CreateMapper();
        }

        public CalendarViewModel Map(Calendar calendar) => mMapper.Map<CalendarViewModel>(calendar);
        public List<CalendarViewModel> Map(List<Calendar> calendars) => mMapper.Map<List<CalendarViewModel>>(calendars);
        public IEnumerable<CalendarViewModel> Map(IEnumerable<Calendar> calendars) => mMapper.Map<IEnumerable<CalendarViewModel>>(calendars);
        public Calendar Map(CalendarViewModel calendar) => mMapper.Map<Calendar>(calendar);
        public List<Calendar> Map(List<CalendarViewModel> calendars) => mMapper.Map<List<Calendar>>(calendars);
        public IEnumerable<Calendar> Map(IEnumerable<CalendarViewModel> calendars) => mMapper.Map<IEnumerable<Calendar>>(calendars);
    }
}
