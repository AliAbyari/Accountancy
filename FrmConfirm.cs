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
    public partial class FrmConfirm : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static int FactorId = 0;

        public static bool FrmType = false;

        int? ProductStock = 0;
        public FrmConfirm()
        {
            InitializeComponent();
        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {
            try
            {
                bsViewFacotr.DataSource = db.FillViewFactorDetails(FactorId);

                if (FrmType)
                {
                    gp1.Enabled = false;
                    btnSave.Enabled = false;
                }
                else
                {
                    gp1.Enabled = true;
                    btnSave.Enabled = true;

                    bsDepot.DataSource = db.FillDepotByProduct((int)dgvFactor.CurrentRow.Cells[2].Value);

                    db.GetProductStockInDepot((int)cmbDepot.SelectedValue, (int)dgvFactor.CurrentRow.Cells[2].Value, ref ProductStock);

                    txtStock.Text = ProductStock.ToString();
                    txtUnit2.Text = dgvFactor.CurrentRow.Cells[8].Value.ToString();
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
                if ((bool)dgvFactor.CurrentRow.Cells[9].Value == true)
                {
                    MessageBoxFarsi.Show("این محصول را قبلاً تأیید کرده اید", "توجه", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Warning, MessageBoxFarsiDefaultButton.Button1);

                }
                else
                {
                    db.InsertStock(FactorId, (int)cmbDepot.SelectedValue, (int)dgvFactor.CurrentRow.Cells[2].Value, dgvFactor.CurrentRow.Cells[4].Value.ToString(), "فروش با شماره " + dgvFactor.CurrentRow.Cells[10].Value.ToString(), 0, (int)dgvFactor.CurrentRow.Cells[7].Value);

                    db.UpdateDetails((int)dgvFactor.CurrentRow.Cells[0].Value, (int)cmbDepot.SelectedValue);

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);

                    db = new dcAccountancyDataContext();

                    bsDepot.DataSource = db.FillDepotByProduct((int)dgvFactor.CurrentRow.Cells[2].Value);

                    db.GetProductStockInDepot((int)cmbDepot.SelectedValue, (int)dgvFactor.CurrentRow.Cells[2].Value, ref ProductStock);

                    txtStock.Text = ProductStock.ToString();
                    txtUnit2.Text = dgvFactor.CurrentRow.Cells[8].Value.ToString();
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void dgvFactor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bsViewFacotr.DataSource = db.FillViewFactorDetails(FactorId);

                bsDepot.DataSource = db.FillDepotByProduct((int)dgvFactor.CurrentRow.Cells[2].Value);

                db.GetProductStockInDepot((int)cmbDepot.SelectedValue, (int)dgvFactor.CurrentRow.Cells[2].Value, ref ProductStock);

                txtStock.Text = ProductStock.ToString();
                txtUnit2.Text = dgvFactor.CurrentRow.Cells[8].Value.ToString();
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
