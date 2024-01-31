namespace Accountancy
{
    partial class FrmShowMoneyFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmShowMoneyFacture));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnPrint = new DevComponents.DotNetBar.ButtonX();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnBook1 = new DevComponents.DotNetBar.ButtonX();
            this.lblBookBuy = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.lblBookSale = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.lblDocBuy = new DevComponents.DotNetBar.LabelX();
            this.lblDocSale = new DevComponents.DotNetBar.LabelX();
            this.dgvBook4 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dgvDocument = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.btnDoc2 = new DevComponents.DotNetBar.ButtonX();
            this.btnDoc1 = new DevComponents.DotNetBar.ButtonX();
            this.btnBook2 = new DevComponents.DotNetBar.ButtonX();
            this.bsDocument = new System.Windows.Forms.BindingSource(this.components);
            this.bsBook = new System.Windows.Forms.BindingSource(this.components);
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDate1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDate2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentDesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBook)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.groupPanel3);
            this.panelEx1.Controls.Add(this.groupPanel2);
            this.panelEx1.Controls.Add(this.groupPanel1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(820, 565);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 0;
            // 
            // groupPanel1
            // 
            this.groupPanel1.BackColor = System.Drawing.Color.White;
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.btnBook2);
            this.groupPanel1.Controls.Add(this.btnBook1);
            this.groupPanel1.Controls.Add(this.dgvBook4);
            this.groupPanel1.Controls.Add(this.lblBookSale);
            this.groupPanel1.Controls.Add(this.lblBookBuy);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(796, 254);
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
            this.groupPanel1.Text = "نمایش تراکنش های نقد";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnDoc1);
            this.groupPanel2.Controls.Add(this.btnDoc2);
            this.groupPanel2.Controls.Add(this.dgvDocument);
            this.groupPanel2.Controls.Add(this.lblDocSale);
            this.groupPanel2.Controls.Add(this.labelX4);
            this.groupPanel2.Controls.Add(this.lblDocBuy);
            this.groupPanel2.Controls.Add(this.labelX5);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 272);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(796, 235);
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
            this.groupPanel2.Text = "نمایش اسناد وصول نشده";
            // 
            // groupPanel3
            // 
            this.groupPanel3.BackColor = System.Drawing.Color.White;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.btnPrint);
            this.groupPanel3.Controls.Add(this.btnExit);
            this.groupPanel3.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel3.Location = new System.Drawing.Point(12, 513);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(796, 40);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel3.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel3.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnPrint.FocusCuesEnabled = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(687, 2);
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
            // btnBook1
            // 
            this.btnBook1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBook1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBook1.FocusCuesEnabled = false;
            this.btnBook1.Image = ((System.Drawing.Image)(resources.GetObject("btnBook1.Image")));
            this.btnBook1.Location = new System.Drawing.Point(647, 3);
            this.btnBook1.Name = "btnBook1";
            this.btnBook1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnBook1.Size = new System.Drawing.Size(140, 30);
            this.btnBook1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBook1.TabIndex = 0;
            this.btnBook1.Text = "    دریافت نـقـد";
            this.btnBook1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnBook1.Click += new System.EventHandler(this.btnBook1_Click);
            // 
            // lblBookBuy
            // 
            // 
            // 
            // 
            this.lblBookBuy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBookBuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBookBuy.Location = new System.Drawing.Point(501, 205);
            this.lblBookBuy.Name = "lblBookBuy";
            this.lblBookBuy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBookBuy.Size = new System.Drawing.Size(162, 23);
            this.lblBookBuy.TabIndex = 4;
            this.lblBookBuy.Text = "0";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(669, 205);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(118, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "مجموع پرداخت خرید";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(175, 205);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(118, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "مجموع پرداخت فروش";
            // 
            // lblBookSale
            // 
            // 
            // 
            // 
            this.lblBookSale.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBookSale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblBookSale.Location = new System.Drawing.Point(7, 205);
            this.lblBookSale.Name = "lblBookSale";
            this.lblBookSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBookSale.Size = new System.Drawing.Size(162, 23);
            this.lblBookSale.TabIndex = 4;
            this.lblBookSale.Text = "0";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(669, 186);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(118, 23);
            this.labelX4.TabIndex = 5;
            this.labelX4.Text = "مجموع سند خرید";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(175, 186);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(118, 23);
            this.labelX5.TabIndex = 5;
            this.labelX5.Text = "مجموع سند فروش";
            // 
            // lblDocBuy
            // 
            // 
            // 
            // 
            this.lblDocBuy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDocBuy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDocBuy.Location = new System.Drawing.Point(501, 186);
            this.lblDocBuy.Name = "lblDocBuy";
            this.lblDocBuy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDocBuy.Size = new System.Drawing.Size(162, 23);
            this.lblDocBuy.TabIndex = 4;
            this.lblDocBuy.Text = "0";
            // 
            // lblDocSale
            // 
            // 
            // 
            // 
            this.lblDocSale.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDocSale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblDocSale.Location = new System.Drawing.Point(7, 186);
            this.lblDocSale.Name = "lblDocSale";
            this.lblDocSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDocSale.Size = new System.Drawing.Size(162, 23);
            this.lblDocSale.TabIndex = 4;
            this.lblDocSale.Text = "0";
            // 
            // dgvBook4
            // 
            this.dgvBook4.AllowUserToAddRows = false;
            this.dgvBook4.AllowUserToDeleteRows = false;
            this.dgvBook4.AutoGenerateColumns = false;
            this.dgvBook4.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvBook4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookDateDataGridViewTextBoxColumn,
            this.bookTimeDataGridViewTextBoxColumn,
            this.bookDesDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn});
            this.dgvBook4.DataSource = this.bsBook;
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBook4.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvBook4.EnableHeadersVisualStyles = false;
            this.dgvBook4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvBook4.Location = new System.Drawing.Point(7, 39);
            this.dgvBook4.Name = "dgvBook4";
            this.dgvBook4.ReadOnly = true;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook4.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvBook4.Size = new System.Drawing.Size(780, 160);
            this.dgvBook4.TabIndex = 2;
            // 
            // dgvDocument
            // 
            this.dgvDocument.AllowUserToAddRows = false;
            this.dgvDocument.AllowUserToDeleteRows = false;
            this.dgvDocument.AutoGenerateColumns = false;
            this.dgvDocument.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocument.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgvDocument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.documentIdDataGridViewTextBoxColumn,
            this.documentDate1DataGridViewTextBoxColumn,
            this.documentDate2DataGridViewTextBoxColumn,
            this.documentNumberDataGridViewTextBoxColumn,
            this.documentDesDataGridViewTextBoxColumn,
            this.documentPriceDataGridViewTextBoxColumn});
            this.dgvDocument.DataSource = this.bsDocument;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDocument.DefaultCellStyle = dataGridViewCellStyle32;
            this.dgvDocument.EnableHeadersVisualStyles = false;
            this.dgvDocument.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.dgvDocument.Location = new System.Drawing.Point(7, 39);
            this.dgvDocument.Name = "dgvDocument";
            this.dgvDocument.ReadOnly = true;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocument.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvDocument.Size = new System.Drawing.Size(780, 141);
            this.dgvDocument.TabIndex = 2;
            // 
            // btnDoc2
            // 
            this.btnDoc2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDoc2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDoc2.FocusCuesEnabled = false;
            this.btnDoc2.Image = ((System.Drawing.Image)(resources.GetObject("btnDoc2.Image")));
            this.btnDoc2.Location = new System.Drawing.Point(7, 3);
            this.btnDoc2.Name = "btnDoc2";
            this.btnDoc2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnDoc2.Size = new System.Drawing.Size(140, 30);
            this.btnDoc2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDoc2.TabIndex = 1;
            this.btnDoc2.Text = "    پرداخت سند";
            this.btnDoc2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnDoc2.Click += new System.EventHandler(this.btnDoc2_Click);
            // 
            // btnDoc1
            // 
            this.btnDoc1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDoc1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDoc1.FocusCuesEnabled = false;
            this.btnDoc1.Image = ((System.Drawing.Image)(resources.GetObject("btnDoc1.Image")));
            this.btnDoc1.Location = new System.Drawing.Point(647, 3);
            this.btnDoc1.Name = "btnDoc1";
            this.btnDoc1.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnDoc1.Size = new System.Drawing.Size(140, 30);
            this.btnDoc1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDoc1.TabIndex = 0;
            this.btnDoc1.Text = "    دریافت سند";
            this.btnDoc1.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnDoc1.Click += new System.EventHandler(this.btnDoc1_Click);
            // 
            // btnBook2
            // 
            this.btnBook2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBook2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBook2.FocusCuesEnabled = false;
            this.btnBook2.Image = ((System.Drawing.Image)(resources.GetObject("btnBook2.Image")));
            this.btnBook2.Location = new System.Drawing.Point(7, 3);
            this.btnBook2.Name = "btnBook2";
            this.btnBook2.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnBook2.Size = new System.Drawing.Size(140, 30);
            this.btnBook2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnBook2.TabIndex = 1;
            this.btnBook2.Text = "    پرداخت نـقـد";
            this.btnBook2.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnBook2.Click += new System.EventHandler(this.btnBook2_Click);
            // 
            // bsDocument
            // 
            this.bsDocument.DataSource = typeof(Accountancy.Document);
            // 
            // bsBook
            // 
            this.bsBook.DataSource = typeof(Accountancy.Book);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookDateDataGridViewTextBoxColumn
            // 
            this.bookDateDataGridViewTextBoxColumn.DataPropertyName = "BookDate";
            this.bookDateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.bookDateDataGridViewTextBoxColumn.Name = "bookDateDataGridViewTextBoxColumn";
            this.bookDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookDateDataGridViewTextBoxColumn.Width = 90;
            // 
            // bookTimeDataGridViewTextBoxColumn
            // 
            this.bookTimeDataGridViewTextBoxColumn.DataPropertyName = "BookTime";
            this.bookTimeDataGridViewTextBoxColumn.HeaderText = "زمان";
            this.bookTimeDataGridViewTextBoxColumn.Name = "bookTimeDataGridViewTextBoxColumn";
            this.bookTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookTimeDataGridViewTextBoxColumn.Width = 90;
            // 
            // bookDesDataGridViewTextBoxColumn
            // 
            this.bookDesDataGridViewTextBoxColumn.DataPropertyName = "BookDes";
            this.bookDesDataGridViewTextBoxColumn.HeaderText = "شرح تراکنش";
            this.bookDesDataGridViewTextBoxColumn.Name = "bookDesDataGridViewTextBoxColumn";
            this.bookDesDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookDesDataGridViewTextBoxColumn.Width = 400;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "BookPrice";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "مبلغ";
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentIdDataGridViewTextBoxColumn
            // 
            this.documentIdDataGridViewTextBoxColumn.DataPropertyName = "DocumentId";
            this.documentIdDataGridViewTextBoxColumn.HeaderText = "DocumentId";
            this.documentIdDataGridViewTextBoxColumn.Name = "documentIdDataGridViewTextBoxColumn";
            this.documentIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // documentDate1DataGridViewTextBoxColumn
            // 
            this.documentDate1DataGridViewTextBoxColumn.DataPropertyName = "DocumentDate1";
            this.documentDate1DataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.documentDate1DataGridViewTextBoxColumn.Name = "documentDate1DataGridViewTextBoxColumn";
            this.documentDate1DataGridViewTextBoxColumn.ReadOnly = true;
            this.documentDate1DataGridViewTextBoxColumn.Width = 90;
            // 
            // documentDate2DataGridViewTextBoxColumn
            // 
            this.documentDate2DataGridViewTextBoxColumn.DataPropertyName = "DocumentDate2";
            this.documentDate2DataGridViewTextBoxColumn.HeaderText = "سررسید";
            this.documentDate2DataGridViewTextBoxColumn.Name = "documentDate2DataGridViewTextBoxColumn";
            this.documentDate2DataGridViewTextBoxColumn.ReadOnly = true;
            this.documentDate2DataGridViewTextBoxColumn.Width = 90;
            // 
            // documentNumberDataGridViewTextBoxColumn
            // 
            this.documentNumberDataGridViewTextBoxColumn.DataPropertyName = "DocumentNumber";
            this.documentNumberDataGridViewTextBoxColumn.HeaderText = "شماره سند";
            this.documentNumberDataGridViewTextBoxColumn.Name = "documentNumberDataGridViewTextBoxColumn";
            this.documentNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentDesDataGridViewTextBoxColumn
            // 
            this.documentDesDataGridViewTextBoxColumn.DataPropertyName = "DocumentDes";
            this.documentDesDataGridViewTextBoxColumn.HeaderText = "شرح";
            this.documentDesDataGridViewTextBoxColumn.Name = "documentDesDataGridViewTextBoxColumn";
            this.documentDesDataGridViewTextBoxColumn.ReadOnly = true;
            this.documentDesDataGridViewTextBoxColumn.Width = 300;
            // 
            // documentPriceDataGridViewTextBoxColumn
            // 
            this.documentPriceDataGridViewTextBoxColumn.DataPropertyName = "DocumentPrice";
            this.documentPriceDataGridViewTextBoxColumn.HeaderText = "مبلغ";
            this.documentPriceDataGridViewTextBoxColumn.Name = "documentPriceDataGridViewTextBoxColumn";
            this.documentPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmShowMoneyFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(820, 565);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmShowMoneyFacture";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmShowMoneyFacture_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDocument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnPrint;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.ButtonX btnBook1;
        private DevComponents.DotNetBar.LabelX lblBookBuy;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX lblDocSale;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX lblDocBuy;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX lblBookSale;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDocument;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvBook4;
        private DevComponents.DotNetBar.ButtonX btnDoc1;
        private DevComponents.DotNetBar.ButtonX btnDoc2;
        private DevComponents.DotNetBar.ButtonX btnBook2;
        private System.Windows.Forms.BindingSource bsDocument;
        private System.Windows.Forms.BindingSource bsBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDate1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDate2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookDesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
    }
}