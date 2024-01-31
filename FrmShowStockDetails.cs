using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BehComponents;
using Stimulsoft.Report;

namespace Accountancy
{
    public partial class FrmShowStockDetails : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static int DepotId = 0;
        public static int ProductId = 0;
        public static int SumStock = 0;

        public static string GroupName = "";
        public static string ProductName = "";
        public static string DepotName = "";
        public FrmShowStockDetails()
        {
            InitializeComponent();
        }

        private void FrmShowStockDetails_Load(object sender, EventArgs e)
        {
            try
            {
                lblProduct.Text = ProductName + " " + GroupName;
                lblDepot.Text = DepotName;
                lblStock.Text = SumStock.ToString("n0");

                bsStock.DataSource = db.FilterStock(DepotId, ProductId);
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                StiReport Report = new StiReport();

                Report.Load("Reports/rptStockDetails.mrt");

                Report.Compile();

                Report["intDepot"] = DepotId;
                Report["intProductId"] = ProductId;
                Report["strName"] = ProductName + " " + GroupName;
                Report["strDepot"] = DepotName;
                Report["intSum"] = SumStock;

                Report.ShowWithRibbonGUI();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
