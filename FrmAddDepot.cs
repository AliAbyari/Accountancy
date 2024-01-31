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
    public partial class FrmAddDepot : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool IsEdit = false;

        public static int DepotId = 0;
        public FrmAddDepot()
        {
            InitializeComponent();
        }

        private void FrmAddDepot_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsDepot.DataSource = db.FillDepotById(DepotId);
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
                if (txtDepotName.Text == string.Empty)
                {
                    errorProvider1.SetError(txtDepotName, "مقداری را مشخص نکرده اید");

                    txtDepotName.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsDepot.EndEdit();

                        db.UpdateDepot(DepotId, txtDepotName.Text);
                    }
                    else
                    {
                        db.InsertDepot(txtDepotName.Text);

                        txtDepotName.Text = string.Empty;

                        txtDepotName.Focus();
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
