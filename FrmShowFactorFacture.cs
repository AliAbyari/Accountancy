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
    public partial class FrmShowFactorFacture : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static string PersonName = "";

        public static int PersonId = 0;
        public static int SumSaleFactor = 0;
        public static int SumBuyFactor = 0;
        public FrmShowFactorFacture()
        {
            InitializeComponent();
        }

        private void FrmShowFactorFacture_Load(object sender, EventArgs e)
        {
            try
            {
                gp1.Text = "نمایش فاکتور های " + PersonName;

                bsFactor.DataSource = db.FilterFactorByPerson(PersonId);

                for (int i = 0; i < dgvFactor.Rows.Count; i++)
                {
                    if ((bool)dgvFactor.Rows[i].Cells[1].Value == false)
                    {
                        dgvFactor.Rows[i].Cells[9].Value = "فروش";
                    }
                    else
                    {
                        dgvFactor.Rows[i].Cells[9].Value = "خرید";
                    }
                }

                lblSumBuy.Text = SumBuyFactor.ToString("n0");
                lblSumSale.Text = SumSaleFactor.ToString("n0");
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport Report = new StiReport();

                Report.Load("Reports/rptFactureFactors.mrt");

                Report.Compile();

                Report["PersonId"] = PersonId;
                Report["strPersonName"] = PersonName;

                Report.ShowWithRibbonGUI();
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
    }
}
