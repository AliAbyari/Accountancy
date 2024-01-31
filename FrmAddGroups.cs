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
    public partial class FrmAddGroups : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool IsEdit = false;

        public static int GroupId = 0;
        public FrmAddGroups()
        {
            InitializeComponent();
        }

        private void FrmAddGroups_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsGroups.DataSource = db.FillGroupById(GroupId);
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
                if (txtName.Text == string.Empty)
                {
                    errorProvider1.SetError(txtName, "مقداری را مشخص نکرده اید");

                    txtName.Focus();
                }
                else if (txtUnit1.Text == string.Empty)
                {
                    errorProvider1.Clear();

                    errorProvider1.SetError(txtUnit1, "مقداری را مشخص نکرده اید");

                    txtUnit1.Focus();
                }
                else if (txtUnit2.Text == string.Empty)
                {
                    errorProvider1.Clear();

                    errorProvider1.SetError(txtUnit2, "مقداری را مشخص نکرده اید");

                    txtUnit2.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsGroups.EndEdit();

                        db.UpdateGroup(GroupId, txtName.Text, txtUnit1.Text, txtUnit2.Text);
                    }
                    else
                    {
                        db.InsertGroup(txtName.Text, txtUnit1.Text, txtUnit2.Text);

                        txtName.Text = string.Empty;
                        txtUnit1.Text = string.Empty;
                        txtUnit2.Text = string.Empty;

                        txtName.Focus();
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
