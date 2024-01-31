using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Accountancy
{
    public partial class FrmMain : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();

        public static int LoginId = 0;

        public static bool DepotPermission = false;
        public static bool BankPermission = false;
        public static bool FactorPermission = false;
        public static bool PersonPermission = false;
        public static bool SettingPermission = false;
        public static bool UserPermission = false;

        bool? ExistRole = false;
        bool? ExistUser = false;
        bool? ExistSetting = false;

        int? LogId = 0;

        int? Alarm1 = 0;
        int? Alarm2 = 0;

        string strToday = "";
        public FrmMain()
        {
            InitializeComponent();
        }
        
        private void FrmMain_Load(object sender, EventArgs e)
        {
            db.ExistsRoles(ref ExistRole);

            strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

            if (ExistRole == false)
            {
                FrmAddRoles.IsEdit = false;
                FrmAddRoles.ExitType = true;

                new FrmAddRoles().ShowDialog();
            }

            db.ExistsUsers(ref ExistUser);

            if (ExistUser == false)
            {
                FrmAddUsers.ExitType = true;
                FrmAddUsers.IsEdit = false;

                new FrmAddUsers().ShowDialog();
            }
            else
            {
                new FrmLogin().ShowDialog();
            }

            db.ExistsSetting(ref ExistSetting);

            if (ExistSetting == false)
            {
                FrmSetting.ExitType = true;

                new FrmSetting().ShowDialog();
            }

            if (SettingPermission)
            {
                btnSetting.Enabled = true;
                btnTax.Enabled = true;
            }
            else
            {
                btnSetting.Enabled = false;
                btnTax.Enabled = false;
            }

            if (UserPermission)
            {
                btnUsers.Enabled = true;
                btnRoles.Enabled = true;
            }
            else
            {
                btnUsers.Enabled = false;
                btnRoles.Enabled = false;
            }

            if (DepotPermission)
            {
                btnDepot.Enabled = true;
                btnInOut.Enabled = true;
                btnStock.Enabled = true;
                btnMovment.Enabled = true;
            }
            else
            {
                btnDepot.Enabled = false;
                btnInOut.Enabled = false;
                btnStock.Enabled = false;
                btnMovment.Enabled = false;
            }

            if (FactorPermission)
            {
                btnGroups.Enabled = true;
                btnProduct.Enabled = true;
            }
            else
            {
                btnProduct.Enabled = false;
                btnGroups.Enabled = false;
            }

            if (PersonPermission)
            {
                btnPerson.Enabled = true;
            }
            else
            {
                btnPerson.Enabled = false;
            }

            if (BankPermission)
            {
                btnCost1.Enabled = true;
                btnCost2.Enabled = true;
                btnBank1.Enabled = true;
                btnDocument.Enabled = true;
            }
            else
            {
                btnCost1.Enabled = false;
                btnCost2.Enabled = false;
                btnBank1.Enabled = false;
                btnDocument.Enabled = false;
            }

            bsViewStock.DataSource = db.FillStockAlarm();

            if (dgvStockAlarm.Rows.Count == 0)
            {
                exPanelStock.Visible = false;
            }
            else
            {
                exPanelStock.Visible = true;
            }

            db.GetAlarmSetting(ref Alarm1, ref Alarm2);

            bsDocument.DataSource = db.AlarmDocument(strToday, Alarm1, Alarm2);

            //MessageBox.Show(Alarm1.ToString() + Environment.NewLine + Alarm2.ToString());

            if (dgvDoc.Rows.Count == 0)
            {
                exPanelDocument.Visible = false;
            }
            else
            {
                exPanelDocument.Visible = true;
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            new FrmSetting().ShowDialog();
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            new FrmShowRoles().ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new FrmShowUsers().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLoginSetting.LoginId = LoginId;

            new FrmLoginSetting().ShowDialog();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.GetLogId(ref LogId, LoginId);

            db.UpdateLogs((int)LogId, strToday);
        }

        private void btnDepot_Click(object sender, EventArgs e)
        {
            new FrmShowDepot().ShowDialog();
        }

        private void btnGroups_Click(object sender, EventArgs e)
        {
            new FrmShowGroups().ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            new FrmShowProduct().ShowDialog();
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            new FrmShowPerson().ShowDialog();
        }

        private void btnCost1_Click(object sender, EventArgs e)
        {
            FrmShowCostGroup.CostType = true;

            new FrmShowCostGroup().ShowDialog();
        }

        private void btnCost2_Click(object sender, EventArgs e)
        {
            FrmShowCostGroup.CostType = false;

            new FrmShowCostGroup().ShowDialog();
        }

        private void btnBank1_Click(object sender, EventArgs e)
        {
            FrmShowBank.BankType = false;

            new FrmShowBank().ShowDialog();
        }

        private void btnBank2_Click(object sender, EventArgs e)
        {
            FrmShowBank.BankType = true;

            new FrmShowBank().ShowDialog();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            new FrmSelectedBank().ShowDialog();
        }

        private void btnTax_Click(object sender, EventArgs e)
        {
            new FrmTax().ShowDialog();
        }

        private void btnFacture_Click(object sender, EventArgs e)
        {
            new FrmFacture().ShowDialog();
        }

        private void btnInOut_Click(object sender, EventArgs e)
        {
            new FrmSelectStock().ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            new FrmShowStock().ShowDialog();
        }

        private void btnMovment_Click(object sender, EventArgs e)
        {
            new FrmMovement().ShowDialog();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            FrmShowFactor.FrmType = true;

            new FrmShowFactor().ShowDialog();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            FrmShowFactor.FrmType = false;

            new FrmShowFactor().ShowDialog();
        }

        private void btnMessage_Click(object sender, EventArgs e)
        {
            new FrmShowMessage().ShowDialog();
        }

        private void btnBuyReport_Click(object sender, EventArgs e)
        {
            FrmFactorReport.FrmType = true;

            new FrmFactorReport().ShowDialog();
        }

        private void btnSaleReport_Click(object sender, EventArgs e)
        {
            FrmFactorReport.FrmType = false;

            new FrmFactorReport().ShowDialog();
        }

        private void btnMoneyReport_Click(object sender, EventArgs e)
        {
            new FrmMoneyReport().ShowDialog();
        }
    }
}
