using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lab2_RapidApplicationD
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashFormTimer.Enabled = false;
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }
    }
 
}
