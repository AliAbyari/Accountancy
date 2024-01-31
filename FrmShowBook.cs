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
    public partial class FrmShowBook : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        public static int BankId = 0;

        public static string BankName = "";

        string strToday = "";

        int? SumBook = 0;
        public FrmShowBook()
        {
            InitializeComponent();
        }

        private void FrmShowBook_Load(object sender, EventArgs e)
        {
            try
            {
                gp1.Text = "نمایش لیست تراکنش های حساب " + BankName;

                strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                db.GetSumBook(BankId, ref SumBook);

                lblSum.Text = SumBook.ToString();

                mskDate1.Text = strToday;
                mskDate2.Text = strToday;
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
                bsBook.DataSource = db.FilterBookByDate(BankId, mskDate1.Text, mskDate2.Text);

                if (dgvBook.Rows.Count == 0)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
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
                bsBook.DataSource = db.FilterBookByDate(BankId, mskDate1.Text, mskDate2.Text);

                if (dgvBook.Rows.Count == 0)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddBook.IsEdit = false;
                FrmAddBook.BankId = BankId;

                FrmAddBook.BankName = BankName;

                FrmAddBook.CostGroupType = 0;

                new FrmAddBook().ShowDialog();

                db.GetSumBook(BankId, ref SumBook);

                lblSum.Text = SumBook.ToString();

                bsBook.DataSource = db.FilterBookByDate(BankId, mskDate1.Text, mskDate2.Text);

                if (dgvBook.Rows.Count == 0)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddBook.IsEdit = true;
                FrmAddBook.BankId = BankId;
                FrmAddBook.BookId = (int)dgvBook.CurrentRow.Cells[0].Value;
                FrmAddBook.CostId = (int)dgvBook.CurrentRow.Cells[2].Value;
                FrmAddBook.PersonId = (int)dgvBook.CurrentRow.Cells[3].Value;

                if ((int)dgvBook.CurrentRow.Cells[2].Value == 7)
                {
                    FrmAddBook.CostGroupType = 7;
                }
                else if ((int)dgvBook.CurrentRow.Cells[2].Value == 8)
                {
                    FrmAddBook.CostGroupType = 8;
                }
                else if ((int)dgvBook.CurrentRow.Cells[2].Value == 2)
                {
                    FrmAddBook.CostGroupType = 2;
                }
                else if ((int)dgvBook.CurrentRow.Cells[2].Value == 1)
                {
                    FrmAddBook.CostGroupType = 1;
                }
                else
                {
                    FrmAddBook.CostGroupType = 0;
                }

                new FrmAddBook().ShowDialog();

                db = new dcAccountancyDataContext();

                db.GetSumBook(BankId, ref SumBook);

                lblSum.Text = SumBook.ToString();

                bsBook.DataSource = db.FilterBookByDate(BankId, mskDate1.Text, mskDate2.Text);

                if (dgvBook.Rows.Count == 0)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
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
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این تراکنش هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteBook((int)dgvBook.CurrentRow.Cells[0].Value);

                    db.GetSumBook(BankId, ref SumBook);

                    lblSum.Text = SumBook.ToString();

                    bsBook.DataSource = db.FilterBookByDate(BankId, mskDate1.Text, mskDate2.Text);

                    if (dgvBook.Rows.Count == 0)
                    {
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport Report = new StiReport();

                Report.Load("Reports/rptShowBook.mrt");

                Report.Compile();

                Report["strDate1"] = mskDate1.Text;
                Report["strDate2"] = mskDate2.Text;
                Report["intBankId"] = BankId;
                Report["strBankName"] = BankName;
                Report["intSumBank"] = SumBook;

                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
