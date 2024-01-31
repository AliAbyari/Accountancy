namespace Accountancy
{
    partial class FrmFactorReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFactorReport));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.gp1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvFactor = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lblSumFactor = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lblSumBook = new DevComponents.DotNetBar.LabelX();
            this.mskDate1 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.mskDate2 = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.bsViewFactor = new System.Windows.Forms.BindingSource(this.components);
            this.factorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorSumPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.gp1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewFactor)).BeginInit();
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
            this.panelEx1.Size = new System.Drawing.Size(872, 528);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // gp1
            // 
            this.gp1.BackColor = System.Drawing.Color.White;
            this.gp1.CanvasColor = System.Drawing.SystemColors.Control;
            this.gp1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gp1.Controls.Add(this.mskDate2);
            this.gp1.Controls.Add(this.mskDate1);
            this.gp1.Controls.Add(this.labelX2);
            this.gp1.Controls.Add(this.lblSumBook);
            this.gp1.Controls.Add(this.labelX5);
            this.gp1.Controls.Add(this.lblSumFactor);
            this.gp1.Controls.Add(this.labelX3);
            this.gp1.Controls.Add(this.labelX1);
            this.gp1.Controls.Add(this.dgvFactor);
            this.gp1.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp1.Location = new System.Drawing.Point(12, 12);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(848, 458);
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
            this.gp1.Text = "نمایش آمار";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 476);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(848, 40);
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
            // dgvFactor
            // 
            this.dgvFactor.AllowUserToAddRows = false;
            this.dgvFactor.AllowUserToDeleteRows = false;
            this.dgvFactor.AutoGenerateColumns = false;
            this.dgvFactor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factorIdDataGridViewTextBoxColumn,
            this.factorDateDataGridViewTextBoxColumn,
            this.factorNumberDataGridViewTextBoxColumn,
            this.personNameDataGridViewTextBoxColumn,
            this.personMobileDataGridViewTextBoxColumn,
            this.factorSumPriceDataGridViewTextBoxColumn});
            this.dgvFactor.DataSource = this.bsViewFactor;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactor.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFactor.EnableHeadersVisualStyles = false;
            this.dgvFactor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvFactor.Location = new System.Drawing.Point(3, 32);
            this.dgvFactor.Name = "dgvFactor";
            this.dgvFactor.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFactor.Size = new System.Drawing.Size(836, 371);
            this.dgvFactor.TabIndex = 0;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(764, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "از  تاریخ";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(276, 3);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "تا  تاریخ";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.Location = new System.Drawing.Point(764, 409);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "جمع فاکتور";
            // 
            // lblSumFactor
            // 
            // 
            // 
            // 
            this.lblSumFactor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSumFactor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSumFactor.Location = new System.Drawing.Point(550, 409);
            this.lblSumFactor.Name = "lblSumFactor";
            this.lblSumFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSumFactor.Size = new System.Drawing.Size(195, 23);
            this.lblSumFactor.TabIndex = 3;
            this.lblSumFactor.Text = "0";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX5.Location = new System.Drawing.Point(217, 409);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "تسویه شده";
            // 
            // lblSumBook
            // 
            // 
            // 
            // 
            this.lblSumBook.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSumBook.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSumBook.Location = new System.Drawing.Point(3, 409);
            this.lblSumBook.Name = "lblSumBook";
            this.lblSumBook.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSumBook.Size = new System.Drawing.Size(195, 23);
            this.lblSumBook.TabIndex = 4;
            this.lblSumBook.Text = "0";
            // 
            // mskDate1
            // 
            // 
            // 
            // 
            this.mskDate1.BackgroundStyle.Class = "TextBoxBorder";
            this.mskDate1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskDate1.ButtonClear.Visible = true;
            this.mskDate1.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.mskDate1.FocusHighlightEnabled = true;
            this.mskDate1.Location = new System.Drawing.Point(527, 5);
            this.mskDate1.Mask = "####/##/##";
            this.mskDate1.Name = "mskDate1";
            this.mskDate1.Size = new System.Drawing.Size(191, 21);
            this.mskDate1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskDate1.TabIndex = 1;
            this.mskDate1.Text = "";
            this.mskDate1.TextChanged += new System.EventHandler(this.mskDate1_TextChanged);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnExit.FocusCuesEnabled = false;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnExit.Size = new System.Drawing.Size(90, 30);
            this.btnExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "  خـروج";
            this.btnExit.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mskDate2
            // 
            // 
            // 
            // 
            this.mskDate2.BackgroundStyle.Class = "TextBoxBorder";
            this.mskDate2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.mskDate2.ButtonClear.Visible = true;
            this.mskDate2.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.mskDate2.FocusHighlightEnabled = true;
            this.mskDate2.Location = new System.Drawing.Point(3, 5);
            this.mskDate2.Mask = "####/##/##";
            this.mskDate2.Name = "mskDate2";
            this.mskDate2.Size = new System.Drawing.Size(191, 21);
            this.mskDate2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.mskDate2.TabIndex = 2;
            this.mskDate2.Text = "";
            this.mskDate2.TextChanged += new System.EventHandler(this.mskDate2_TextChanged);
            // 
            // bsViewFactor
            // 
            this.bsViewFactor.DataSource = typeof(Accountancy.ViewFactor);
            // 
            // factorIdDataGridViewTextBoxColumn
            // 
            this.factorIdDataGridViewTextBoxColumn.DataPropertyName = "FactorId";
            this.factorIdDataGridViewTextBoxColumn.HeaderText = "FactorId";
            this.factorIdDataGridViewTextBoxColumn.Name = "factorIdDataGridViewTextBoxColumn";
            this.factorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // factorDateDataGridViewTextBoxColumn
            // 
            this.factorDateDataGridViewTextBoxColumn.DataPropertyName = "FactorDate";
            this.factorDateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.factorDateDataGridViewTextBoxColumn.Name = "factorDateDataGridViewTextBoxColumn";
            this.factorDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorDateDataGridViewTextBoxColumn.Width = 110;
            // 
            // factorNumberDataGridViewTextBoxColumn
            // 
            this.factorNumberDataGridViewTextBoxColumn.DataPropertyName = "FactorNumber";
            this.factorNumberDataGridViewTextBoxColumn.HeaderText = "شماره";
            this.factorNumberDataGridViewTextBoxColumn.Name = "factorNumberDataGridViewTextBoxColumn";
            this.factorNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorNumberDataGridViewTextBoxColumn.Width = 110;
            // 
            // personNameDataGridViewTextBoxColumn
            // 
            this.personNameDataGridViewTextBoxColumn.DataPropertyName = "PersonName";
            this.personNameDataGridViewTextBoxColumn.HeaderText = "نام و نام خانوادگی";
            this.personNameDataGridViewTextBoxColumn.Name = "personNameDataGridViewTextBoxColumn";
            this.personNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.personNameDataGridViewTextBoxColumn.Width = 230;
            // 
            // personMobileDataGridViewTextBoxColumn
            // 
            this.personMobileDataGridViewTextBoxColumn.DataPropertyName = "PersonMobile";
            this.personMobileDataGridViewTextBoxColumn.HeaderText = "شماره همراه";
            this.personMobileDataGridViewTextBoxColumn.Name = "personMobileDataGridViewTextBoxColumn";
            this.personMobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.personMobileDataGridViewTextBoxColumn.Width = 130;
            // 
            // factorSumPriceDataGridViewTextBoxColumn
            // 
            this.factorSumPriceDataGridViewTextBoxColumn.DataPropertyName = "FactorSumPrice";
            this.factorSumPriceDataGridViewTextBoxColumn.HeaderText = "هزینه فاکتور";
            this.factorSumPriceDataGridViewTextBoxColumn.Name = "factorSumPriceDataGridViewTextBoxColumn";
            this.factorSumPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorSumPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // FrmFactorReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 528);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmFactorReport";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmFactorReport_Load);
            this.panelEx1.ResumeLayout(false);
            this.gp1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel gp1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactor;
        private DevComponents.DotNetBar.LabelX lblSumBook;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lblSumFactor;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskDate2;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv mskDate1;
        private System.Windows.Forms.BindingSource bsViewFactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorSumPriceDataGridViewTextBoxColumn;
    }
}