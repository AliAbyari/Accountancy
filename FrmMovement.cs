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
    public partial class FrmMovement : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        int? SumStock = 0;

        string strToday = "";
        public FrmMovement()
        {
            InitializeComponent();
        }

        private void FrmMovement_Load(object sender, EventArgs e)
        {
            try
            {
                strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                mskDate.Text = strToday;

                bsDepot1.DataSource = db.FillDepot();
                bsDepot2.DataSource = db.FillDepot();
                
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
                if ((int)cmbDepot1.SelectedValue == (int)cmbDepot2.SelectedValue)
                {
                    errorProvider1.SetError(intValue, "در انتخاب انبار ها دقت کنید");

                    intValue.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    db.GetProductStockInDepot((int)cmbDepot1.SelectedValue, (int)cmbProduct.SelectedValue, ref SumStock);

                    if (intValue.Value > SumStock)
                    {
                        errorProvider1.SetError(intValue, "موجودی کافی نیست");

                        intValue.Focus();
                    }
                    else
                    {
                        errorProvider1.Clear();

                        db.InsertStock(0, (int)cmbDepot1.SelectedValue, (int)cmbProduct.SelectedValue, mskDate.Text, "جابجایی به " + cmbDepot2.Text, 0, intValue.Value);
                        db.InsertStock(0, (int)cmbDepot2.SelectedValue, (int)cmbProduct.SelectedValue, mskDate.Text, "جابجایی از " + cmbDepot1.Text, intValue.Value, 0);

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
    }
}
