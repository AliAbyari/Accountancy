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
    public partial class FrmAddBank : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool IsEdit = false;
        public static bool BankType = false;

        public static int BankId = 0;
        public FrmAddBank()
        {
            InitializeComponent();
        }

        private void FrmAddBank_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsBank.DataSource = db.FillBankById(BankId);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBankName.Text == string.Empty)
                {
                    errorProvider1.SetError(txtBankName, "مقداری را مشخص نکرده اید");

                    txtBankName.Focus();
                }
                else if (txtBankPerson.Text == string.Empty)
                {
                    errorProvider1.Clear();

                    errorProvider1.SetError(txtBankPerson, "مقداری را مشخص نکرده اید");

                    txtBankPerson.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsBank.EndEdit();
                        db.UpdateBank(BankId, txtBankName.Text, txtBankNumber.Text, txtBankPerson.Text, BankType);
                    }
                    else
                    {
                        db.InsertBank(txtBankName.Text, txtBankNumber.Text, txtBankPerson.Text, BankType);

                        txtBankName.Text = string.Empty;
                        txtBankNumber.Text = string.Empty;
                        txtBankPerson.Text = string.Empty;

                        txtBankName.Focus();
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
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
    }
}
