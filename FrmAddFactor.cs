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
using Stimulsoft.Report;

namespace Accountancy
{
    public partial class FrmAddFactor : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        PumkinSender sms = new PumkinSender();

        public static bool FrmType = false;

        bool? ExistSale = false;
        bool? IsFactorSend = false;
        bool? ExistMessage = false;

        int? LastFactorId = 0;
        int? DefaultDepot = 0;

        string LastSaleNumber = "";

        string RandomMessage = "";

        string MyShopName = "";
        string FactorAddress = "";
        string InvoiceAddress = "";
        string FactorTel = "";
        string InvoiceTel = "";

        double? SaleTax = 0;
        double? BuyTax = 0;

        string strToday = "";

        int TaxPrice = 0;
        int FactorPrice = 0;
        int SumPrice = 0;

        public FrmAddFactor()
        {
            InitializeComponent();
        }

        private void FrmAddFactor_Load(object sender, EventArgs e)
        {
            try
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = false;

                btnFactor.Enabled = false;
                btnPrint.Enabled = false;
                btnBook.Enabled = false;
                btnDoc.Enabled = false;

                strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                mskDate.Text = strToday;

                //chkTax.Checked = true;

                string strYear = strToday.Substring(2, 2);

                db.GetDefaultTax(ref SaleTax, ref BuyTax);

                db.GetSettingFactorSend(ref IsFactorSend);

                db.GetSettingAddress(ref FactorAddress, ref InvoiceAddress, ref FactorTel, ref InvoiceTel, ref MyShopName);

                if (FrmType)
                {
                    intBuyPrice.Visible = true;
                    intSalePrice.Visible = false;

                    txtFactor.ReadOnly = false;

                    dblTax.Value = Convert.ToDouble(BuyTax);

                    db.GetDefaultDepotId(ref DefaultDepot);
                }
                else
                {
                    intBuyPrice.Visible = false;
                    intSalePrice.Visible = true;

                    dblTax.Value = Convert.ToDouble(SaleTax);

                    txtFactor.ReadOnly = true;

                    db.ExistSaleNumber(ref ExistSale);

                    if (ExistSale == true)
                    {
                        db.GetMaxSaleNumber(ref LastSaleNumber);

                        string strLast = LastSaleNumber.Substring(3, 4);

                        if (strYear == LastSaleNumber.Substring(0, 2))
                        {
                            txtFactor.Text = strYear + "-" + (Convert.ToInt32(strLast) + 1).ToString("0000");
                        }
                        else
                        {
                            txtFactor.Text = strYear + "-" + "0001";
                        }
                    }
                    else
                    {
                        txtFactor.Text = strYear + "-" + "0001";
                    }
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
                db.InsertFactor((int)cmbPerson.SelectedValue, txtFactor.Text, mskDate.Text, dblTax.Value, FactorPrice, TaxPrice, intServicePrice.Value, intCutPrice.Value, FrmType, SumPrice);

                db.GetMaxFactorId(ref LastFactorId);

                for (int i = 0; i < dgvFactor.Rows.Count; i++)
                {
                    double MyValue = (Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvFactor.Rows[i].Cells[4].Value));
                    int MyPrice = (Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvFactor.Rows[i].Cells[4].Value)) * Convert.ToInt32(dgvFactor.Rows[i].Cells[1].Value);

                    db.InsertDetail(LastFactorId, Convert.ToInt32(dgvFactor.Rows[i].Cells[5].Value), 0, MyValue, Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value), Convert.ToInt32(dgvFactor.Rows[i].Cells[1].Value), MyPrice, false);
                }

                if (FrmType)
                {
                    for (int i = 0; i < dgvFactor.Rows.Count; i++)
                    {
                        db.InsertStock(LastFactorId, DefaultDepot, Convert.ToInt32(dgvFactor.Rows[i].Cells[5].Value), mskDate.Text, "خرید با شماره " + txtFactor.Text, Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value), 0);
                    }
                }
                else
                {
                    if (IsFactorSend == true)
                    {
                        sms.SendMessage(txtMobile.Text, "فاکتور جدید در " + MyShopName + Environment.NewLine + "جمع کل : " + SumPrice.ToString());
                    }
                }

                MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);

                btnFactor.Enabled = true;
                btnPrint.Enabled = true;
                btnBook.Enabled = true;
                btnDoc.Enabled = true;
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void txtPersonFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsPeople.DataSource = db.FilterPerson(txtPersonFilter.Text);
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (superTabControl1.SelectedTab == superTabItem1)
            {
                if (cmbPerson.Text == string.Empty)
                {
                    errorProvider1.SetError(cmbPerson, "شخصی را انتخاب نکرده اید");

                    cmbPerson.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    superTabControl1.SelectedTab = superTabItem2;
                    btnPrev.Enabled = true;
                }
            }
            else if (superTabControl1.SelectedTab == superTabItem2)
            {
                if (dgvFactor.Rows.Count == 0)
                {
                    errorProvider1.SetError(cmbProduct, "محصولی را برای فاکتور انتخاب نکرده اید");

                    cmbProduct.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    for (int i = 0; i < dgvFactor.Rows.Count; i++)
                    {
                        FactorPrice = FactorPrice + (Convert.ToInt32(dgvFactor.Rows[i].Cells[2].Value) * Convert.ToInt32(dgvFactor.Rows[i].Cells[4].Value)) * Convert.ToInt32(dgvFactor.Rows[i].Cells[1].Value);
                    }

                    chkTax.Checked = true;
                    
                    intProduct.Value = FactorPrice;

                    SumPrice = (FactorPrice + TaxPrice + intServicePrice.Value) - intCutPrice.Value;

                    intSumPrice.Value = SumPrice;

                    superTabControl1.SelectedTab = superTabItem3;
                    btnNext.Enabled = false;
                }
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (superTabControl1.SelectedTab == superTabItem2)
            {
                superTabControl1.SelectedTab = superTabItem1;

                btnPrev.Enabled = false;

            }
            else if (superTabControl1.SelectedTab == superTabItem3)
            {
                FactorPrice = 0;

                superTabControl1.SelectedTab = superTabItem2;

                btnNext.Enabled = true;
            }
        }

        private void txtProductFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsViewStock.DataSource = db.FilterViewStock(txtProductFilter.Text);

                if (FrmType == false)
                {
                    intValue2.MaxValue = Convert.ToInt32(lblStock.Text);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void intValue2_ValueChanged(object sender, EventArgs e)
        {
            txtValue1.Text = (Convert.ToInt32(txtSize.Text) * intValue2.Value).ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (FrmType)
            {
                dgvFactor.Rows.Add(cmbProduct.Text, intBuyPrice.Text, intValue2.Text, txtUnit2.Text, txtSize.Text, cmbProduct.SelectedValue);
            }
            else
            {
                dgvFactor.Rows.Add(cmbProduct.Text, intSalePrice.Text, intValue2.Text, txtUnit2.Text, txtSize.Text, cmbProduct.SelectedValue);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dgvFactor.Rows.RemoveAt(dgvFactor.CurrentRow.Index);
        }

        private void chkTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTax.Checked)
            {
                TaxPrice = Convert.ToInt32(FactorPrice * dblTax.Value);
            }
            else
            {
                TaxPrice = 0;
            }

            SumPrice = (FactorPrice + TaxPrice + intServicePrice.Value) - intCutPrice.Value;

            intTax.Value = TaxPrice;
            intSumPrice.Value = SumPrice;
        }

        private void intServicePrice_ValueChanged(object sender, EventArgs e)
        {
            SumPrice = (FactorPrice + TaxPrice + intServicePrice.Value) - intCutPrice.Value;

            intSumPrice.Value = SumPrice;
        }

        private void intCutPrice_ValueChanged(object sender, EventArgs e)
        {
            SumPrice = (FactorPrice + TaxPrice + intServicePrice.Value) - intCutPrice.Value;

            intSumPrice.Value = SumPrice;
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            try
            {
                db.ExistsMessage(ref ExistMessage);

                StiReport Report = new StiReport();

                Report.Load("Reports/rptFactor.mrt");

                Report.Compile();

                Report["FactorId"] = LastFactorId;
                Report["strAddress"] = FactorAddress;
                Report["strTel"] = FactorTel;
                Report["strMobile"] = txtMobile.Text;
                Report["strName"] = cmbPerson.Text;

                if (ExistMessage == true)
                {
                    db.GetRandomMessage(ref RandomMessage);
                }

                Report["strMessage"] = RandomMessage;

                if (FrmType)
                {
                    Report["strType"] = "فاکتور خرید";
                }
                else
                {
                    Report["strType"] = "فاکتور فروش";
                }

                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport Report = new StiReport();

                Report.Load("Reports/rptFactorDepot.mrt");

                Report.Compile();

                Report["FactorId"] = LastFactorId;
                Report["strAddress"] = InvoiceAddress;
                Report["strTel"] = InvoiceTel;
                Report["strMobile"] = txtMobile.Text;
                Report["strName"] = cmbPerson.Text;
                
                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            FrmAddBook.IsEdit = false;

            if (FrmType)
            {
                FrmAddBook.CostGroupType = 2;
                FrmAddBook.strDes = "خرید از " + cmbPerson.Text;
            }
            else
            {
                FrmAddBook.CostGroupType = 1;
                FrmAddBook.strDes = "فروش به " + cmbPerson.Text;
            }

            FrmAddBook.intSaleBuy = SumPrice;
            FrmAddBook.PersonId = (int)cmbPerson.SelectedValue;

            new FrmAddBook().ShowDialog();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            FrmAddDocument.IsEdit = false;

            if (FrmType)
            {
                FrmAddDocument.CostGroupType = 2;
                FrmAddDocument.strDes = "خرید از " + cmbPerson.Text;
            }
            else
            {
                FrmAddDocument.CostGroupType = 1;
                FrmAddDocument.strDes = "فروش به " + cmbPerson.Text;
            }

            FrmAddDocument.intSaleBuy = SumPrice;
            FrmAddDocument.PersonId = (int)cmbPerson.SelectedValue;

            new FrmAddDocument().ShowDialog();
        }

        private void dblTax_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void chkTax_CheckValueChanged(object sender, EventArgs e)
        {

        }
    }
}
