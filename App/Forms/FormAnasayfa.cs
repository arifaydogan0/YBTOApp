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
            if (listBoxUniteler.SelectedIndex == 0)
            {
                dataGridViewHastaListesi.DataSource = Test.hastalar;
            }
        }

        private void buttonYeniUniteEkle_Click(object sender, EventArgs e)
        {
            new FormAlert().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Test.hastalar.Count; i++)
            {
                Test.hastalar[i].CurrentPulse = new() { PulseValue = random.Next(60, 140) };
                Test.hastalar[i].CurrentBloodPressure = new() { DiastolikValue = random.Next(100, 135), SistolikValue = random.Next(66, 93) };
                Test.hastalar[i].CurrentSaturation = new() { SaturationValue = (double)random.Next(93, 100) / 100 };
                Test.hastalar[i].CurrentTemperature = new() { TemperatureValue = random.NextDouble() + random.Next(32, 39) };
            }
            dataGridViewHastaListesi.DataSource = Test.hastalar;
        }
    }
}

