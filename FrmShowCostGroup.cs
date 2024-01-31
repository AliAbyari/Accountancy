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
    public partial class FrmShowCostGroup : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool CostType = false;

        string MessageBody = "";
        public FrmShowCostGroup()
        {
            InitializeComponent();
        }

        private void FrmShowCostGroup_Load(object sender, EventArgs e)
        {
            try
            {
                if (CostType)
                {
                    gp1.Text = "نمایش لیست درآمد ها";

                    bsCostGroup.DataSource = db.FillCostGroupType2();

                    MessageBody = "درآمد";
                }
                else
                {
                    gp1.Text = "نمایش لیست هزینه ها";

                    bsCostGroup.DataSource = db.FillCostGroupType1();

                    MessageBody = "هزینه";
                }

                if (dgvCostGroup.Rows.Count == 0)
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
                FrmAddCostGroup.CostType = CostType;
                FrmAddCostGroup.IsEdit = false;

                new FrmAddCostGroup().ShowDialog();

                if (CostType)
                {
                    bsCostGroup.DataSource = db.FillCostGroupType2();
                }
                else
                {
                    bsCostGroup.DataSource = db.FillCostGroupType1();
                }

                if (dgvCostGroup.Rows.Count == 0)
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
                FrmAddCostGroup.CostType = CostType;
                FrmAddCostGroup.IsEdit = true;
                FrmAddCostGroup.CostGroupId = (int)dgvCostGroup.CurrentRow.Cells[0].Value;

                new FrmAddCostGroup().ShowDialog();

                db = new dcAccountancyDataContext();

                if (CostType)
                {
                    bsCostGroup.DataSource = db.FillCostGroupType2();
                }
                else
                {
                    bsCostGroup.DataSource = db.FillCostGroupType1();
                }

                if (dgvCostGroup.Rows.Count == 0)
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
                if (MessageBoxFarsi.Show("آیا مطمئن به حذف این " + MessageBody + " هستید؟", "تأیید حذف", MessageBoxFarsiButtons.YesNo, MessageBoxFarsiIcon.Question, MessageBoxFarsiDefaultButton.Button1) == DialogResult.Yes)
                {
                    db.DeleteCostGroup((int)dgvCostGroup.CurrentRow.Cells[0].Value);

                    if (CostType)
                    {
                        bsCostGroup.DataSource = db.FillCostGroupType2();
                    }
                    else
                    {
                        bsCostGroup.DataSource = db.FillCostGroupType1();
                    }

                    if (dgvCostGroup.Rows.Count == 0)
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
