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
    public partial class FrmSelectedDepot : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static int ProductId = 0;
        public static int SumStock = 0;

        public static string ProductName = "";
        public static string GroupName = "";
        public FrmSelectedDepot()
        {
            InitializeComponent();
        }

        private void FrmSelectedDepot_Load(object sender, EventArgs e)
        {
            try
            {
                bsDepot.DataSource = db.FillDepotByProduct(ProductId);

                if (dgvDepot.Rows.Count == 0)
                {
                    btnDetails.Enabled = false;
                }
                else
                {
                    btnDetails.Enabled = true;
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

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FrmShowStockDetails.DepotId = (int)dgvDepot.CurrentRow.Cells[0].Value;
            FrmShowStockDetails.DepotName = dgvDepot.CurrentRow.Cells[1].Value.ToString();

            FrmShowStockDetails.ProductId = ProductId;
            FrmShowStockDetails.SumStock = SumStock;
            FrmShowStockDetails.GroupName = GroupName;
            FrmShowStockDetails.ProductName = ProductName;

            new FrmShowStockDetails().ShowDialog();
        }
    }
}
