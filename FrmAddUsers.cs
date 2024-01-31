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
    public partial class FrmAddUsers : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool ExitType = false;
        public static bool IsEdit = false;
        public static int UserId = 0;
        public static int RoleId = 0;

        bool? CheckName = false;
        public FrmAddUsers()
        {
            InitializeComponent();
        }

        private void FrmAddUsers_Load(object sender, EventArgs e)
        {
            try
            {
                bsRoles.DataSource = db.FillRoles();

                if (IsEdit)
                {
                    bsUsers.DataSource = db.FillUsersById(UserId);

                    cmbRoles.SelectedValue = RoleId;

                    txtUser.ReadOnly = true;
                }
                else
                {
                    txtUser.ReadOnly = false;
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
                if (txtUser.Text == string.Empty)
                {
                    errorProvider1.SetError(txtUser, "مقداری را مشخص نکرده اید");

                    txtUser.Focus();
                }
                else if (txtPass.Text == string.Empty)
                {
                    errorProvider1.Clear();

                    errorProvider1.SetError(txtPass, "مقداری را مشخص نکرده اید");

                    txtPass.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsUsers.EndEdit();
                        db.UpdateUsers(UserId, (int)cmbRoles.SelectedValue, txtUser.Text, txtPass.Text);
                    }
                    else
                    {
                        db.CheckUsersName(ref CheckName, txtUser.Text);

                        if (CheckName == true)
                        {
                            errorProvider1.SetError(txtUser, "نام کاربری تکراری است");

                            txtUser.Focus();
                        }
                        else
                        {
                            errorProvider1.Clear();

                            db.InsertUsers((int)cmbRoles.SelectedValue, txtUser.Text, txtPass.Text);

                            if (ExitType == true)
                            {
                                this.Close();
                            }

                            txtUser.Text = string.Empty;
                            txtPass.Text = string.Empty;

                            txtUser.Focus();
                        }
                    }
                }

                MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
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

        private void FrmAddUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ExitType)
            {
                Application.Exit();
            }
        }
    }
}
