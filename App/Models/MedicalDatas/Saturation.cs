using System;

namespace App.Models.MedicalDatas
{
    /// <summary>
    /// Kandaki oksijen doygunluğu, %95-%98 SpO2 aralığı değerler normal kabul edilir.
    /// </summary>
    internal class Saturation
    {
        public static List<string> Statuses = new List<string>
        {
            "Normal",
            "Yüksek Saturasyon",
            "Düşük Saturasyon"
        };
        public double SaturationValue { get; set; }
        public int StatusIndex => SaturationValue > 0.98 ? 1 : SaturationValue < 0.95 ? 2 : 0;
        public bool Alert => StatusIndex != 0;

        public override string ToString()
        {
            return $"%{SaturationValue * 100} SpO2";
        }
    }
}
