using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models;
using App.Models.MedicalDatas;
using Microsoft.CSharp.RuntimeBinder;

namespace App.Forms
{
    public partial class FormAnasayfa : Form
    {
        private Random random = new();
        public FormAnasayfa()
        {
            InitializeComponent();
        }

        private void listBoxUniteler_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Text = listBoxUniteler.Text;
        }

        private void buttonYeniUniteEkle_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridViewHastaListesi.RowCount = Test.hastalar.Count;
            for (int i = 0; i < Test.hastalar.Count; i++)
            {
                var currentBloodPressure = Test.hastalar[i].CurrentBloodPressure;
                if (currentBloodPressure != null)
                {
                    var bloodPressureSistolic = currentBloodPressure.SistolikValue;
                    currentBloodPressure.SistolikValue = random.Next(bloodPressureSistolic - 2, bloodPressureSistolic + 3);
                    var bloodPressureDiastolic = currentBloodPressure.DiastolikValue;
                    currentBloodPressure.DiastolikValue = random.Next(bloodPressureDiastolic - 2, bloodPressureDiastolic + 3);
                }

                var currentPulse = Test.hastalar[i].CurrentPulse;
                if (currentPulse != null)
                {
                    var pulse = currentPulse.PulseValue;
                    currentPulse.PulseValue = random.Next(pulse - 1, pulse + 2);
                }

                var currentSaturation = Test.hastalar[i].CurrentSaturation;
                if (currentSaturation != null)
                {
                    var saturation = (int)(currentSaturation.SaturationValue * 100);
                    currentSaturation.SaturationValue = (double)random.Next(saturation - 1, saturation + 2) / 100;
                }

                var currentTemperature = Test.hastalar[i].CurrentTemperature;
                if (currentTemperature != null)
                {
                    var temp = (int)(currentTemperature.TemperatureValue * 100);
                    currentTemperature.TemperatureValue = (double)random.Next(temp - 6, temp + 7) / 100;
                }

                var hasta = Test.hastalar[i];
                dataGridViewHastaListesi.Rows[i].Cells[0].Value = hasta.Name + " " + hasta.LastName;
                dataGridViewHastaListesi.Rows[i].Cells[1].Value = DateTime.Now.Year - hasta.BirthDate.Year;
                dataGridViewHastaListesi.Rows[i].Cells[2].Value = hasta.BloodGroup;

                dataGridViewHastaListesi.Rows[i].Cells[3].Value = hasta.CurrentPulse?.StatusIndex == 0 ? hasta.CurrentPulse?.ToString() : $"{hasta.CurrentPulse} ({Pulse.Statuses[hasta.CurrentPulse.StatusIndex]})";
                dataGridViewHastaListesi.Rows[i].Cells[3].Style.BackColor = hasta.CurrentPulse?.StatusIndex == 0 ? Color.AliceBlue : Color.OrangeRed;

                dataGridViewHastaListesi.Rows[i].Cells[4].Value = hasta.CurrentTemperature.StatusIndex == 0 ? hasta.CurrentTemperature?.ToString() : $"{hasta.CurrentTemperature.ToString()} ({Temperature.Statuses[hasta.CurrentTemperature.StatusIndex]})";
                dataGridViewHastaListesi.Rows[i].Cells[4].Style.BackColor = hasta.CurrentTemperature?.StatusIndex == 0 ? Color.AliceBlue : Color.OrangeRed;

                dataGridViewHastaListesi.Rows[i].Cells[5].Value = hasta.CurrentBloodPressure?.StatusIndex == 0 ? hasta.CurrentBloodPressure?.ToString() : $"{hasta.CurrentBloodPressure.ToString()} ({BloodPressure.Statuses[hasta.CurrentBloodPressure.StatusIndex]})";
                dataGridViewHastaListesi.Rows[i].Cells[5].Style.BackColor = hasta.CurrentBloodPressure?.StatusIndex == 0 ? Color.AliceBlue : Color.OrangeRed;

                dataGridViewHastaListesi.Rows[i].Cells[6].Value = hasta.CurrentSaturation?.StatusIndex == 0 ? hasta.CurrentSaturation?.ToString() : $"{hasta.CurrentSaturation.ToString()} ({Saturation.Statuses[hasta.CurrentSaturation.StatusIndex]})";
                dataGridViewHastaListesi.Rows[i].Cells[6].Style.BackColor = hasta.CurrentSaturation?.StatusIndex == 0 ? Color.AliceBlue : Color.OrangeRed;

                dataGridViewHastaListesi.Rows[i].Cells[7].Value = hasta.IsNormal ? "Stabil" : "Acil!";
                dataGridViewHastaListesi.Rows[i].Cells[7].Style.ForeColor = hasta.IsNormal ? Color.Green : Color.Red;
            }
            //dataGridViewHastaListesi.Refresh();
        }

        private void dataGridViewHastaListesi_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridViewHastaListesi.SelectedRows[0].Index;
            new FormAlert(index).ShowDialog();
        }
    }
}

