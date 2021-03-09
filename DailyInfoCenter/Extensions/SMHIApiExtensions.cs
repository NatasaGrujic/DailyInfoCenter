using DailyInfoCenter.Models.SMHI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyInfoCenter.Extensions
{
    public static class SMHIApiExtensions
    {
    
        public static float GetTemperature(this Parameter[] p) 
        {
            Parameter param = GetParameterByName(p,"t");
            return param.values[0];
        }
        public static float GetNowTemperature(this SMHIModel m)
        {
            Parameter param = GetParameterByName(m.timeSeries[0].parameters, "t"); 
            return param.values[0];
        }
        public static WeatherSymbol GetNowWeatherSymbol(this SMHIModel m)
        {
            Parameter param = GetParameterByName(m.timeSeries[0].parameters, "Wsymb2"); 
            return (WeatherSymbol)param.values[0];
        }

        public static WeatherSymbol GetWeatherSymbol(this Parameter[] p)
        {
            Parameter param = GetParameterByName(p, "Wsymb2");
            return (WeatherSymbol)param.values[0];
        }

        private static Parameter GetParameterByName(Parameter[] par, string paramName)
        {
            return par.Where(n => n.name == paramName).FirstOrDefault();
        }
    }
}
