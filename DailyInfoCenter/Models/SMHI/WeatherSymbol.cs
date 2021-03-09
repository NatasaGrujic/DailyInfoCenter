using System.ComponentModel.DataAnnotations;

namespace DailyInfoCenter.Models.SMHI
{
    public enum WeatherSymbol
    {
        [Display(Name = "Klart")]
        ClearSky = 1,
        [Display(Name = "Lätt molnighet")]
        NearlyClearSky,
        [Display(Name = "Växlande molnighet")]
        VariableCloudiness,
        [Display(Name = "Halvklart")]
        HalfClearSky,
        [Display(Name = "Molnigt")]
        CloudySky,
        [Display(Name = "Mulet")]
        Overcast,
        [Display(Name = "Dimma")]
        Fog,
        [Display(Name = "Lätt regnskur")]
        LightRainShowers,
        [Display(Name = "Måttlig regnskur")]
        ModerateRainShowers,
        [Display(Name = "Kraftig regnskur")]
        HeavyRainShowers,
        [Display(Name = "Måttligt snöblandat regn")]
        ModerateSleetShowers,
        [Display(Name = "Kraftigt snöblandat regn")]
        HeavySleetShowers,
        [Display(Name = "Lätt snöby")]
        LightSnowShowers,
        [Display(Name = "Måttlig snöby")]
        ModerateSnowShowers,
        [Display(Name = "Kraftig snöby")]
        HeavySnowShowers,
        [Display(Name = "Lätt regn")]
        LightRain,
        [Display(Name = "Måttligt regn")]
        ModerateRain,
        [Display(Name = "Kraftigt regn")]
        HeavyRain,
        [Display(Name = "Åska")]
        Thunder,
        [Display(Name = "Lätt by av regn och snö")]
        LighSleet,
        [Display(Name = "Måttlig by av regn och snö")]
        ModerateSleet,
        [Display(Name = "Kraftig by av regn och snö")]
        HeavySleet,
        [Display(Name = "Lätt snöfall")]
        LightSnowfall,
        [Display(Name = "Måttligt snöfall")]
        ModerateSnowfall,
        [Display(Name = "Ymnigt snöfall")]
        HeavySnowfall

    }
}
