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
    public partial class FrmLoginSetting : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static int LoginId = 0;

        bool? CheckPass = false;
        public FrmLoginSetting()
        {
            InitializeComponent();
        }

        private void FrmLoginSetting_Load(object sender, EventArgs e)
        {
            try
            {
                gp1.Enabled = true;
                gp2.Enabled = false;

                btnSave.Enabled = false;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtOldPass_TextChanged(object sender, EventArgs e)
        {
            try
            {
                db.CheckLoginPassById(LoginId, txtOldPass.Text, ref CheckPass);

                if (CheckPass == true)
                {
                    gp1.Enabled = false;
                    gp2.Enabled = true;
                    btnSave.Enabled = true;
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
                if (txtNewPass.Text == string.Empty)
                {
                    errorProvider1.SetError(txtNewPass, "مقداری را مشخص نکرده اید");

                    txtNewPass.Focus();
                }
                else if (txtNewPass.Text != txtRePass.Text)
                {
                    errorProvider1.Clear();

                    errorProvider1.SetError(txtRePass, "کلمه های عبور با یکدیگر همخوانی ندارند");

                    txtRePass.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    db.UpdateLoginPass(LoginId, txtNewPass.Text);

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
