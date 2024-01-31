using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using Stimulsoft.Report;

namespace Accountancy
{
    public partial class FrmShowStock : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public FrmShowStock()
        {
            InitializeComponent();
        }

        private void FrmShowStock_Load(object sender, EventArgs e)
        {
            try
            {
                bsViewStock.DataSource = db.FilterViewStock(txtFilter.Text);

                if (dgvStock.Rows.Count == 0)
                {
                    btnDetails.Enabled = false;
                }
                else
                {
                    btnDetails.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSelectedDepot.ProductId = (int)dgvStock.CurrentRow.Cells[0].Value;
                FrmSelectedDepot.SumStock = (int)dgvStock.CurrentRow.Cells[6].Value;
                FrmSelectedDepot.ProductName = dgvStock.CurrentRow.Cells[2].Value.ToString();
                FrmSelectedDepot.GroupName = dgvStock.CurrentRow.Cells[3].Value.ToString();

                new FrmSelectedDepot().ShowDialog();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsViewStock.DataSource = db.FilterViewStock(txtFilter.Text);

                if (dgvStock.Rows.Count == 0)
                {
                    btnDetails.Enabled = false;
                }
                else
                {
                    btnDetails.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport Report = new StiReport();

                Report.Load("Reports/rptStock.mrt");

                Report.Compile();

                Report["strName"] = txtFilter.Text;

                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
