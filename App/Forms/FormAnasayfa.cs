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
    }
}
