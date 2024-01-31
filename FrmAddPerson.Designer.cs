namespace Accountancy
{
    partial class FrmAddPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddPerson));
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnExit = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.intDebtor = new DevComponents.Editors.IntegerInput();
            this.txtPersonName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPersonTel = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtPersonMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.intCreditor = new DevComponents.Editors.IntegerInput();
            this.bsPerson = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intDebtor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intCreditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.panelEx1.Size = new System.Drawing.Size(420, 290);
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
            this.groupPanel1.Controls.Add(this.txtPersonTel);
            this.groupPanel1.Controls.Add(this.intCreditor);
            this.groupPanel1.Controls.Add(this.intDebtor);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.txtPersonMobile);
            this.groupPanel1.Controls.Add(this.txtPersonName);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Location = new System.Drawing.Point(12, 12);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(396, 220);
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
            this.groupPanel1.Text = "ثبت مشخصات شخص";
            // 
            // groupPanel2
            // 
            this.groupPanel2.BackColor = System.Drawing.Color.White;
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.btnSave);
            this.groupPanel2.Controls.Add(this.btnExit);
            this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel2.Location = new System.Drawing.Point(12, 238);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(396, 40);
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
            this.btnSave.Location = new System.Drawing.Point(307, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10, 4, 4, 10);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "   ثـبت";
            this.btnSave.TextAlignment = DevComponents.DotNetBar.eButtonTextAlignment.Right;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(259, 29);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(114, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "نام و نام خانوادگی";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(259, 58);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(114, 23);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "شماره همراه";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(259, 87);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(114, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "شماره ثابت";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(259, 116);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(114, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "بدهکاری از قبل";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(259, 145);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(114, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "بستانکاری از قبل";
            // 
            // intDebtor
            // 
            this.intDebtor.AllowEmptyState = false;
            // 
            // 
            // 
            this.intDebtor.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intDebtor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intDebtor.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intDebtor.DataBindings.Add(new System.Windows.Forms.Binding("ValueObject", this.bsPerson, "PersonDebtor", true));
            this.intDebtor.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.intDebtor.FocusHighlightEnabled = true;
            this.intDebtor.Location = new System.Drawing.Point(120, 117);
            this.intDebtor.MaxValue = 1000;
            this.intDebtor.MinValue = 0;
            this.intDebtor.Name = "intDebtor";
            this.intDebtor.Size = new System.Drawing.Size(133, 22);
            this.intDebtor.TabIndex = 3;
            // 
            // txtPersonName
            // 
            this.txtPersonName.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPersonName.Border.Class = "TextBoxBorder";
            this.txtPersonName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPersonName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "PersonName", true));
            this.txtPersonName.DisabledBackColor = System.Drawing.Color.White;
            this.txtPersonName.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtPersonName.FocusHighlightEnabled = true;
            this.txtPersonName.ForeColor = System.Drawing.Color.Black;
            this.txtPersonName.Location = new System.Drawing.Point(37, 30);
            this.txtPersonName.MaxLength = 100;
            this.txtPersonName.Name = "txtPersonName";
            this.txtPersonName.PreventEnterBeep = true;
            this.txtPersonName.Size = new System.Drawing.Size(216, 22);
            this.txtPersonName.TabIndex = 0;
            this.txtPersonName.WatermarkText = "مقداری باید وارد شود";
            // 
            // txtPersonTel
            // 
            this.txtPersonTel.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPersonTel.Border.Class = "TextBoxBorder";
            this.txtPersonTel.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPersonTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "PersonTel", true));
            this.txtPersonTel.DisabledBackColor = System.Drawing.Color.White;
            this.txtPersonTel.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtPersonTel.FocusHighlightEnabled = true;
            this.txtPersonTel.ForeColor = System.Drawing.Color.Black;
            this.txtPersonTel.Location = new System.Drawing.Point(37, 88);
            this.txtPersonTel.MaxLength = 20;
            this.txtPersonTel.Name = "txtPersonTel";
            this.txtPersonTel.PreventEnterBeep = true;
            this.txtPersonTel.Size = new System.Drawing.Size(216, 22);
            this.txtPersonTel.TabIndex = 2;
            // 
            // txtPersonMobile
            // 
            this.txtPersonMobile.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.txtPersonMobile.Border.Class = "TextBoxBorder";
            this.txtPersonMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPersonMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPerson, "PersonMobile", true));
            this.txtPersonMobile.DisabledBackColor = System.Drawing.Color.White;
            this.txtPersonMobile.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.txtPersonMobile.FocusHighlightEnabled = true;
            this.txtPersonMobile.ForeColor = System.Drawing.Color.Black;
            this.txtPersonMobile.Location = new System.Drawing.Point(37, 59);
            this.txtPersonMobile.MaxLength = 11;
            this.txtPersonMobile.Name = "txtPersonMobile";
            this.txtPersonMobile.PreventEnterBeep = true;
            this.txtPersonMobile.Size = new System.Drawing.Size(216, 22);
            this.txtPersonMobile.TabIndex = 1;
            this.txtPersonMobile.WatermarkText = "مقداری باید وارد شود";
            // 
            // intCreditor
            // 
            this.intCreditor.AllowEmptyState = false;
            // 
            // 
            // 
            this.intCreditor.BackgroundStyle.Class = "DateTimeInputBackground";
            this.intCreditor.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.intCreditor.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.intCreditor.DataBindings.Add(new System.Windows.Forms.Binding("ValueObject", this.bsPerson, "PersonCreditor", true));
            this.intCreditor.FocusHighlightColor = System.Drawing.Color.LightGray;
            this.intCreditor.FocusHighlightEnabled = true;
            this.intCreditor.Location = new System.Drawing.Point(120, 146);
            this.intCreditor.MaxValue = 1000;
            this.intCreditor.MinValue = 0;
            this.intCreditor.Name = "intCreditor";
            this.intCreditor.Size = new System.Drawing.Size(133, 22);
            this.intCreditor.TabIndex = 4;
            // 
            // bsPerson
            // 
            this.bsPerson.DataSource = typeof(Accountancy.People);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // FrmAddPerson
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(420, 290);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddPerson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAddPerson_Load);
            this.panelEx1.ResumeLayout(false);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intDebtor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intCreditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.ButtonX btnExit;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPersonTel;
        private DevComponents.Editors.IntegerInput intCreditor;
        private DevComponents.Editors.IntegerInput intDebtor;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPersonMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPersonName;
        private System.Windows.Forms.BindingSource bsPerson;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}