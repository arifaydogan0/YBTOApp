using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models.MedicalDatas.Graphs
{
    internal class EKG
    {
        public int Status { get; set; }
        public decimal Pwave { get; set; }
        public decimal Qwave { get; set; }
        public decimal Rwave { get; set; }
        public decimal Swave { get; set; }
        public decimal Twave { get; set; }
    }
}
