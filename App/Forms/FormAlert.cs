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

namespace App.Forms
{
    public partial class FormAlert : Form
    {
        private bool autoOpen;
        Patient Patient;
        private int pI;
        public FormAlert(int patientIndex, bool autoOpen = true)
        {
            InitializeComponent();
            Patient = Test.hastalar[patientIndex];
            pI = patientIndex;
            this.autoOpen = autoOpen;
        }

        private void FormAlert_Load(object sender, EventArgs e)
        {
            labelName.Text = Patient.Name + " " + Patient.LastName;
            labelYas.Text = (DateTime.Now.Year - Patient.BirthDate.Year).ToString();
            labelYatakNo.Text = pI.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDurum.Text = Patient.IsNormal ? "Stabil" : "ACİL!";
            labelDurum.ForeColor = Patient.IsNormal ? Color.Green : Color.Red;
            labelAtes.Text = Patient.CurrentTemperature?.ToString() + "  " + Temperature.Statuses[Patient.CurrentTemperature.StatusIndex];
            labelAtes.ForeColor = Patient.CurrentTemperature.StatusIndex == 0 ? Color.Green : Color.Red;
            labelNabiz.Text = Patient.CurrentPulse?.ToString() + "  " + Pulse.Statuses[Patient.CurrentPulse.StatusIndex];
            labelNabiz.ForeColor = Patient.CurrentPulse.StatusIndex == 0 ? Color.Green : Color.Red;
            labelTansiyon.Text = Patient.CurrentBloodPressure?.ToString() + "  " + BloodPressure.Statuses[Patient.CurrentBloodPressure.StatusIndex];
            labelTansiyon.ForeColor = Patient.CurrentBloodPressure.StatusIndex == 0 ? Color.Green : Color.Red;
            labelSaturasyon.Text = Patient.CurrentSaturation?.ToString() + "  " + Saturation.Statuses[Patient.CurrentSaturation.StatusIndex];
            labelSaturasyon.ForeColor = Patient.CurrentSaturation.StatusIndex == 0 ? Color.Green : Color.Red;

            if(Patient.IsNormal && autoOpen)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormEkg().ShowDialog();
        }

        private void FormAlert_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormAnasayfa.acilIndexler.Remove(pI);
        }
    }
}
