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
    public partial class FrmShowDocument : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PumkinSender sms = new PumkinSender();

        public static int BankId = 0;

        int? SumBank = 0;

        string UserTel = "";
        string BankName = "";

        bool? BankSend = false;

        bool? CostStatus = false;

        public FrmShowDocument()
        {
            InitializeComponent();
        }

        private void FrmShowDocument_Load(object sender, EventArgs e)
        {
            try
            {
                chkD.Checked = true;
                chkP.Checked = false;


            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void chkD_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkD.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument1ByNumber(txtFilter.Text);

                    if (dgvDocument.Rows.Count == 0)
                    {
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void chkP_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkP.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument2ByNumber(txtFilter.Text);

                    if (dgvDocument.Rows.Count == 0)
                    {
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
                    }
                }
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
                if (chkP.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument2ByNumber(txtFilter.Text);
                }
                else if (chkD.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument1ByNumber(txtFilter.Text);
                }

                if (dgvDocument.Rows.Count == 0)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddDocument.IsEdit = false;
                FrmAddDocument.CostGroupType = 0;
                FrmAddDocument.BankId = BankId;

                new FrmAddDocument().ShowDialog();

                if (chkP.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument2ByNumber(txtFilter.Text);
                }
                else if (chkD.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument1ByNumber(txtFilter.Text);
                }

                if (dgvDocument.Rows.Count == 0)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddDocument.IsEdit = true;
                FrmAddDocument.BankId = BankId;
                FrmAddDocument.DocId = (int)dgvDocument.CurrentRow.Cells[0].Value;
                FrmAddDocument.CostId = (int)dgvDocument.CurrentRow.Cells[2].Value;
                FrmAddDocument.PersonId = (int)dgvDocument.CurrentRow.Cells[3].Value;

                if ((int)dgvDocument.CurrentRow.Cells[2].Value == 7)
                {
                    FrmAddDocument.CostGroupType = 7;
                }
                else if ((int)dgvDocument.CurrentRow.Cells[2].Value == 8)
                {
                    FrmAddDocument.CostGroupType = 8;
                }
                else if ((int)dgvDocument.CurrentRow.Cells[2].Value == 2)
                {
                    FrmAddDocument.CostGroupType = 2;
                }
                else if ((int)dgvDocument.CurrentRow.Cells[2].Value == 1)
                {
                    FrmAddDocument.CostGroupType = 1;
                }
                else
                {
                    FrmAddDocument.CostGroupType = 0;
                }

                new FrmAddDocument().ShowDialog();

                db = new dcAccountancyDataContext();

                if (chkP.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument2ByNumber(txtFilter.Text);
                }
                else if (chkD.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument1ByNumber(txtFilter.Text);
                }

                if (dgvDocument.Rows.Count == 0)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBoxFarsi.Show("آیا از حذف این سند اطمینان دارید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteDocument((int)dgvDocument.CurrentRow.Cells[0].Value);

                    if (chkP.Checked)
                    {
                        bsDocument.DataSource = db.FilterDocument2ByNumber(txtFilter.Text);
                    }
                    else if (chkD.Checked)
                    {
                        bsDocument.DataSource = db.FilterDocument1ByNumber(txtFilter.Text);
                    }

                    if (dgvDocument.Rows.Count == 0)
                    {
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                    {
                        btnEdit.Enabled = true;
                        btnDelete.Enabled = true;
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

        private void btnPass_Click(object sender, EventArgs e)
        {
            try
            {
                db.GetCostGroupStatus(ref CostStatus, (int)dgvDocument.CurrentRow.Cells[2].Value);

                if (CostStatus == true)
                {
                    FrmPassDocument.DocId = (int)dgvDocument.CurrentRow.Cells[0].Value;
                    FrmPassDocument.PersonId = (int)dgvDocument.CurrentRow.Cells[3].Value;
                    FrmPassDocument.CostId = (int)dgvDocument.CurrentRow.Cells[2].Value;
                    FrmPassDocument.BookDes = dgvDocument.CurrentRow.Cells[7].Value.ToString();
                    FrmPassDocument.DocNumber = dgvDocument.CurrentRow.Cells[6].Value.ToString();

                    new FrmPassDocument().ShowDialog();
                }
                else
                {
                    db.GetSumBook((int)dgvDocument.CurrentRow.Cells[1].Value, ref SumBank);

                    if ((int)dgvDocument.CurrentRow.Cells[8].Value > SumBank)
                    {
                        MessageBoxFarsi.Show("موجودی حساب برای وصول این سند کافی نیست", "توجه", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Warning, MessageBoxFarsiDefaultButton.Button1);
                    }
                    else
                    {
                        db.UpdateDocumentPass((int)dgvDocument.CurrentRow.Cells[0].Value);

                        db.InsertBook((int)dgvDocument.CurrentRow.Cells[1].Value, (int)dgvDocument.CurrentRow.Cells[2].Value, (int)dgvDocument.CurrentRow.Cells[3].Value, dgvDocument.CurrentRow.Cells[4].Value.ToString(), DateTime.Now.ToShortTimeString(), dgvDocument.CurrentRow.Cells[7].Value.ToString(), (int)dgvDocument.CurrentRow.Cells[8].Value);

                        db.GetSettingBankSend(ref BankSend, ref UserTel);

                        if (BankSend == true)
                        {
                            db.GetBankNameById((int)dgvDocument.CurrentRow.Cells[1].Value, BankName);

                            sms.SendMessage(UserTel, "برداشت از حساب " + BankName + Environment.NewLine + "مبلغ : " + dgvDocument.CurrentRow.Cells[9].Value.ToString() + Environment.NewLine + "مانده حساب : " + SumBank);
                        }

                        MessageBoxFarsi.Show("سند مورد نظر وصول شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                    }
                }

                db = new dcAccountancyDataContext();

                if (chkP.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument2ByNumber(txtFilter.Text);
                }
                else if (chkD.Checked)
                {
                    bsDocument.DataSource = db.FilterDocument1ByNumber(txtFilter.Text);
                }

                if (dgvDocument.Rows.Count == 0)
                {
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
