using System;

namespace App.Models.MedicalDatas
{
    /// <summary>
    /// Kandaki oksijen doygunluğu, %95-%98 SpO2 aralığı değerler normal kabul edilir.
    /// </summary>
    internal class Saturation
    {
        private double saturationValue;
        public static List<string> Statuses = new List<string>
        {
            "Normal",
            "Yüksek Saturasyon",
            "Düşük Saturasyon"
        };

        public double SaturationValue
        {
            get => saturationValue;
            set => saturationValue = value < 0.999 && value > 0.922 ? value : saturationValue;
        }
        public int StatusIndex => SaturationValue > 0.98 ? 1 : SaturationValue < 0.95 ? 2 : 0;
        public bool Alert => StatusIndex != 0;

        public override string ToString()
        {
            return $"%{SaturationValue * 100} SpO2";
        }
    }
}
