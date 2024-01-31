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
    public partial class FrmDebtorCreditor : Form
    {
        public static int PersonDebtor = 0;
        public static int PersonCreditor = 0;
        public static int PersonId = 0;

        public static string PersonFullName = "";
        public FrmDebtorCreditor()
        {
            InitializeComponent();
        }

        private void FrmDebtorCreditor_Load(object sender, EventArgs e)
        {
            gp1.Text = "جزئیات مانده از قبل " + PersonFullName;

            lblDebtor.Text = PersonDebtor.ToString("n0");
            lblCreditor.Text = PersonCreditor.ToString("n0");
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            FrmAddBook.IsEdit = false;
            FrmAddBook.PersonId = PersonId;

            if (PersonDebtor != 0)
            {
                FrmAddBook.CostGroupType = 7;
            }
            else
            {
                FrmAddBook.CostGroupType = 8;
            }

            new FrmAddBook().ShowDialog();

            this.Close();
        }

        private void btnDocument_Click(object sender, EventArgs e)
        {
            FrmAddDocument.IsEdit = false;
            FrmAddDocument.PersonId = PersonId;

            if (PersonDebtor != 0)
            {
                FrmAddDocument.CostGroupType = 7;
            }
            else
            {
                FrmAddDocument.CostGroupType = 8;
            }

            new FrmAddDocument().ShowDialog();
        }
    }
}
