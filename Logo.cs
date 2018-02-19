using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace The_Database_Project
{
    public partial class Logo : Form
    {
        int wait = 3000;

        #region Constructor
        public Logo()
        {
            InitializeComponent();
        }
        #endregion

        #region TIMER CODE
        private void timer1_Tick(object sender, EventArgs e)
        {
            wait -= timer1.Interval;
            if (wait < 0)
                wait = 0;
            if (wait == 0)
            {
                this.Hide();
                Form1 main = new Form1();
                main.Show();
                timer1.Stop();
            }
        }
        #endregion
    }
}
