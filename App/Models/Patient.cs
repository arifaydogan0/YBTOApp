using System;
using App.Models.MedicalDatas;
using App.Models.MedicalDatas.Graphs;


namespace App.Models
{
    internal class Patient
    {
        public Patient() { }
        public Patient(string name, string lastName, DateTime birthDate, string gender, string bloodGroup)
        {
            Name = name;
            LastName = lastName;
            BirthDate = birthDate;
            Gender = gender;
            BloodGroup = bloodGroup;
        }

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

        public DateTime sonNormalOkunduguZaman;
        public bool IsNormal
        {
            get
            {
                if (CurrentPulse?.StatusIndex != 0 || CurrentBloodPressure?.StatusIndex != 0 || CurrentTemperature?.StatusIndex != 0 || CurrentSaturation?.StatusIndex != 0)
                    return false;
                sonNormalOkunduguZaman = DateTime.Now;
                return true;
            }
        }
    }
}
