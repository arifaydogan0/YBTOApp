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
        public FormAlert()
        {
            InitializeComponent();
        }

        private void FormAlert_Load(object sender, EventArgs e)
        {
            Patient patient = Test.hastalar[3];
            label1.Text = patient.Name + " " + patient.LastName;
            label2.Text = patient.CurrentPulse.ToString();
            label3.Text = Pulse.Statuses[patient.CurrentPulse.StatusIndex];
        }
    }
}
