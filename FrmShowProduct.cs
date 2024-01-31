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
    public partial class FrmShowProduct : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public FrmShowProduct()
        {
            InitializeComponent();
        }

        private void FrmShowProduct_Load(object sender, EventArgs e)
        {
            try
            {
                chkGroup.Checked = false;
                cmbGroup.Enabled = false;

                bsProduct.DataSource = db.FilterProduct(txtFilter.Text);

                if (dgvProduct.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
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
                FrmAddProduct.IsEdit = false;

                new FrmAddProduct().ShowDialog();

                if (chkGroup.Checked)
                {
                    bsGroup.DataSource = db.FillGroup();

                    bsProduct.DataSource = db.FilterProductByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);
                }
                else
                {
                    bsProduct.DataSource = db.FilterProduct(txtFilter.Text);
                }

                if (dgvProduct.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void chkGroup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cmbGroup.Enabled = chkGroup.Checked;

                if (chkGroup.Checked)
                {
                    bsGroup.DataSource = db.FillGroup();

                    bsProduct.DataSource = db.FilterProductByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);
                }
                else
                {
                    bsProduct.DataSource = db.FilterProduct(txtFilter.Text);
                }

                if (dgvProduct.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
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
                if (chkGroup.Checked)
                {
                    bsGroup.DataSource = db.FillGroup();

                    bsProduct.DataSource = db.FilterProductByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);
                }
                else
                {
                    bsProduct.DataSource = db.FilterProduct(txtFilter.Text);
                }

                if (dgvProduct.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }

        private void cmbGroup_TextChanged(object sender, EventArgs e)
        {
            try
            {
                bsProduct.DataSource = db.FilterProductByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);

                if (dgvProduct.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
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
                FrmAddProduct.IsEdit = true;

                FrmAddProduct.ProductId = (int)dgvProduct.CurrentRow.Cells[0].Value;
                FrmAddProduct.GroupId = (int)dgvProduct.CurrentRow.Cells[1].Value;

                new FrmAddProduct().ShowDialog();

                db = new dcAccountancyDataContext();

                if (chkGroup.Checked)
                {
                    bsGroup.DataSource = db.FillGroup();

                    bsProduct.DataSource = db.FilterProductByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);
                }
                else
                {
                    bsProduct.DataSource = db.FilterProduct(txtFilter.Text);
                }

                if (dgvProduct.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = true;
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
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این محصول هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteProduct((int)dgvProduct.CurrentRow.Cells[0].Value);

                    if (chkGroup.Checked)
                    {
                        bsGroup.DataSource = db.FillGroup();

                        bsProduct.DataSource = db.FilterProductByGroup((int)cmbGroup.SelectedValue, txtFilter.Text);
                    }
                    else
                    {
                        bsProduct.DataSource = db.FilterProduct(txtFilter.Text);
                    }

                    if (dgvProduct.Rows.Count == 0)
                    {
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
                    }
                    else
                    {
                        btnDelete.Enabled = true;
                        btnEdit.Enabled = true;
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
    }
}
