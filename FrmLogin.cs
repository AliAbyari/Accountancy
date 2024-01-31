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
    public partial class FrmLogin : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        PersianCalendar PC = new PersianCalendar();
        
        bool? CheckName = false;
        bool? CheckPass = false;
        bool? Depot = false;
        bool? Bank = false;
        bool? Person = false;
        bool? Setting = false;
        bool? Factor = false;
        bool? User = false;

        int? UserId = 0;

        string strToday = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                db.CheckUsersName(ref CheckName, txtUser.Text);
                db.CheckUserPass(ref CheckPass, txtPass.Text);

                if (CheckName == true && CheckPass == true)
                {
                    db.GetLoginId(ref UserId, txtUser.Text, txtPass.Text);

                    db.GetUserPermission(UserId, ref Depot, ref Bank, ref Factor, ref Person, ref Setting, ref User);

                    FrmMain.LoginId = (int)UserId;

                    FrmMain.DepotPermission = (bool)Depot;
                    FrmMain.BankPermission = (bool)Bank;
                    FrmMain.FactorPermission = (bool)Factor;
                    FrmMain.PersonPermission = (bool)Person;
                    FrmMain.SettingPermission = (bool)Setting;
                    FrmMain.UserPermission = (bool)User;

                    strToday = PC.GetYear(DateTime.Now).ToString("0000") + "/" + PC.GetMonth(DateTime.Now).ToString("00") + "/" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "  " + DateTime.Now.ToShortTimeString();

                    db.InsertLogs(UserId, strToday);

                    this.Close();
                }
                else
                {
                    errorProvider1.SetError(txtPass, "مشخصات کاربری اشتباه است");

                    txtPass.Focus();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
