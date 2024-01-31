namespace Accountancy
{
    partial class FrmShowFactorFacture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowFactorFacture));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.gp1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblSumBuy = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblSumSale = new DevComponents.DotNetBar.LabelX();
            this.dgvFactor = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.bsFactor = new System.Windows.Forms.BindingSource(this.components);
            this.factorIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorTaxPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorServicePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorCutPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factorSumPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.gp1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactor)).BeginInit();
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
            this.panelEx1.Size = new System.Drawing.Size(859, 490);
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
            this.gp1.Controls.Add(this.dgvFactor);
            this.gp1.Controls.Add(this.lblSumSale);
            this.gp1.Controls.Add(this.labelX2);
            this.gp1.Controls.Add(this.lblSumBuy);
            this.gp1.Controls.Add(this.labelX1);
            this.gp1.DisabledBackColor = System.Drawing.Color.Empty;
            this.gp1.Location = new System.Drawing.Point(12, 12);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(835, 420);
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
            this.gp1.Text = "نمایش فاکتور های";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnPrint);
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 438);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(835, 40);
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
            // lblSumBuy
            // 
            // 
            // 
            // 
            this.lblSumBuy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSumBuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSumBuy.Location = new System.Drawing.Point(562, 371);
            this.lblSumBuy.Name = "lblSumBuy";
            this.lblSumBuy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSumBuy.Size = new System.Drawing.Size(162, 23);
            this.lblSumBuy.TabIndex = 2;
            this.lblSumBuy.Text = "0";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(730, 371);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(96, 23);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "مجموع خرید";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(171, 371);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(96, 23);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "مجموع فروش";
            // 
            // lblSumSale
            // 
            // 
            // 
            // 
            this.lblSumSale.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblSumSale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSumSale.Location = new System.Drawing.Point(3, 371);
            this.lblSumSale.Name = "lblSumSale";
            this.lblSumSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSumSale.Size = new System.Drawing.Size(162, 23);
            this.lblSumSale.TabIndex = 2;
            this.lblSumSale.Text = "0";
            // 
            // dgvFactor
            // 
            this.dgvFactor.AllowUserToAddRows = false;
            this.dgvFactor.AllowUserToDeleteRows = false;
            this.dgvFactor.AutoGenerateColumns = false;
            this.dgvFactor.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFactor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factorIdDataGridViewTextBoxColumn,
            this.factorTypeDataGridViewTextBoxColumn,
            this.factorNumberDataGridViewTextBoxColumn,
            this.factorDateDataGridViewTextBoxColumn,
            this.factorPriceDataGridViewTextBoxColumn,
            this.factorTaxPriceDataGridViewTextBoxColumn,
            this.factorServicePriceDataGridViewTextBoxColumn,
            this.factorCutPriceDataGridViewTextBoxColumn,
            this.factorSumPriceDataGridViewTextBoxColumn,
            this.Column1});
            this.dgvFactor.DataSource = this.bsFactor;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFactor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvFactor.EnableHeadersVisualStyles = false;
            this.dgvFactor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvFactor.Location = new System.Drawing.Point(3, 3);
            this.dgvFactor.Name = "dgvFactor";
            this.dgvFactor.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFactor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvFactor.Size = new System.Drawing.Size(823, 362);
            this.dgvFactor.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.FocusCuesEnabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(726, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnPrint.Size = new System.Drawing.Size(100, 30);
            this.btnPrint.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = " پیش نمایش";
            this.btnPrint.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // bsFactor
            // 
            this.bsFactor.DataSource = typeof(Accountancy.Factor);
            // 
            // factorIdDataGridViewTextBoxColumn
            // 
            this.factorIdDataGridViewTextBoxColumn.DataPropertyName = "FactorId";
            this.factorIdDataGridViewTextBoxColumn.HeaderText = "FactorId";
            this.factorIdDataGridViewTextBoxColumn.Name = "factorIdDataGridViewTextBoxColumn";
            this.factorIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // factorTypeDataGridViewTextBoxColumn
            // 
            this.factorTypeDataGridViewTextBoxColumn.DataPropertyName = "FactorType";
            this.factorTypeDataGridViewTextBoxColumn.HeaderText = "FactorType";
            this.factorTypeDataGridViewTextBoxColumn.Name = "factorTypeDataGridViewTextBoxColumn";
            this.factorTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // factorNumberDataGridViewTextBoxColumn
            // 
            this.factorNumberDataGridViewTextBoxColumn.DataPropertyName = "FactorNumber";
            this.factorNumberDataGridViewTextBoxColumn.HeaderText = "شماره فاکتور";
            this.factorNumberDataGridViewTextBoxColumn.Name = "factorNumberDataGridViewTextBoxColumn";
            this.factorNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factorDateDataGridViewTextBoxColumn
            // 
            this.factorDateDataGridViewTextBoxColumn.DataPropertyName = "FactorDate";
            this.factorDateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.factorDateDataGridViewTextBoxColumn.Name = "factorDateDataGridViewTextBoxColumn";
            this.factorDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // factorPriceDataGridViewTextBoxColumn
            // 
            this.factorPriceDataGridViewTextBoxColumn.DataPropertyName = "FactorPrice";
            this.factorPriceDataGridViewTextBoxColumn.HeaderText = "هزینه اجناس";
            this.factorPriceDataGridViewTextBoxColumn.Name = "factorPriceDataGridViewTextBoxColumn";
            this.factorPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factorTaxPriceDataGridViewTextBoxColumn
            // 
            this.factorTaxPriceDataGridViewTextBoxColumn.DataPropertyName = "FactorTaxPrice";
            this.factorTaxPriceDataGridViewTextBoxColumn.HeaderText = "ارزش افزوده";
            this.factorTaxPriceDataGridViewTextBoxColumn.Name = "factorTaxPriceDataGridViewTextBoxColumn";
            this.factorTaxPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factorServicePriceDataGridViewTextBoxColumn
            // 
            this.factorServicePriceDataGridViewTextBoxColumn.DataPropertyName = "FactorServicePrice";
            this.factorServicePriceDataGridViewTextBoxColumn.HeaderText = "هزینه خدمات";
            this.factorServicePriceDataGridViewTextBoxColumn.Name = "factorServicePriceDataGridViewTextBoxColumn";
            this.factorServicePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // factorCutPriceDataGridViewTextBoxColumn
            // 
            this.factorCutPriceDataGridViewTextBoxColumn.DataPropertyName = "FactorCutPrice";
            this.factorCutPriceDataGridViewTextBoxColumn.HeaderText = "تخفیف";
            this.factorCutPriceDataGridViewTextBoxColumn.Name = "factorCutPriceDataGridViewTextBoxColumn";
            this.factorCutPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.factorCutPriceDataGridViewTextBoxColumn.Width = 90;
            // 
            // factorSumPriceDataGridViewTextBoxColumn
            // 
            this.factorSumPriceDataGridViewTextBoxColumn.DataPropertyName = "FactorSumPrice";
            this.factorSumPriceDataGridViewTextBoxColumn.HeaderText = "جمع کل";
            this.factorSumPriceDataGridViewTextBoxColumn.Name = "factorSumPriceDataGridViewTextBoxColumn";
            this.factorSumPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "نوع فاکتور";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // FrmShowFactorFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(859, 490);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmShowFactorFacture";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmShowFactorFacture_Load);
            this.panelEx1.ResumeLayout(false);
            this.gp1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFactor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel gp1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX lblSumSale;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX lblSumBuy;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFactor;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorTaxPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorServicePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorCutPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factorSumPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource bsFactor;
    }
}