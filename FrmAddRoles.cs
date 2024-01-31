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
    public partial class FrmAddRoles : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool ExitType = false;
        public static bool IsEdit = false;
        public static int RoleId = 0;
        public FrmAddRoles()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRoleName.Text == string.Empty)
                {
                    errorProvider1.SetError(txtRoleName, "مقداری را مشخص نکرده اید");

                    txtRoleName.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsRoles.EndEdit();
                        db.UpdateRoles(RoleId, txtRoleName.Text, chkDepot.Checked, chkBank.Checked, chkPerson.Checked, chkFactor.Checked, chkSetting.Checked, chkUser.Checked);
                    }
                    else
                    {
                        db.InsertRoles(txtRoleName.Text, chkDepot.Checked, chkBank.Checked, chkPerson.Checked, chkFactor.Checked, chkSetting.Checked, chkUser.Checked);

                        txtRoleName.Text = string.Empty;
                        chkDepot.Checked = false;
                        chkBank.Checked = false;
                        chkFactor.Checked = false;
                        chkPerson.Checked = false;
                        chkSetting.Checked = false;
                        chkUser.Checked = false;

                        txtRoleName.Focus();

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

        private void FrmAddRoles_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsRoles.DataSource = db.FillRolesById(RoleId);
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

        private void FrmAddRoles_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ExitType)
            {
                Application.Exit();
            }
        }
    }
}
