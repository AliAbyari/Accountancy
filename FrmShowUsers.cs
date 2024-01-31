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
    public partial class FrmShowUsers : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public FrmShowUsers()
        {
            InitializeComponent();
        }

        private void FrmShowUsers_Load(object sender, EventArgs e)
        {
            try
            {
                bsUsers.DataSource = db.FillUsers();

                if (dgvUsers.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddUsers.IsEdit = false;

                new FrmAddUsers().ShowDialog();

                bsUsers.DataSource = db.FillUsers();

                if (dgvUsers.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
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
                FrmAddUsers.IsEdit = true;
                FrmAddUsers.UserId = (int)dgvUsers.CurrentRow.Cells[0].Value;
                FrmAddUsers.RoleId = (int)dgvUsers.CurrentRow.Cells[1].Value;

                new FrmAddUsers().ShowDialog();

                db = new dcAccountancyDataContext();

                bsUsers.DataSource = db.FillUsers();

                if (dgvUsers.Rows.Count == 0)
                {
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
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
                if (MessageBoxFarsi.Show("آیا از حذف این کاربر اطمینان دارید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteUsers((int)dgvUsers.CurrentRow.Cells[0].Value);

                    bsUsers.DataSource = db.FillUsers();

                    if (dgvUsers.Rows.Count == 0)
                    {
                        btnDelete.Enabled = false;
                        btnEdit.Enabled = false;
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

        private void btnLogs_Click(object sender, EventArgs e)
        {
            FrmLogs.UserId = (int)dgvUsers.CurrentRow.Cells[0].Value;
            FrmLogs.UserName = dgvUsers.CurrentRow.Cells[2].Value.ToString();

            new FrmLogs().ShowDialog();
        }
    }
}
