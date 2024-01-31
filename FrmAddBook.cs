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
    public partial class FrmAddBook : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        PumkinSender sms = new PumkinSender();

        public static bool IsEdit = false;

        public static int BankId = 0;
        public static int BookId = 0;
        public static int CostId = 0;
        public static int PersonId = 0;
        public static int CostGroupType = 0;
        public static int intSaleBuy = 0;

        public static string strDes = "";

        public static string BankName = "";

        bool? BankSend = false;
        string UserTel = "";

        int OldPrice = 0;

        int? SumBank = 0;
        bool? CostStatus = false;

        string strToday = "";
        string strTime = "";
        public FrmAddBook()
        {
            InitializeComponent();
        }

        private void FrmAddBook_Load(object sender, EventArgs e)
        {
            try
            {
                if (CostGroupType != 0)
                {
                    cmbBank.Visible = true;
                    lblBank.Visible = true;

                    cmbCostGroup.Visible = false;
                    lblCost.Visible = false;

                    bsBank.DataSource = db.FillBankType1();

                    if (IsEdit)
                    {
                        cmbBank.SelectedValue = BankId;

                        bsBook.DataSource = db.FillBookById(BookId);

                        OldPrice = intPrice.Value;
                    }
                    else
                    {
                        strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                        mskDate.Text = strToday;

                        txtDes.Text = strDes;
                        intPrice.Value = intSaleBuy;
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
                        bsBook.DataSource = db.FillBookById(BookId);

                        cmbCostGroup.SelectedValue = CostId;
                    }
                    else
                    {
                        strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                        mskDate.Text = strToday;
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
                strTime = DateTime.Now.ToShortTimeString();

                if (CostGroupType != 0)
                {
                    db.GetCostGroupStatus(ref CostStatus, CostGroupType);

                    db.GetSumBook((int)cmbBank.SelectedValue, ref SumBank);

                    if (CostStatus == false)
                    {
                        if (intPrice.Value > SumBank)
                        {
                            errorProvider1.SetError(intPrice, "موجودی حساب کافی نمی باشد");

                            intPrice.Focus();
                        }
                        else
                        {
                            errorProvider1.Clear();

                            if (IsEdit)
                            {
                                bsBook.EndEdit();
                                db.UpdateBook(BookId, (int)cmbBank.SelectedValue, CostGroupType, PersonId, mskDate.Text, strTime, txtDes.Text, intPrice.Value);

                                int NewPrice = 0;

                                if (CostGroupType == 7)
                                {
                                    NewPrice = intPrice.Value - OldPrice;

                                    db.UpdateDebtor(NewPrice, PersonId);
                                }
                                else if (CostGroupType == 8)
                                {
                                    NewPrice = intPrice.Value - OldPrice;

                                    db.UpdateCreditor(NewPrice, PersonId);
                                }
                            }
                            else
                            {
                                db.InsertBook((int)cmbBank.SelectedValue, CostGroupType, PersonId, mskDate.Text, strTime, txtDes.Text, intPrice.Value);

                                if (CostGroupType == 7)
                                {
                                    db.UpdateDebtor(intPrice.Value, PersonId);
                                }
                                else if (CostGroupType == 8)
                                {
                                    db.UpdateCreditor(intPrice.Value, PersonId);
                                }
                            }

                            db.GetSettingBankSend(ref BankSend, ref UserTel);

                            sms.SendMessage(UserTel, "برداشت از حساب " + cmbBank.Text + Environment.NewLine + "مبلغ : " + intPrice.Value + Environment.NewLine + "مانده حساب : " + SumBank.ToString());
                        }
                    }
                    else
	                {
                        if (IsEdit)
                        {
                            bsBook.EndEdit();
                            db.UpdateBook(BookId, (int)cmbBank.SelectedValue, CostGroupType, PersonId, mskDate.Text, strTime, txtDes.Text, intPrice.Value);

                            int NewPrice = 0;

                            if (CostGroupType == 7)
                            {
                                NewPrice = intPrice.Value - OldPrice;

                                db.UpdateDebtor(NewPrice, PersonId);
                            }
                            else if (CostGroupType == 8)
                            {
                                NewPrice = intPrice.Value - OldPrice;

                                db.UpdateCreditor(NewPrice, PersonId);
                            }
                        }
                        else
                        {
                            db.InsertBook((int)cmbBank.SelectedValue, CostGroupType, PersonId, mskDate.Text, strTime, txtDes.Text, intPrice.Value);

                            if (CostGroupType == 7)
                            {
                                db.UpdateDebtor(intPrice.Value, PersonId);
                            }
                            else if (CostGroupType == 8)
                            {
                                db.UpdateCreditor(intPrice.Value, PersonId);
                            }
                        }

                        db.GetSettingBankSend(ref BankSend, ref UserTel);

                        sms.SendMessage(UserTel, "واریز به حساب " + cmbBank.Text + Environment.NewLine + "مبلغ : " + intPrice.Value + Environment.NewLine + "مانده حساب : " + SumBank.ToString());
                    }
                }
                else
                {
                    db.GetCostGroupStatus(ref CostStatus, (int)cmbCostGroup.SelectedValue);

                    db.GetSumBook(BankId, ref SumBank);

                    if (CostStatus == false)
                    {
                        db.GetSumBook(BankId, ref SumBank);

                        if (intPrice.Value > SumBank)
                        {
                            errorProvider1.SetError(intPrice, "موجودی حساب کافی نمی باشد");

                            intPrice.Focus();
                        }
                        else
                        {
                            errorProvider1.Clear();

                            if (IsEdit)
                            {
                                bsBook.EndEdit();

                                db.UpdateBook(BookId, BankId, (int)cmbCostGroup.SelectedValue, 0, mskDate.Text, strTime, txtDes.Text, intPrice.Value);
                            }
                            else
                            {
                                db.InsertBook(BankId, (int)cmbCostGroup.SelectedValue, 0, mskDate.Text, strTime, txtDes.Text, intPrice.Value);

                                txtDes.Text = string.Empty;

                                intPrice.Value = 0;
                            }

                            db.GetSettingBankSend(ref BankSend, ref UserTel);

                            sms.SendMessage(UserTel, "برداشت از حساب " + BankName + Environment.NewLine + "مبلغ : " + intPrice.Value + Environment.NewLine + "مانده حساب : " + SumBank.ToString());
                        }
                    }
                    else
                    {
                        if (IsEdit)
                        {
                            bsBook.EndEdit();

                            db.UpdateBook(BookId, BankId, (int)cmbCostGroup.SelectedValue, 0, mskDate.Text, strTime, txtDes.Text, intPrice.Value);
                        }
                        else
                        {
                            db.InsertBook(BankId, (int)cmbCostGroup.SelectedValue, 0, mskDate.Text, strTime, txtDes.Text, intPrice.Value);

                            txtDes.Text = string.Empty;

                            intPrice.Value = 0;
                        }

                        db.GetSettingBankSend(ref BankSend, ref UserTel);

                        sms.SendMessage(UserTel, "واریز به حساب " + BankName + Environment.NewLine + "مبلغ : " + intPrice.Value + Environment.NewLine + "مانده حساب : " + SumBank.ToString());
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
    }
}
