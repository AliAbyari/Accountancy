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
    public partial class FrmShowPerson : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public FrmShowPerson()
        {
            InitializeComponent();
        }

        private void FrmShowPerson_Load(object sender, EventArgs e)
        {
            try
            {
                chk1.Checked = true;

                //bsPerson.DataSource = db.FilterPerson(txtFilter.Text);

                //if (dgvPerson.Rows.Count == 0)
                //{
                //    btnEdit.Enabled = false;
                //    btnDelete.Enabled = false;
                //}
                //else
                //{
                //    btnEdit.Enabled = true;
                //    btnDelete.Enabled = true;
                //}
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
                FrmAddPerson.IsEdit = false;

                new FrmAddPerson().ShowDialog();

                if (chk1.Checked)
                {
                    bsPerson.DataSource = db.FilterPerson(txtFilter.Text);
                }
                else if (chk2.Checked)
                {

                }
                else if (chk3.Checked)
                {

                }

                if (dgvPerson.Rows.Count == 0)
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

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chk1.Checked)
                {
                    bsPerson.DataSource = db.FilterPerson(txtFilter.Text);

                    if (dgvPerson.Rows.Count == 0)
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
                if (chk1.Checked)
                {
                    bsPerson.DataSource = db.FilterPerson(txtFilter.Text);
                }
                else if (chk2.Checked)
                {

                }
                else if (chk3.Checked)
                {

                }

                if (dgvPerson.Rows.Count == 0)
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
                FrmAddPerson.IsEdit = true;
                FrmAddPerson.PersonId = (int)dgvPerson.CurrentRow.Cells[0].Value;

                new FrmAddPerson().ShowDialog();

                db = new dcAccountancyDataContext();

                if (chk1.Checked)
                {
                    bsPerson.DataSource = db.FilterPerson(txtFilter.Text);
                }
                else if (chk2.Checked)
                {

                }
                else if (chk3.Checked)
                {

                }

                if (dgvPerson.Rows.Count == 0)
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
                if (MessageBoxFarsi.Show("آیا از حذف این شخص اطمینان دارید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeletePerson((int)dgvPerson.CurrentRow.Cells[0].Value);

                    if (chk1.Checked)
                    {
                        bsPerson.DataSource = db.FilterPerson(txtFilter.Text);
                    }
                    else if (chk2.Checked)
                    {

                    }
                    else if (chk3.Checked)
                    {

                    }

                    if (dgvPerson.Rows.Count == 0)
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
    }
}
