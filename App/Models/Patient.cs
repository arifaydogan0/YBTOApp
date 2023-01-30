using System;
using App.Models.MedicalDatas;
using App.Models.MedicalDatas.Graphs;


namespace App.Models
{
    internal class Patient
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }

        //public EKG? CurrentEKG { get; set; }
        //public EEG? CurrentEEG { get; set; }
        //public EOG? CurrentEOG { get; set; }
        //public EMG? CurrentEMG { get; set; }
        public Pulse? CurrentPulse { get; set; }
        public Saturation? CurrentSaturation { get; set; }
        public Temperature? CurrentTemperature { get; set; }
        public BloodPressure? CurrentBloodPressure { get; set; }
    }
}
