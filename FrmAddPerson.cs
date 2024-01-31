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
    public partial class FrmAddPerson : Form
    {
        dcAccountancyDataContext db = new dcAccountancyDataContext();

        public static bool IsEdit = false;

        public static int PersonId = 0;

        public FrmAddPerson()
        {
            InitializeComponent();
        }

        private void FrmAddPerson_Load(object sender, EventArgs e)
        {
            try
            {
                if (IsEdit)
                {
                    bsPerson.DataSource = db.FillPersonById(PersonId);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPersonName.Text == string.Empty)
                {
                    errorProvider1.SetError(txtPersonName, "مقداری را مشخص نکرده اید");

                    txtPersonName.Focus();
                }
                else if (txtPersonMobile.Text == string.Empty)
                {
                    errorProvider1.Clear();

                    errorProvider1.SetError(txtPersonMobile, "مقداری را مشخص نکرده اید");

                    txtPersonMobile.Focus();
                }
                else
                {
                    errorProvider1.Clear();

                    if (IsEdit)
                    {
                        bsPerson.EndEdit();

                        db.UpdatePerson(PersonId, txtPersonName.Text, txtPersonTel.Text, txtPersonMobile.Text, intDebtor.Value, intCreditor.Value);
                    }
                    else
                    {
                        db.InsertPerson(txtPersonName.Text, txtPersonTel.Text, txtPersonMobile.Text, intDebtor.Value, intCreditor.Value);

                        txtPersonMobile.Text = string.Empty;
                        txtPersonName.Text = string.Empty;
                        txtPersonTel.Text = string.Empty;

                        intDebtor.Value = 0;
                        intCreditor.Value = 0;

                        txtPersonName.Focus();
                    }

                    MessageBoxFarsi.Show("عملیات با موفقیت انجام شد", "پیغام", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Information, MessageBoxFarsiDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBoxFarsi.Show("ارتباط با سرور اطلاعاتی قطع شده است", "اخطار", MessageBoxFarsiButtons.OK, MessageBoxFarsiIcon.Error, MessageBoxFarsiDefaultButton.Button1);
            }
        }
    }
}
