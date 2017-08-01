using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorithmDataStructures
{
    public partial class Splashscreen : Form
    {
        Timer tmr;// User timer class
        public Splashscreen()
        {
            InitializeComponent();
        }

        private void Splashscreen_Load(object sender, EventArgs e)
        {

        }

        private void Splashscreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval to 3 seconds
            tmr.Interval = 3000;
            //start the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;

            //progress bar
            int i;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            //after three seconds stop the timer
            tmr.Stop();
            //display Main form
            MainForm mf = new MainForm();
            mf.Show();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
