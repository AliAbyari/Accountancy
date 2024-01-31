using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;

namespace Accountancy
{
    public partial class FrmSelectedBank : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public FrmSelectedBank()
        {
            InitializeComponent();
        }

        private void FrmSelectedBank_Load(object sender, EventArgs e)
        {
            try
            {
                chk1.Checked = true;
                chk2.Checked = false;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk1.Checked)
                {
                    bsBank.DataSource = db.FillBankType1();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk2.Checked)
                {
                    bsBank.DataSource = db.FillBankType2();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void dgvSelect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmShowDocument.BankId = (int)dgvSelect.CurrentRow.Cells[0].Value;

            new FrmShowDocument().ShowDialog();
        }
    }
}
