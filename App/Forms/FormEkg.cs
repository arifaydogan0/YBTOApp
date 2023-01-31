using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Forms
{
    public partial class FormEkg : Form
    {
        List<Image> images = new() { Resource1.ekg01, Resource1.ekg02, Resource1.ekg03, Resource1.ekg04, Resource1.ekg05, Resource1.ekg06, Resource1.ekg07, Resource1.ekg08 };
        private int index = 0;
        public FormEkg()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = images[index];
            index++;
            if (index == images.Count)
                index = 0;
            timer1.Interval = new Random().Next(25, 500);
        }
    }
}
