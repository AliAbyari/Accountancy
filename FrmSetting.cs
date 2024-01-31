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
    public partial class FrmSetting : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool ExitType = false;

        bool? ExistSetting = false;
        public FrmSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCompanyName.Text == string.Empty)
                {
                    errorProvider1.SetError(txtCompanyName, "مقداری را وارد نکرده اید");

                    txtCompanyName.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (ExistSetting == true)
                    {
                        bsSetting.EndEdit();
                        db.UpdateSetting(txtCompanyName.Text, txtFactorAddress.Text, txtFactorTel.Text, txtInvoiceAddress.Text, txtInvoiceTel.Text, txtSmsUser.Text, txtSmsPass.Text, txtSender.Text, txtMobile.Text, intAlarm1.Value, intAlarm2.Value, chkBank.Checked, chkFactor.Checked);
                    }
                    else
                    {
                        db.InsertSetting(txtCompanyName.Text, txtFactorAddress.Text, txtFactorTel.Text, txtInvoiceAddress.Text, txtInvoiceTel.Text, txtSmsUser.Text, txtSmsPass.Text, txtSender.Text, txtMobile.Text, intAlarm1.Value, intAlarm2.Value, chkBank.Checked, chkFactor.Checked);

                        ExitType = false;
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void FrmSetting_Load(object sender, EventArgs e)
        {
            try
            {
                db.ExistsSetting(ref ExistSetting);

                if (ExistSetting == true)
                {
                    bsSetting.DataSource = db.FillSetting();
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

        private void FrmSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ExitType)
            {
                Application.Exit();
            }
        }
    }
}
