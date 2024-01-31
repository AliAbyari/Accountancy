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
    public partial class FrmFactorReport : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        string strToday = "";

        int? SumBook = 0;
        int? SumFactor = 0;

        public static bool FrmType = false;

        public FrmFactorReport()
        {
            InitializeComponent();
        }

        private void FrmFactorReport_Load(object sender, EventArgs e)
        {
            try
            {
                strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                mskDate1.Text = strToday;
                mskDate2.Text = strToday;

                if (FrmType)
                {
                    gp1.Text = "نمایش آمار خرید";
                }
                else
                {
                    gp1.Text = "نمایش آمار فروش";
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void mskDate1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int intSumBook = 0;
                int intSumFactor = 0;

                if (FrmType)
                {
                    bsViewFactor.DataSource = db.FilterBuyReport(mskDate1.Text, mskDate2.Text);

                    db.GetSumBuyReport(mskDate1.Text, mskDate2.Text, ref SumFactor, ref SumBook);
                }
                else
                {
                    bsViewFactor.DataSource = db.FilterSaleReport(mskDate1.Text, mskDate2.Text);

                    db.GetSumSaleReport(mskDate1.Text, mskDate2.Text, ref SumFactor, ref SumBook);
                }

                intSumBook = (int)SumBook;
                intSumFactor = (int)SumFactor;

                lblSumBook.Text = intSumBook.ToString("n0");
                lblSumFactor.Text = intSumFactor.ToString("n0");
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void mskDate2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int intSumBook = 0;
                int intSumFactor = 0;

                if (FrmType)
                {
                    bsViewFactor.DataSource = db.FilterBuyReport(mskDate1.Text, mskDate2.Text);

                    db.GetSumBuyReport(mskDate1.Text, mskDate2.Text, ref SumFactor, ref SumBook);
                }
                else
                {
                    bsViewFactor.DataSource = db.FilterSaleReport(mskDate1.Text, mskDate2.Text);

                    db.GetSumSaleReport(mskDate1.Text, mskDate2.Text, ref SumFactor, ref SumBook);
                }

                intSumBook = (int)SumBook;
                intSumFactor = (int)SumFactor;

                lblSumBook.Text = intSumBook.ToString("n0");
                lblSumFactor.Text = intSumFactor.ToString("n0");
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
