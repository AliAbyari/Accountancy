using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accountancy
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbSplash.Value += 10;

            if (pbSplash.Value == 100)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {

        }
    }
}
