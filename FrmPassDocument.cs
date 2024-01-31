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
    public partial class FrmPassDocument : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        PumkinSender sms = new PumkinSender();

        public static int CostId = 0;
        public static int PersonId = 0;
        public static int DocId = 0;

        public static string BookDes = "";
        public static string DocNumber = "";

        string UserTel = "";

        int? BankSum = 0;

        bool? BankSend = false;

        string strToday = "";
        public FrmPassDocument()
        {
            InitializeComponent();
        }

        private void FrmPassDocument_Load(object sender, EventArgs e)
        {
            try
            {
                gp1.Text = "وصول سند با شماره " + DocNumber;

                btnPass.Enabled = true;

                bsBank.DataSource = db.FillBankType1();

                txtDes.Text = BookDes;

                strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                mskDate.Text = strToday;
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
                db.InsertBook((int)cmbBank.SelectedValue, CostId, PersonId, mskDate.Text, DateTime.Now.ToShortTimeString(), txtDes.Text, intPrice.Value);
                
                if (BankSend == true)
                {
                    db.GetSettingBankSend(ref BankSend, ref UserTel);

                    sms.SendMessage(UserTel, "واریز به حساب " + cmbBank.Text + Environment.NewLine + "مبلغ : " + intPrice.Value + Environment.NewLine + "مانده حساب : " + BankSum);
                }

                intPrice.Value = 0;

                if (MessageBoxFarsi.Show("آیا با واریز این مبلغ، سند وصول خواهد شد؟", "وصول سند", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.UpdateDocumentPass(DocId);

                    MessageBoxFarsi.Show("سند مورد نظر وصول شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);

                    btnPass.Enabled = false;
                }
                else
                {
                    MessageBoxFarsi.Show("بخشی از مبلغ سند به حساب واریز شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnPass_Click(object sender, EventArgs e)
        {
            try
            {
                db.UpdateDocumentPass(DocId);
                
                MessageBoxFarsi.Show("سند مورد نظر وصول شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
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
