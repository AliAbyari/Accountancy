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
    public partial class FrmFacture : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        int? PersonDebtor = 0;
        int? PersonCreditor = 0;

        int? SumSaleBook = 0;
        int? SumBuyBook = 0;
        
        int? SumSaleFactor = 0;
        int? SumBuyFactor = 0;

        int? SumSaleDoc = 0;
        int? SumBuyDoc = 0;

        public FrmFacture()
        {
            InitializeComponent();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsPerson.DataSource = db.FilterPerson(txtFilter.Text);

                if (dgvFacture.Rows.Count == 0)
                {
                    btnDebtorCreditor.Enabled = false;
                    btnFactor.Enabled = false;
                    btnMoney.Enabled = false;
                }
                else
                {
                    btnDebtorCreditor.Enabled = true;
                    btnFactor.Enabled = true;
                    btnMoney.Enabled = true;

                    db.GetSumBookByPerson((int)dgvFacture.CurrentRow.Cells[0].Value, ref SumSaleBook, ref SumBuyBook);
                    db.GetSumFactorByPerson((int)dgvFacture.CurrentRow.Cells[0].Value, ref SumSaleFactor, ref SumBuyFactor);
                    db.GetSumDocumentByPerson((int)dgvFacture.CurrentRow.Cells[0].Value, ref SumSaleDoc, ref SumBuyDoc);

                    int SumSaleStatus = 0;
                    int SumBuyStatus = 0;

                    SumSaleStatus = Convert.ToInt32(SumSaleFactor - SumSaleBook);
                    SumBuyStatus = Convert.ToInt32(SumBuyStatus - SumBuyBook);

                    lblDebtor.Text = SumSaleStatus.ToString("n0");
                    lblCreditor.Text = SumBuyStatus.ToString("n0");

                    db.GetDebtorCreditor(ref PersonDebtor, ref PersonCreditor, (int)dgvFacture.CurrentRow.Cells[0].Value);

                    int SumDC = 0;

                    if (PersonDebtor != 0)
                    {
                        SumDC = (int)PersonDebtor;

                        lblDebtorCreditor.ForeColor = Color.DarkBlue;
                    }
                    else
                    {
                        SumDC = (int)PersonCreditor;

                        lblDebtorCreditor.ForeColor = Color.DarkRed;
                    }

                    lblDebtorCreditor.Text = SumDC.ToString("n0");
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void dgvFacture_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bsPerson.DataSource = db.FilterPerson(txtFilter.Text);

                if (dgvFacture.Rows.Count == 0)
                {
                    btnDebtorCreditor.Enabled = false;
                    btnFactor.Enabled = false;
                    btnMoney.Enabled = false;
                }
                else
                {
                    btnDebtorCreditor.Enabled = true;
                    btnFactor.Enabled = true;
                    btnMoney.Enabled = true;

                    db.GetSumBookByPerson((int)dgvFacture.CurrentRow.Cells[0].Value, ref SumSaleBook, ref SumBuyBook);
                    db.GetSumFactorByPerson((int)dgvFacture.CurrentRow.Cells[0].Value, ref SumSaleFactor, ref SumBuyFactor);
                    db.GetSumDocumentByPerson((int)dgvFacture.CurrentRow.Cells[0].Value, ref SumSaleDoc, ref SumBuyDoc);

                    int SumSaleStatus = 0;
                    int SumBuyStatus = 0;

                    SumSaleStatus = Convert.ToInt32(SumSaleFactor - SumSaleBook);
                    SumBuyStatus = Convert.ToInt32(SumBuyStatus - SumBuyBook);

                    lblDebtor.Text = SumSaleStatus.ToString("n0");
                    lblCreditor.Text = SumBuyStatus.ToString("n0");

                    db.GetDebtorCreditor(ref PersonDebtor, ref PersonCreditor, (int)dgvFacture.CurrentRow.Cells[0].Value);

                    int SumDC = 0;

                    if (PersonDebtor != 0)
                    {
                        SumDC = (int)PersonDebtor;

                        lblDebtorCreditor.ForeColor = Color.DarkBlue;
                    }
                    else
                    {
                        SumDC = (int)PersonCreditor;

                        lblDebtorCreditor.ForeColor = Color.DarkRed;
                    }

                    lblDebtorCreditor.Text = SumDC.ToString("n0");
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void btnDebtorCreditor_Click(object sender, EventArgs e)
        {
            FrmDebtorCreditor.PersonFullName = dgvFacture.CurrentRow.Cells[1].Value.ToString();
            FrmDebtorCreditor.PersonId = (int)dgvFacture.CurrentRow.Cells[0].Value;
            FrmDebtorCreditor.PersonDebtor = (int)PersonDebtor;
            FrmDebtorCreditor.PersonCreditor = (int)PersonCreditor;

            new FrmDebtorCreditor().ShowDialog();

            try
            {
                bsPerson.DataSource = db.FilterPerson(txtFilter.Text);

                if (dgvFacture.Rows.Count == 0)
                {
                    btnDebtorCreditor.Enabled = false;
                }
                else
                {
                    btnDebtorCreditor.Enabled = true;

                    db.GetDebtorCreditor(ref PersonDebtor, ref PersonCreditor, (int)dgvFacture.CurrentRow.Cells[0].Value);

                    int SumDC = 0;

                    if (PersonDebtor != 0)
                    {
                        SumDC = (int)PersonDebtor;

                        lblDebtorCreditor.ForeColor = Color.DarkBlue;
                    }
                    else
                    {
                        SumDC = (int)PersonCreditor;

                        lblDebtorCreditor.ForeColor = Color.DarkRed;
                    }

                    lblDebtorCreditor.Text = SumDC.ToString("n0");
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void FrmFacture_Load(object sender, EventArgs e)
        {
            lblDebtorCreditor.ForeColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            FrmShowFactorFacture.PersonId = (int)dgvFacture.CurrentRow.Cells[0].Value;
            FrmShowFactorFacture.PersonName = dgvFacture.CurrentRow.Cells[1].Value.ToString();
            FrmShowFactorFacture.SumBuyFactor = (int)SumBuyFactor;
            FrmShowFactorFacture.SumSaleFactor = (int)SumSaleFactor;

            new FrmShowFactorFacture().ShowDialog();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            FrmShowMoneyFacture.PersonId = (int)dgvFacture.CurrentRow.Cells[0].Value;
            FrmShowMoneyFacture.PersonName = dgvFacture.CurrentRow.Cells[1].Value.ToString();
            FrmShowMoneyFacture.SumBuyBook = (int)SumBuyBook;
            FrmShowMoneyFacture.SumSaleBook = (int)SumSaleBook;
            FrmShowMoneyFacture.SumBuyDoc = (int)SumBuyDoc;
            FrmShowMoneyFacture.SumSaleDoc = (int)SumSaleDoc;

            new FrmShowMoneyFacture().ShowDialog();
        }
    }
}
