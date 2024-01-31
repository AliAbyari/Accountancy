using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using System.Globalization;

namespace Accountancy
{
    public partial class FrmInOutStock : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        public static bool InOut = false;

        int? SumStock = 0;

        string strToday = "";
        public FrmInOutStock()
        {
            InitializeComponent();
        }

        private void FrmInOutStock_Load(object sender, EventArgs e)
        {
            try
            {
                bsDepot.DataSource = db.FillDepot();

                if (InOut)
                {
                    gp1.Text = "ورود محصول بصورت دستی";
                }
                else
                {
                    gp1.Text = "خروج محصول بصورت دستی";
                }

                strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                mskDate.Text = strToday;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsProduct.DataSource = db.FilterProduct(txtFilter.Text);
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
                if (InOut)
                {
                    db.InsertStock(0, (int)cmbDepot.SelectedValue, (int)cmbProduct.SelectedValue, mskDate.Text, txtDes.Text, intInOut.Value, 0);
                }
                else
                {
                    db.GetProductStockInDepot((int)cmbDepot.SelectedValue, (int)cmbProduct.SelectedValue, ref SumStock);

                    if (intInOut.Value > SumStock)
                    {
                        errorProvider1.SetError(intInOut, "موجودی کافی نیست");

                        intInOut.Focus();
                    }
                    else
                    {
                        errorProvider1.Clear();

                        db.InsertStock(0, (int)cmbDepot.SelectedValue, (int)cmbProduct.SelectedValue, mskDate.Text, txtDes.Text, 0, intInOut.Value);

                        MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
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
    }
}
