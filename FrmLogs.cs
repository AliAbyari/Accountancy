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
    public partial class FrmLogs : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static int UserId = 0;

        public static string UserName = "";
        public FrmLogs()
        {
            InitializeComponent();
        }

        private void FrmLogs_Load(object sender, EventArgs e)
        {
            try
            {
                gp1.Text = UserName + " نمایش ورود و خروج های";

                bsLogs.DataSource = db.FillLogs(UserId);
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
