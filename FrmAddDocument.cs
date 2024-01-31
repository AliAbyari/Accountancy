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
    public partial class FrmAddDocument : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        public static bool IsEdit = true;

        bool? DocExist = false;

        public static int DocId = 0;
        public static int CostId = 0;
        public static int BankId = 0;
        public static int PersonId = 0;
        public static int CostGroupType = 0;
        public static int intSaleBuy = 0;

        public static string strDes = "";

        int OldPrice = 0;

        string strToday = "";
        public FrmAddDocument()
        {
            InitializeComponent();
        }

        private void FrmAddDocument_Load(object sender, EventArgs e)
        {
            try
            {
                if (CostGroupType != 0)
                {
                    cmbBank.Visible = true;
                    lblBank.Visible = true;

                    cmbCostGroup.Visible = false;
                    lblCost.Visible = false;

                    if (CostGroupType == 7)
                    {
                        bsBank.DataSource = db.FillBankType2();
                    }
                    else if (CostGroupType == 8)
                    {
                        bsBank.DataSource = db.FillBankType1();
                    }
                    else if (CostGroupType == 1)
                    {
                        bsBank.DataSource = db.FillBankType1();
                    }
                    else if (CostGroupType == 2)
                    {
                        bsBank.DataSource = db.FillBankType1();
                    }

                    if (IsEdit)
                    {
                        cmbBank.SelectedValue = BankId;

                        bsDocument.DataSource = db.FillDocumentById(DocId);

                        OldPrice = intDocPrice.Value;
                    }
                    else
                    {
                        strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                        mskDocDate1.Text = strToday;
                        mskDocDate2.Text = strToday;

                        txtDocDes.Text = strDes;
                        intDocPrice.Value = intSaleBuy;
                    }
                }
                else
                {
                    cmbCostGroup.Visible = true;
                    lblCost.Visible = true;

                    cmbBank.Visible = false;
                    lblBank.Visible = false;

                    bsCostGroup.DataSource = db.FillCostGroup();

                    if (IsEdit)
                    {
                        bsDocument.DataSource = db.FillDocumentById(DocId);

                        cmbCostGroup.SelectedValue = CostId;
                    }
                    else
                    {
                        strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                        mskDocDate1.Text = strToday;
                        mskDocDate2.Text = strToday;
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
                if (txtDocNumber.Text == string.Empty)
                {
                    errorProvider1.SetError(txtDocNumber, "مقداری را مشخص نکرده اید");

                    txtDocNumber.Focus();
                }
                else
                {
                    db.ExistsDocument(txtDocNumber.Text, ref DocExist);

                    errorProvider1.Clear();

                    if (DocExist == true)
                    {
                        errorProvider1.SetError(txtDocNumber, "شماره سند تکراری است");

                        txtDocNumber.Focus();
                    }
                    else
                    {
                        errorProvider1.Clear();

                        if (CostGroupType != 0)
                        {
                            if (IsEdit)
                            {
                                bsDocument.EndEdit();
                                db.UpdateDocument(DocId, (int)cmbBank.SelectedValue, CostGroupType, PersonId, mskDocDate1.Text, mskDocDate2.Text, intDocPrice.Value, txtDocDes.Text, txtDocNumber.Text);
                            }
                            else
                            {
                                db.InsertDocument((int)cmbBank.SelectedValue, CostGroupType, PersonId, mskDocDate1.Text, mskDocDate2.Text, intDocPrice.Value, txtDocDes.Text, txtDocNumber.Text, false);
                            }
                        }
                        else
                        {
                            if (IsEdit)
                            {
                                bsDocument.EndEdit();
                                db.UpdateDocument(DocId, BankId, (int)cmbCostGroup.SelectedValue, 0, mskDocDate1.Text, mskDocDate2.Text, intDocPrice.Value, txtDocDes.Text, txtDocNumber.Text);
                            }
                            else
                            {
                                db.InsertDocument(BankId, (int)cmbCostGroup.SelectedValue, 0, mskDocDate1.Text, mskDocDate2.Text, intDocPrice.Value, txtDocDes.Text, txtDocNumber.Text, false);

                                txtDocDes.Text = string.Empty;
                                txtDocNumber.Text = string.Empty;
                                intDocPrice.Value = 0;

                                mskDocDate1.Focus();
                            }
                        }

                        MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    }
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
