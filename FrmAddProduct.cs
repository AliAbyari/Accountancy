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
    public partial class FrmAddProduct : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool IsEdit = false;

        public static int ProductId = 0;
        public static int GroupId = 0;
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            try
            {
                bsGroup.DataSource = db.FillGroup();

                if (IsEdit)
                {
                    bsProduct.DataSource = db.FillProductById(ProductId);

                    cmbGroup.SelectedValue = GroupId;
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
                if (cmbGroup.Text == string.Empty)
                {
                    errorProvider1.SetError(cmbGroup, "هنوز گروهی مشخص نکرده اید");

                    cmbGroup.Focus();
                }
                else if (txtName.Text == string.Empty)
                {
                    errorProvider1.Clear();

                    errorProvider1.SetError(txtName, "مقداری را مشخص نکرده اید");

                    txtName.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsProduct.EndEdit();

                        db.UpdateProduct(ProductId, (int)cmbGroup.SelectedValue, txtName.Text, (double)dblSize.Value, (int)intPrice.Value, (int)intAlarm.Value, txtDes.Text);
                    }
                    else
                    {
                        db.InsertProduct((int)cmbGroup.SelectedValue, txtName.Text, (double)dblSize.Value, (int)intPrice.Value, (int)intAlarm.Value, txtDes.Text);

                        txtName.Text = string.Empty;
                        txtDes.Text = string.Empty;
                        intPrice.Value = 0;
                        intAlarm.Value = 0;
                        dblSize.Value = 0;

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
