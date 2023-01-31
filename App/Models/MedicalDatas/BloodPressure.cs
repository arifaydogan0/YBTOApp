using System;

namespace App.Models.MedicalDatas
{
    /// <summary>
    /// Tansiyon, sistolik(büyük) ve diastolik(küçük) tansiyon olmak üzere iki değere sahiptir.
    /// 120 mmHg ve 80 mmHg değerleri normal kabul edilir.(Tolerans %5)
    /// </summary>
    internal class BloodPressure
    {
        private int diastolicValue;
        private int sistolicValue;
        public static List<string> Statuses = new List<string>
        {
            "Normal",
            "Hipertansiyon",
            "Hipotansiyon"
        };
        public int SistolikValue
        {
            get => sistolicValue;
            set => sistolicValue = (value > 100 && value < 145) ? value : sistolicValue;
        }
        public int DiastolikValue
        {
            get => diastolicValue;
            set => diastolicValue = (value > 55 && value < 95) ? value : diastolicValue;
        }
        public int StatusIndex => SistolikValue > 140 ? 1 : SistolikValue < 100 ? 2 : 0;
        public bool Alert => StatusIndex != 0;

        public override string ToString()
        {
            return $@"{SistolikValue} mmHg / {DiastolikValue} mmHg";
        }
    }
}
