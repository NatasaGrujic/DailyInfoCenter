using DailyInfoCenter.QuotesAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DailyInfoCenter.QuotesAPI.Controllers // Handles API
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase 
    {
        private string[] _quotes = { "glada", "tokiga", "intressanta", "busiga", "flummiga", "krispiga" }; 

        private Random _rnd = new();

        [HttpGet]
        public async Task<ActionResult<Quote>> GetQouteAsync()
        {
            Quote q = new()
            {
                dayName = $"{((DayNames)DateTime.Now.DayOfWeek).ToString()} {DateTime.Now.ToLongDateString()}", // Assigns values
                message = _quotes[_rnd.Next(0, _quotes.Length)],
                weekNo = GetIso8601WeekOfYear(DateTime.Now)
            };
        return q;
        }
        public static int GetIso8601WeekOfYear(DateTime time)
        {
            // If its Monday, Tuesday or Wednesday, then it'll 
            // be the same week# as whatever Thursday, Friday or Saturday are,
            // and we always get those right
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            // Return the week of our adjusted day
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }
    }
    public enum DayNames
    {
            Måndag = 1,
            Tisdag,
            Onsdag,
            Torsdag,
            Fredag,
            Lördag,
            Söndag
        
    }
}
