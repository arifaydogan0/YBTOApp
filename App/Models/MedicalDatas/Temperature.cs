using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.MedicalDatas
{
    /// <summary>
    /// Vücut ısısı, 34-38 Celcius arasındaki değerler normal kabul edilir.
    /// </summary>
    internal class Temperature
    {
        public static List<string> Statuses = new List<string>
        {
            "Normal",
            "Yüksek Ateş",
            "Düşük Ateş"
        };
        public double TemperatureValue { get; set; }
        public int StatusIndex => TemperatureValue > 38 ? 1 : TemperatureValue < 35 ? 2 : 0;
        public bool Alert => StatusIndex != 0;

        public override string ToString()
        {
            return $"{TemperatureValue} \u00b0C";
        }
    }
}
