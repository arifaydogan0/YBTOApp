using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
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
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
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
                BirthDate = new(1969, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Harun",
                LastName = "Alemdar",
                Gender = "Erkek",
                BloodGroup = "AB rh+",
                BirthDate = new(1961, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Yeliz",
                LastName = "Taşkıran",
                Gender = "Kadın",
                BloodGroup = "0 rh+",
                BirthDate = new(1953, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Helen",
                LastName = "Çömlekli",
                Gender = "Kadın",
                BloodGroup = "A rh+",
                BirthDate = new(1957, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Burhan",
                LastName = "Avam",
                Gender = "Erkek",
                BloodGroup = "B rh+",
                BirthDate = new(1974, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Selin",
                LastName = "Bardakçı",
                Gender = "Kadın",
                BloodGroup = "A rh-",
                BirthDate = new(1997, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Mahmut",
                LastName = "Tuncer",
                Gender = "Kadın",
                BloodGroup = "AB rh+",
                BirthDate = new(1951, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Songül",
                LastName = "Livaneli",
                Gender = "Kadın",
                BloodGroup = "0 rh-",
                BirthDate = new(1947, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Selim",
                LastName = "Tuzcu",
                Gender = "Erkek",
                BloodGroup = "0 rh+",
                BirthDate = new(1967, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Yahya",
                LastName = "Beyatlı",
                Gender = "Kadın",
                BloodGroup = "0 rh+",
                BirthDate = new(1957, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Süleyman",
                LastName = "Tekin",
                Gender = "Kadın",
                BloodGroup = "0 rh+",
                BirthDate = new(1957, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Buse",
                LastName = "Kaman",
                Gender = "Kadın",
                BloodGroup = "0 rh+",
                BirthDate = new(1957, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Tuğçe",
                LastName = "Yaman",
                Gender = "Kadın",
                BloodGroup = "0 rh+",
                BirthDate = new(1957, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Burak",
                LastName = "Ankakuşu",
                Gender = "Erkek",
                BloodGroup = "A rh+",
                BirthDate = new(1957, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 122, DiastolikValue = 81},
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
                BirthDate = new(1952, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 119, DiastolikValue = 85},
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
                CurrentBloodPressure = new(){SistolikValue = 124, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 37.6},
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
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 35.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.95}
            },
            new()
            {
                Name = "Fatoş",
                LastName = "Çakır",
                BloodGroup = "AB rh+",
                Gender = "Kadın",
                BirthDate = new(1966, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.96}
            },
            new()
            {
                Name = "Fırat",
                LastName = "Bülbül",
                Gender = "Erkek",
                BloodGroup = "B rh+",
                BirthDate = new(1977, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 118, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.6},
                CurrentPulse = new() {PulseValue = 72},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
            new()
            {
                Name = "Seçkin",
                LastName = "Sivri",
                BloodGroup = "0 rh+",
                Gender = "Kadın",
                BirthDate = new(1988, 11, 21),
                CurrentBloodPressure = new(){SistolikValue = 120, DiastolikValue = 85},
                CurrentTemperature = new(){TemperatureValue = 36.9},
                CurrentPulse = new() {PulseValue = 67},
                CurrentSaturation = new(){SaturationValue = 0.97}
            },
        };
    }
}
