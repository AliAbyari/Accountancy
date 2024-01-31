using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using System.Globalization;

namespace Accountancy
{
    public partial class FrmMoneyReport : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        string strToday = "";

        int? Cost1 = 0;
        int? Cost2 = 0;
        int? Sale = 0;
        int? Buy = 0;
        int? Doc1 = 0;
        int? Doc2 = 0;

        public FrmMoneyReport()
        {
            InitializeComponent();
        }

        private void FrmMoneyReport_Load(object sender, EventArgs e)
        {
            chkDate.Checked = true;
            mskDate1.Enabled = true;
            mskDate2.Enabled = true;

            chkYear.Checked = false;
            mskYear.Enabled = false;

            strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

            mskDate1.Text = strToday;
            mskDate2.Text = strToday;

            mskYear.Text = strToday.Substring(0, 4);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                int intCost1 = 0;
                int intCost2 = 0;
                int intDoc1 = 0;
                int intDoc2 = 0;
                int intSale = 0;
                int intBuy = 0;

                if (chkDate.Checked)
                {
                    db.GetMoenyReportByDate(ref Cost1, ref Cost2, ref Sale, ref Buy, ref Doc1, ref Doc2, mskDate1.Text, mskDate2.Text);
                }
                else
                {
                    db.GetMoenyReportByYear(ref Cost1, ref Cost2, ref Sale, ref Buy, ref Doc1, ref Doc2, mskYear.Text);
                }

                intCost1 = (int)Cost1;
                intCost2 = (int)Cost2;

                intDoc1 = (int)Doc1;
                intDoc2 = (int)Doc2;

                intSale = (int)Sale;
                intBuy = (int)Buy;

                lblBuy.Text = intBuy.ToString("n0");
                lblSale.Text = intSale.ToString("n0");
                lblCost1.Text = intCost1.ToString("n0");
                lblCost2.Text = intCost2.ToString("n0");
                lblDoc1.Text = intDoc1.ToString("n0");
                lblDoc2.Text = intDoc2.ToString("n0");
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            mskDate1.Enabled = chkDate.Checked;
            mskDate2.Enabled = chkDate.Checked;
        }

        private void chkYear_CheckedChanged(object sender, EventArgs e)
        {
            mskYear.Enabled = chkYear.Checked;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
