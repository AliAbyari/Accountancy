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
    public partial class FrmSelectStock : Form
    {
        public FrmSelectStock()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FrmInOutStock.InOut = true;

            new FrmInOutStock().ShowDialog();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            FrmInOutStock.InOut = false;

            new FrmInOutStock().ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
