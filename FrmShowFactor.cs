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
using Stimulsoft.Report;

namespace Accountancy
{
    public partial class FrmShowFactor : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        public static bool FrmType = false;

        string strToday = "";
        public FrmShowFactor()
        {
            InitializeComponent();
        }

        private void FrmShowFactor_Load(object sender, EventArgs e)
        {
            try
            {
                strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                mskDate1.Text = strToday;
                mskDate2.Text = strToday;

                if (FrmType)
                {
                    bsFactor.DataSource = db.FilterBuyByDate(mskDate1.Text, mskDate2.Text);
                }
                else
                {
                    bsFactor.DataSource = db.FilterSaleByDate(mskDate1.Text, mskDate2.Text);
                }

                if (dgvFactor.Rows.Count == 0)
                {
                    btnShow.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnShow.Enabled = true;
                    btnDelete.Enabled = true;
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
                if (FrmType)
                {
                    bsFactor.DataSource = db.FilterBuyByDate(mskDate1.Text, mskDate2.Text);
                }
                else
                {
                    bsFactor.DataSource = db.FilterSaleByDate(mskDate1.Text, mskDate2.Text);
                }

                if (dgvFactor.Rows.Count == 0)
                {
                    btnShow.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnShow.Enabled = true;
                    btnDelete.Enabled = true;
                }
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
                if (FrmType)
                {
                    bsFactor.DataSource = db.FilterBuyByDate(mskDate1.Text, mskDate2.Text);
                }
                else
                {
                    bsFactor.DataSource = db.FilterSaleByDate(mskDate1.Text, mskDate2.Text);
                }

                if (dgvFactor.Rows.Count == 0)
                {
                    btnShow.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnShow.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا از حذف این فاکتور اطمینان دارید؟", "تأیید حذف فاکتور", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteFactor((int)dgvFactor.CurrentRow.Cells[0].Value);

                    if (FrmType)
                    {
                        bsFactor.DataSource = db.FilterBuyByDate(mskDate1.Text, mskDate2.Text);
                    }
                    else
                    {
                        bsFactor.DataSource = db.FilterSaleByDate(mskDate1.Text, mskDate2.Text);
                    }

                    if (dgvFactor.Rows.Count == 0)
                    {
                        btnShow.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnShow.Enabled = true;
                        btnDelete.Enabled = true;
                    }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddFactor.FrmType = FrmType;

            new FrmAddFactor().ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FrmConfirm.FactorId = (int)dgvFactor.CurrentRow.Cells[0].Value;

            FrmConfirm.FrmType = (bool)dgvFactor.CurrentRow.Cells[2].Value;

            new FrmConfirm().ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport Report = new StiReport();

                if (FrmType)
                {
                    Report.Load("Reports/rptShowBuy.mrt");
                }
                else
                {
                    Report.Load("Reports/rptShowSale.mrt");
                }

                Report.Compile();

                Report["strDate1"] = mskDate1.Text;
                Report["strDate2"] = mskDate2.Text;

                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
