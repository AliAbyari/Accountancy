namespace Accountancy
{
    partial class FrmAddDocument
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddDocument));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txtDocDes = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.txtDocNumber = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.mskDocDate2 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.mskDocDate1 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.cmbCostGroup = new System.Windows.Forms.ComboBox();
            this.bsCostGroup = new System.Windows.Forms.BindingSource(this.components);
            this.intDocPrice = new DevComponents.Editors.IntegerInput();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
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
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDocPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(483, 375);
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
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 323);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(459, 40);
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
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.FocusCuesEnabled = false;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(370, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "   ثـبت";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.cmbBank);
            this.groupPanel1.Controls.Add(this.txtDocDes);
            this.groupPanel1.Controls.Add(this.lblBank);
            this.groupPanel1.Controls.Add(this.txtDocNumber);
            this.groupPanel1.Controls.Add(this.mskDocDate2);
            this.groupPanel1.Controls.Add(this.mskDocDate1);
            this.groupPanel1.Controls.Add(this.cmbCostGroup);
            this.groupPanel1.Controls.Add(this.intDocPrice);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.lblCost);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(459, 305);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            this.groupPanel1.Text = "مشخصات ثبت سند";
            // 
            // txtDocDes
            // 
            this.txtDocDes.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDocDes.Border.Class = "TextBoxBorder";
            this.txtDocDes.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocDes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "DocumentDes", true));
            this.txtDocDes.DisabledBackColor = System.Drawing.Color.White;
            this.txtDocDes.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtDocDes.FocusHighlightEnabled = true;
            this.txtDocDes.ForeColor = System.Drawing.Color.Black;
            this.txtDocDes.Location = new System.Drawing.Point(31, 173);
            this.txtDocDes.Multiline = true;
            this.txtDocDes.Name = "txtDocDes";
            this.txtDocDes.PreventEnterBeep = true;
            this.txtDocDes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDocDes.Size = new System.Drawing.Size(264, 95);
            this.txtDocDes.TabIndex = 5;
            // 
            // bsDocument
            // 
            this.bsDocument.DataSource = typeof(Accountancy.Document);
            // 
            // txtDocNumber
            // 
            this.txtDocNumber.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtDocNumber.Border.Class = "TextBoxBorder";
            this.txtDocNumber.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtDocNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "DocumentNumber", true));
            this.txtDocNumber.DisabledBackColor = System.Drawing.Color.White;
            this.txtDocNumber.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtDocNumber.FocusHighlightEnabled = true;
            this.txtDocNumber.ForeColor = System.Drawing.Color.Black;
            this.txtDocNumber.Location = new System.Drawing.Point(104, 115);
            this.txtDocNumber.Name = "txtDocNumber";
            this.txtDocNumber.PreventEnterBeep = true;
            this.txtDocNumber.Size = new System.Drawing.Size(191, 22);
            this.txtDocNumber.TabIndex = 3;
            this.txtDocNumber.WatermarkText = "مقداری باید وارد شود";
            // 
            // mskDocDate2
            // 
            // 
            // 
            // 
            this.mskDocDate2.BackgroundStyle.Class = "TextBoxBorder";
            this.mskDocDate2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskDocDate2.ButtonClear.Visible = true;
            this.mskDocDate2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "DocumentDate2", true));
            this.mskDocDate2.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.mskDocDate2.FocusHighlightEnabled = true;
            this.mskDocDate2.Location = new System.Drawing.Point(104, 87);
            this.mskDocDate2.Mask = "####/##/##";
            this.mskDocDate2.Name = "mskDocDate2";
            this.mskDocDate2.Size = new System.Drawing.Size(191, 21);
            this.mskDocDate2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskDocDate2.TabIndex = 2;
            this.mskDocDate2.Text = "";
            // 
            // mskDocDate1
            // 
            // 
            // 
            // 
            this.mskDocDate1.BackgroundStyle.Class = "TextBoxBorder";
            this.mskDocDate1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskDocDate1.ButtonClear.Visible = true;
            this.mskDocDate1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDocument, "DocumentDate1", true));
            this.mskDocDate1.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.mskDocDate1.FocusHighlightEnabled = true;
            this.mskDocDate1.Location = new System.Drawing.Point(104, 58);
            this.mskDocDate1.Mask = "####/##/##";
            this.mskDocDate1.Name = "mskDocDate1";
            this.mskDocDate1.Size = new System.Drawing.Size(191, 21);
            this.mskDocDate1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskDocDate1.TabIndex = 1;
            this.mskDocDate1.Text = "";
            // 
            // cmbCostGroup
            // 
            this.cmbCostGroup.BackColor = System.Drawing.Color.LightGray;
            this.cmbCostGroup.DataSource = this.bsCostGroup;
            this.cmbCostGroup.DisplayMember = "CostGroupName";
            this.cmbCostGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCostGroup.FormattingEnabled = true;
            this.cmbCostGroup.Location = new System.Drawing.Point(31, 28);
            this.cmbCostGroup.Name = "cmbCostGroup";
            this.cmbCostGroup.Size = new System.Drawing.Size(264, 22);
            this.cmbCostGroup.TabIndex = 0;
            this.cmbCostGroup.ValueMember = "CostGroupId";
            // 
            // bsCostGroup
            // 
            this.bsCostGroup.DataSource = typeof(Accountancy.CostGroup);
            // 
            // intDocPrice
            // 
            this.intDocPrice.AllowEmptyState = false;
            // 
            // 
            // 
            this.intDocPrice.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intDocPrice.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intDocPrice.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intDocPrice.DataBindings.Add(new System.Windows.Forms.Binding("ValueObject", this.bsDocument, "DocumentPrice", true));
            this.intDocPrice.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.intDocPrice.FocusHighlightEnabled = true;
            this.intDocPrice.Location = new System.Drawing.Point(104, 144);
            this.intDocPrice.MaxValue = 1000000000;
            this.intDocPrice.MinValue = 0;
            this.intDocPrice.Name = "intDocPrice";
            this.intDocPrice.Size = new System.Drawing.Size(191, 22);
            this.intDocPrice.TabIndex = 4;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(322, 172);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(117, 23);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "شرح ثبت سند";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(322, 143);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(117, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "مبلغ سند";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(322, 114);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(117, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "شماره سند";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(322, 85);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(117, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "تاریخ سررسید سند";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(322, 56);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(117, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "تاریخ ثبت سند";
            // 
            // lblCost
            // 
            // 
            // 
            // 
            this.lblCost.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblCost.Location = new System.Drawing.Point(322, 27);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(117, 23);
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
            this.cmbBank.Location = new System.Drawing.Point(31, 28);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(264, 22);
            this.cmbBank.TabIndex = 6;
            this.cmbBank.ValueMember = "BankId";
            // 
            // lblBank
            // 
            // 
            // 
            // 
            this.lblBank.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBank.Location = new System.Drawing.Point(318, 26);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(121, 23);
            this.lblBank.TabIndex = 5;
            this.lblBank.Text = "انتخاب حساب";
            // 
            // bsBank
            // 
            this.bsBank.DataSource = typeof(Accountancy.Bank);
            // 
            // FrmAddDocument
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(483, 375);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddDocument";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAddDocument_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCostGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intDocPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblCost;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskDocDate1;
        private DevComponents.Editors.IntegerInput intDocPrice;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocNumber;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDocDes;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskDocDate2;
        private System.Windows.Forms.ComboBox cmbCostGroup;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.BindingSource bsCostGroup;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.LabelX lblBank;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.BindingSource bsBank;
    }
}