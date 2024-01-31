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
    public partial class FrmShowBank : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool BankType = false;
        public FrmShowBank()
        {
            InitializeComponent();
        }

        private void FrmShowBank_Load(object sender, EventArgs e)
        {
            try
            {
                if (BankType)
                {
                    bsBank.DataSource = db.FillBankType2();

                    btnBook.Visible = false;
                }
                else
                {
                    bsBank.DataSource = db.FillBankType1();

                    btnBook.Visible = true;
                }

                if (dgvBank.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnBook.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnBook.Enabled = true;
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
                FrmAddBank.IsEdit = false;

                FrmAddBank.BankType = BankType;

                new FrmAddBank().ShowDialog();

                if (BankType)
                {
                    bsBank.DataSource = db.FillBankType2();
                }
                else
                {
                    bsBank.DataSource = db.FillBankType1();
                }

                if (dgvBank.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnBook.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnBook.Enabled = true;
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
                FrmAddBank.IsEdit = true;
                FrmAddBank.BankId = (int)dgvBank.CurrentRow.Cells[0].Value;
                FrmAddBank.BankType = BankType;

                new FrmAddBank().ShowDialog();

                db = new dcAccountancyDataContext();

                if (BankType)
                {
                    bsBank.DataSource = db.FillBankType2();
                }
                else
                {
                    bsBank.DataSource = db.FillBankType1();
                }

                if (dgvBank.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnBook.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnBook.Enabled = true;
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
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این حساب هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteBank((int)dgvBank.CurrentRow.Cells[0].Value);

                    if (BankType)
                    {
                        bsBank.DataSource = db.FillBankType2();
                    }
                    else
                    {
                        bsBank.DataSource = db.FillBankType1();
                    }

                    if (dgvBank.Rows.Count == 0)
                    {
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                        btnBook.Enabled = false;
                    }
                    else
                    {
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                        btnBook.Enabled = true;
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            FrmShowBook.BankId = (int)dgvBank.CurrentRow.Cells[0].Value;
            FrmShowBook.BankName = dgvBank.CurrentRow.Cells[1].Value.ToString();

            new FrmShowBook().ShowDialog();
        }
    }
}
