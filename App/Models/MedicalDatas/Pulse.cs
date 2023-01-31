using System;

namespace App.Models.MedicalDatas
{
    /// <summary>
    /// Nabız, 60-100 / dk arası değerler normal kabul edilir.
    /// </summary>
    internal class Pulse
    {
        private int pulse;
        public static List<string> Statuses = new List<string>
        {
            "Normal",
            "Yüksek Nabız",
            "Düşük Nabız"
        };

        public int PulseValue
        {
            get => pulse; 
            set => pulse = value < 135 && value > 55 ? value : pulse;
        }
        public int StatusIndex => PulseValue > 110 ? 1 : PulseValue < 60 ? 2 : 0;
        public bool Alert => StatusIndex != 0;

        public override string ToString()
        {
            return $"{PulseValue} / dk";
        }
    }
}
