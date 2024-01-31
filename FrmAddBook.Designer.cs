namespace Accountancy
{
    partial class FrmAddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddBook));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.gp1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtDes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bsBook = new System.Windows.Forms.BindingSource(this.components);
            this.mskDate = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.intPrice = new DevComponents.Editors.IntegerInput();
            this.cmbCostGroup = new System.Windows.Forms.ComboBox();
            this.bsCostGroup = new System.Windows.Forms.BindingSource(this.components);
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblCost = new DevComponents.DotNetBar.LabelX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBank = new DevComponents.DotNetBar.LabelX();
            this.bsBank = new System.Windows.Forms.BindingSource(this.components);
            this.panelEx1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.gp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.gp1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(540, 296);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 244);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(516, 40);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel2.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FocusCuesEnabled = false;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "  خـروج";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.FocusCuesEnabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(427, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "   ثـبت";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gp1
            // 
            this.gp1.BackColor = System.Drawing.Color.White;
            this.gp1.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp1.Controls.Add(this.cmbBank);
            this.gp1.Controls.Add(this.txtDes);
            this.gp1.Controls.Add(this.mskDate);
            this.gp1.Controls.Add(this.intPrice);
            this.gp1.Controls.Add(this.cmbCostGroup);
            this.gp1.Controls.Add(this.labelX4);
            this.gp1.Controls.Add(this.labelX3);
            this.gp1.Controls.Add(this.labelX2);
            this.gp1.Controls.Add(this.lblBank);
            this.gp1.Controls.Add(this.lblCost);
            this.gp1.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp1.Location = new System.Drawing.Point(12, 12);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(516, 226);
            // 
            // 
            // 
            this.gp1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gp1.Style.BackColorGradientAngle = 90;
            this.gp1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gp1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp1.Style.BorderBottomWidth = 1;
            this.gp1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gp1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp1.Style.BorderLeftWidth = 1;
            this.gp1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp1.Style.BorderRightWidth = 1;
            this.gp1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gp1.Style.BorderTopWidth = 1;
            this.gp1.Style.CornerDiameter = 4;
            this.gp1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gp1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gp1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gp1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gp1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gp1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gp1.TabIndex = 0;
            this.gp1.Text = "ثبت مشخصات";
            // 
            // txtDes
            // 
            this.txtDes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDes.Border.Class = "TextBoxBorder";
            this.txtDes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBook, "BookDes", true));
            this.txtDes.DisabledBackColor = System.Drawing.Color.White;
            this.txtDes.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtDes.FocusHighlightEnabled = true;
            this.txtDes.ForeColor = System.Drawing.Color.Black;
            this.txtDes.Location = new System.Drawing.Point(49, 85);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.PreventEnterBeep = true;
            this.txtDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDes.Size = new System.Drawing.Size(302, 67);
            this.txtDes.TabIndex = 2;
            // 
            // bsBook
            // 
            this.bsBook.DataSource = typeof(Accountancy.Book);
            // 
            // mskDate
            // 
            // 
            // 
            // 
            this.mskDate.BackgroundStyle.Class = "TextBoxBorder";
            this.mskDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskDate.ButtonClear.Visible = true;
            this.mskDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsBook, "BookDate", true));
            this.mskDate.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.mskDate.FocusHighlightEnabled = true;
            this.mskDate.Location = new System.Drawing.Point(160, 57);
            this.mskDate.Mask = "####/##/##";
            this.mskDate.Name = "mskDate";
            this.mskDate.Size = new System.Drawing.Size(191, 21);
            this.mskDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskDate.TabIndex = 1;
            this.mskDate.Text = "";
            // 
            // intPrice
            // 
            this.intPrice.AllowEmptyState = false;
            // 
            // 
            // 
            this.intPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intPrice.DataBindings.Add(new System.Windows.Forms.Binding("ValueObject", this.bsBook, "BookPrice", true));
            this.intPrice.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.intPrice.FocusHighlightEnabled = true;
            this.intPrice.Location = new System.Drawing.Point(160, 158);
            this.intPrice.MaxValue = 1000000000;
            this.intPrice.MinValue = 0;
            this.intPrice.Name = "intPrice";
            this.intPrice.Size = new System.Drawing.Size(191, 22);
            this.intPrice.TabIndex = 3;
            // 
            // cmbCostGroup
            // 
            this.cmbCostGroup.BackColor = System.Drawing.Color.LightGray;
            this.cmbCostGroup.DataSource = this.bsCostGroup;
            this.cmbCostGroup.DisplayMember = "CostGroupName";
            this.cmbCostGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCostGroup.FormattingEnabled = true;
            this.cmbCostGroup.Location = new System.Drawing.Point(49, 27);
            this.cmbCostGroup.Name = "cmbCostGroup";
            this.cmbCostGroup.Size = new System.Drawing.Size(302, 22);
            this.cmbCostGroup.TabIndex = 0;
            this.cmbCostGroup.ValueMember = "CostGroupId";
            // 
            // bsCostGroup
            // 
            this.bsCostGroup.DataSource = typeof(Accountancy.CostGroup);
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(371, 157);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(121, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "مبلغ تراکنش";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(371, 84);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(121, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "شرح تراکنش";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(371, 55);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(121, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "تاریخ تراکنش";
            // 
            // lblCost
            // 
            // 
            // 
            // 
            this.lblCost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCost.Location = new System.Drawing.Point(371, 26);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(121, 23);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "انتخاب هزینه | درآمد";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // cmbBank
            // 
            this.cmbBank.BackColor = System.Drawing.Color.LightGray;
            this.cmbBank.DataSource = this.bsBank;
            this.cmbBank.DisplayMember = "BankName";
            this.cmbBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(49, 27);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(302, 22);
            this.cmbBank.TabIndex = 4;
            this.cmbBank.ValueMember = "BankId";
            // 
            // lblBank
            // 
            // 
            // 
            // 
            this.lblBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBank.Location = new System.Drawing.Point(371, 25);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(121, 23);
            this.lblBank.TabIndex = 1;
            this.lblBank.Text = "انتخاب حساب";
            // 
            // bsBank
            // 
            this.bsBank.DataSource = typeof(Accountancy.Bank);
            // 
            // FrmAddBook
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(540, 296);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddBook";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAddBook_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.gp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel gp1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblCost;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDes;
        private DevComponents.Editors.IntegerInput intPrice;
        private System.Windows.Forms.ComboBox cmbCostGroup;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskDate;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private System.Windows.Forms.BindingSource bsCostGroup;
        private System.Windows.Forms.BindingSource bsBook;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbBank;
        private DevComponents.DotNetBar.LabelX lblBank;
        private System.Windows.Forms.BindingSource bsBank;
    }
}