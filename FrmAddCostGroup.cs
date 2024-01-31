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
    public partial class FrmAddCostGroup : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool IsEdit = false;
        public static bool CostType = false;

        //DarAmad = 1 Hazine = 0

        public static int CostGroupId = 0;
        public FrmAddCostGroup()
        {
            InitializeComponent();
        }

        private void FrmAddCostGroup_Load(object sender, EventArgs e)
        {
            try
            {
                if (CostType)
                {
                    gp1.Text = "ثبت مشخصات درآمد";
                }
                else
                {
                    gp1.Text = "ثبت مشخصات هزینه";
                }

                if (IsEdit)
                {
                    bsCostGroup.DataSource = db.FillCostGroupById(CostGroupId);
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
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsCostGroup.EndEdit();

                        db.UpdateCostGroup(CostGroupId, CostType, false, txtName.Text, txtDes.Text);
                    }
                    else
                    {
                        db.InsertCostGroup(CostType, false, txtName.Text, txtDes.Text);

                        txtName.Text = string.Empty;
                        txtDes.Text = string.Empty;

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
