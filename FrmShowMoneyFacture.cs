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
    public partial class FrmShowMoneyFacture : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static int PersonId = 0;

        public static string PersonName = "";

        public static int SumSaleBook = 0;
        public static int SumBuyBook = 0;
        public static int SumSaleDoc = 0;
        public static int SumBuyDoc = 0;
        public FrmShowMoneyFacture()
        {
            InitializeComponent();
        }

        private void FrmShowMoneyFacture_Load(object sender, EventArgs e)
        {
            try
            {
                bsBook.DataSource = db.FilterBookByPerson(PersonId);
                bsDocument.DataSource = db.FilterDocumentByPerson(PersonId);

                lblBookBuy.Text = SumBuyBook.ToString("n0");
                lblBookSale.Text = SumSaleBook.ToString("n0");

                lblDocBuy.Text = SumBuyDoc.ToString("n0");
                lblDocSale.Text = SumSaleDoc.ToString("n0");
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

                Report.Compile();

                Report.Load("Reports/rptFactureMoney.mrt");
                
                Report["PersonId"] = PersonId;
                Report["strPersonName"] = PersonName;

                Report.ShowWithRibbonGUI();
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

        private void btnBook1_Click(object sender, EventArgs e)
        {
            FrmAddBook.CostGroupType = 1;
            FrmAddBook.PersonId = PersonId;
            FrmAddBook.IsEdit = false;

            new FrmAddBook().ShowDialog();
            
        }

        private void btnBook2_Click(object sender, EventArgs e)
        {
            FrmAddBook.CostGroupType = 2;
            FrmAddBook.PersonId = PersonId;
            FrmAddBook.IsEdit = false;

            new FrmAddBook().ShowDialog();
        }

        private void btnDoc1_Click(object sender, EventArgs e)
        {
            FrmAddDocument.IsEdit = false;
            FrmAddDocument.CostGroupType = 1;
            FrmAddDocument.PersonId = PersonId;

            new FrmAddDocument().ShowDialog();
        }

        private void btnDoc2_Click(object sender, EventArgs e)
        {
            FrmAddDocument.IsEdit = false;
            FrmAddDocument.CostGroupType = 2;
            FrmAddDocument.PersonId = PersonId;

            new FrmAddDocument().ShowDialog();
        }
    }
}
