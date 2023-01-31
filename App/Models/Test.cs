using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    internal static class Test
    {
        public static List<Patient> hastalar = new List<Patient>()
        {
            new()
            {
                Name = "Ayşe",
                LastName = "Yılmaz",
                BloodGroup = "0 rh+",
                Gender = "Kadın",
                BirthDate = new(1985, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "İlber",
                LastName = "Batu",
                BloodGroup = "B rh+",
                Gender = "Erkek",
                BirthDate = new(1983, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Pelin",
                LastName = "Bardakçı",
                Gender = "Kadın",
                BloodGroup = "A rh+",
                BirthDate = new(1957, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Kaan",
                LastName = "Sunalı",
                BloodGroup = "A rh+",
                Gender = "Erkek",
                BirthDate = new(19752, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 132},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Mahmut",
                LastName = "Erdoğan",
                Gender = "Erkek",
                BloodGroup = "B rh-",
                BirthDate = new(1989, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Yavuz",
                LastName = "Eski",
                BloodGroup = "0 rh+",
                Gender = "Erkek",
                BirthDate = new(1981, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Fatoş",
                LastName = "Çakır",
                BloodGroup = "AB rh+",
                Gender = "Kadın",
                BirthDate = new(1966, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Fırat",
                LastName = "Bülbül",
                Gender = "Erkek",
                BloodGroup = "B rh+",
                BirthDate = new(1977, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Seçkin",
                LastName = "Sivri",
                BloodGroup = "0 rh+",
                Gender = "Kadın",
                BirthDate = new(1988, 11, 21),
                CurrentBloodPressure = new(){DiastolikValue = 118, SistolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
        };
    }
}
