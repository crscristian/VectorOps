namespace VectorOps
{
    partial class VectorOps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VectorOps));
            this.lblTitle = new System.Windows.Forms.Label();
            this.radVector2D = new System.Windows.Forms.RadioButton();
            this.radVector3D = new System.Windows.Forms.RadioButton();
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.Vector1 = new System.Windows.Forms.Label();
            this.Vector2 = new System.Windows.Forms.Label();
            this.txtXV1 = new System.Windows.Forms.TextBox();
            this.txtYV1 = new System.Windows.Forms.TextBox();
            this.txtZV1 = new System.Windows.Forms.TextBox();
            this.txtXV2 = new System.Windows.Forms.TextBox();
            this.txtYV2 = new System.Windows.Forms.TextBox();
            this.txtZV2 = new System.Windows.Forms.TextBox();
            this.XV1 = new System.Windows.Forms.Label();
            this.YV1 = new System.Windows.Forms.Label();
            this.ZV1 = new System.Windows.Forms.Label();
            this.XV2 = new System.Windows.Forms.Label();
            this.YV2 = new System.Windows.Forms.Label();
            this.ZV2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.errorProviderXV1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZV2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderZV1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderYV1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderYV2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderXV2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelZ = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.txtResultZ = new System.Windows.Forms.TextBox();
            this.txtResultY = new System.Windows.Forms.TextBox();
            this.txtResultX = new System.Windows.Forms.TextBox();
            this.txtNormVector = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderXV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderXV2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(482, 54);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(403, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vector Calculator";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radVector2D
            // 
            this.radVector2D.AutoSize = true;
            this.radVector2D.BackColor = System.Drawing.Color.Transparent;
            this.radVector2D.CausesValidation = false;
            this.radVector2D.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radVector2D.Checked = true;
            this.radVector2D.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVector2D.ForeColor = System.Drawing.Color.Orange;
            this.radVector2D.Location = new System.Drawing.Point(130, 131);
            this.radVector2D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radVector2D.Name = "radVector2D";
            this.radVector2D.Size = new System.Drawing.Size(81, 78);
            this.radVector2D.TabIndex = 1;
            this.radVector2D.TabStop = true;
            this.radVector2D.Text = "2D";
            this.radVector2D.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radVector2D.UseVisualStyleBackColor = false;
            this.radVector2D.CheckedChanged += new System.EventHandler(this.radVector2D_CheckedChanged);
            // 
            // radVector3D
            // 
            this.radVector3D.AutoSize = true;
            this.radVector3D.BackColor = System.Drawing.Color.Transparent;
            this.radVector3D.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radVector3D.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVector3D.ForeColor = System.Drawing.Color.Orange;
            this.radVector3D.Location = new System.Drawing.Point(242, 131);
            this.radVector3D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radVector3D.Name = "radVector3D";
            this.radVector3D.Size = new System.Drawing.Size(81, 78);
            this.radVector3D.TabIndex = 3;
            this.radVector3D.Text = "3D";
            this.radVector3D.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radVector3D.UseVisualStyleBackColor = false;
            this.radVector3D.CheckedChanged += new System.EventHandler(this.radVector3D_CheckedChanged);
            // 
            // cmbOption
            // 
            this.cmbOption.AllowDrop = true;
            this.cmbOption.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbOption.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbOption.DropDownHeight = 68;
            this.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOption.DropDownWidth = 100;
            this.cmbOption.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOption.ForeColor = System.Drawing.Color.Black;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbOption.IntegralHeight = false;
            this.cmbOption.Location = new System.Drawing.Point(57, 239);
            this.cmbOption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbOption.MaxDropDownItems = 2;
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOption.Size = new System.Drawing.Size(319, 46);
            this.cmbOption.TabIndex = 0;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // Vector1
            // 
            this.Vector1.AutoSize = true;
            this.Vector1.BackColor = System.Drawing.Color.Transparent;
            this.Vector1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vector1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Vector1.Location = new System.Drawing.Point(57, 412);
            this.Vector1.Name = "Vector1";
            this.Vector1.Size = new System.Drawing.Size(131, 38);
            this.Vector1.TabIndex = 4;
            this.Vector1.Text = "Vector a";
            // 
            // Vector2
            // 
            this.Vector2.AutoSize = true;
            this.Vector2.BackColor = System.Drawing.Color.Transparent;
            this.Vector2.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vector2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Vector2.Location = new System.Drawing.Point(55, 576);
            this.Vector2.Name = "Vector2";
            this.Vector2.Size = new System.Drawing.Size(131, 38);
            this.Vector2.TabIndex = 5;
            this.Vector2.Text = "Vector b";
            // 
            // txtXV1
            // 
            this.txtXV1.BackColor = System.Drawing.Color.SkyBlue;
            this.txtXV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXV1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXV1.Location = new System.Drawing.Point(74, 491);
            this.txtXV1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXV1.Name = "txtXV1";
            this.txtXV1.Size = new System.Drawing.Size(83, 36);
            this.txtXV1.TabIndex = 6;
            this.txtXV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYV1
            // 
            this.txtYV1.BackColor = System.Drawing.Color.SkyBlue;
            this.txtYV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYV1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYV1.Location = new System.Drawing.Point(242, 491);
            this.txtYV1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYV1.Name = "txtYV1";
            this.txtYV1.Size = new System.Drawing.Size(83, 36);
            this.txtYV1.TabIndex = 7;
            this.txtYV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZV1
            // 
            this.txtZV1.BackColor = System.Drawing.Color.SkyBlue;
            this.txtZV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZV1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZV1.Location = new System.Drawing.Point(429, 491);
            this.txtZV1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZV1.Name = "txtZV1";
            this.txtZV1.Size = new System.Drawing.Size(83, 36);
            this.txtZV1.TabIndex = 8;
            this.txtZV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXV2
            // 
            this.txtXV2.BackColor = System.Drawing.Color.SkyBlue;
            this.txtXV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXV2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXV2.Location = new System.Drawing.Point(74, 654);
            this.txtXV2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXV2.Name = "txtXV2";
            this.txtXV2.Size = new System.Drawing.Size(83, 36);
            this.txtXV2.TabIndex = 9;
            this.txtXV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYV2
            // 
            this.txtYV2.BackColor = System.Drawing.Color.SkyBlue;
            this.txtYV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYV2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYV2.Location = new System.Drawing.Point(242, 654);
            this.txtYV2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYV2.Name = "txtYV2";
            this.txtYV2.Size = new System.Drawing.Size(83, 36);
            this.txtYV2.TabIndex = 10;
            this.txtYV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZV2
            // 
            this.txtZV2.BackColor = System.Drawing.Color.SkyBlue;
            this.txtZV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZV2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZV2.Location = new System.Drawing.Point(429, 654);
            this.txtZV2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZV2.Name = "txtZV2";
            this.txtZV2.Size = new System.Drawing.Size(83, 36);
            this.txtZV2.TabIndex = 11;
            this.txtZV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XV1
            // 
            this.XV1.AutoSize = true;
            this.XV1.BackColor = System.Drawing.Color.Transparent;
            this.XV1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XV1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.XV1.Location = new System.Drawing.Point(159, 474);
            this.XV1.Name = "XV1";
            this.XV1.Size = new System.Drawing.Size(59, 65);
            this.XV1.TabIndex = 12;
            this.XV1.Text = "X";
            // 
            // YV1
            // 
            this.YV1.AutoSize = true;
            this.YV1.BackColor = System.Drawing.Color.Transparent;
            this.YV1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YV1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.YV1.Location = new System.Drawing.Point(327, 474);
            this.YV1.Name = "YV1";
            this.YV1.Size = new System.Drawing.Size(57, 65);
            this.YV1.TabIndex = 13;
            this.YV1.Text = "Y";
            // 
            // ZV1
            // 
            this.ZV1.AutoSize = true;
            this.ZV1.BackColor = System.Drawing.Color.Transparent;
            this.ZV1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZV1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZV1.Location = new System.Drawing.Point(511, 474);
            this.ZV1.Name = "ZV1";
            this.ZV1.Size = new System.Drawing.Size(57, 65);
            this.ZV1.TabIndex = 14;
            this.ZV1.Text = "Z";
            // 
            // XV2
            // 
            this.XV2.AutoSize = true;
            this.XV2.BackColor = System.Drawing.Color.Transparent;
            this.XV2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XV2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.XV2.Location = new System.Drawing.Point(159, 636);
            this.XV2.Name = "XV2";
            this.XV2.Size = new System.Drawing.Size(59, 65);
            this.XV2.TabIndex = 15;
            this.XV2.Text = "X";
            // 
            // YV2
            // 
            this.YV2.AutoSize = true;
            this.YV2.BackColor = System.Drawing.Color.Transparent;
            this.YV2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YV2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.YV2.Location = new System.Drawing.Point(327, 636);
            this.YV2.Name = "YV2";
            this.YV2.Size = new System.Drawing.Size(57, 65);
            this.YV2.TabIndex = 16;
            this.YV2.Text = "Y";
            // 
            // ZV2
            // 
            this.ZV2.AutoSize = true;
            this.ZV2.BackColor = System.Drawing.Color.Transparent;
            this.ZV2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZV2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZV2.Location = new System.Drawing.Point(511, 636);
            this.ZV2.Name = "ZV2";
            this.ZV2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZV2.Size = new System.Drawing.Size(57, 65);
            this.ZV2.TabIndex = 17;
            this.ZV2.Text = "Z";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(914, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(934, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 48);
            this.label2.TabIndex = 19;
            this.label2.Text = "Rezultat";
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.AutoSize = true;
            this.txtResult.BackColor = System.Drawing.Color.Transparent;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Red;
            this.txtResult.Location = new System.Drawing.Point(642, 300);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(116, 38);
            this.txtResult.TabIndex = 20;
            this.txtResult.Text = "...........";
            this.txtResult.Visible = false;
            // 
            // errorProviderXV1
            // 
            this.errorProviderXV1.ContainerControl = this;
            // 
            // errorProviderZV2
            // 
            this.errorProviderZV2.ContainerControl = this;
            // 
            // errorProviderZV1
            // 
            this.errorProviderZV1.ContainerControl = this;
            // 
            // errorProviderYV1
            // 
            this.errorProviderYV1.ContainerControl = this;
            // 
            // errorProviderYV2
            // 
            this.errorProviderYV2.ContainerControl = this;
            // 
            // errorProviderXV2
            // 
            this.errorProviderXV2.ContainerControl = this;
            // 
            // labelZ
            // 
            this.labelZ.AutoSize = true;
            this.labelZ.BackColor = System.Drawing.Color.Transparent;
            this.labelZ.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZ.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelZ.Location = new System.Drawing.Point(1172, 440);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(57, 65);
            this.labelZ.TabIndex = 26;
            this.labelZ.Text = "Z";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.BackColor = System.Drawing.Color.Transparent;
            this.labelY.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelY.Location = new System.Drawing.Point(988, 440);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(57, 65);
            this.labelY.TabIndex = 25;
            this.labelY.Text = "Y";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.BackColor = System.Drawing.Color.Transparent;
            this.labelX.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelX.Location = new System.Drawing.Point(820, 440);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(59, 65);
            this.labelX.TabIndex = 24;
            this.labelX.Text = "X";
            // 
            // txtResultZ
            // 
            this.txtResultZ.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtResultZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultZ.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultZ.Location = new System.Drawing.Point(1090, 458);
            this.txtResultZ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultZ.Name = "txtResultZ";
            this.txtResultZ.ReadOnly = true;
            this.txtResultZ.Size = new System.Drawing.Size(83, 36);
            this.txtResultZ.TabIndex = 23;
            this.txtResultZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultY
            // 
            this.txtResultY.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtResultY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultY.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultY.Location = new System.Drawing.Point(903, 458);
            this.txtResultY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultY.Name = "txtResultY";
            this.txtResultY.ReadOnly = true;
            this.txtResultY.Size = new System.Drawing.Size(83, 36);
            this.txtResultY.TabIndex = 22;
            this.txtResultY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultX
            // 
            this.txtResultX.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtResultX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultX.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultX.Location = new System.Drawing.Point(735, 458);
            this.txtResultX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtResultX.Name = "txtResultX";
            this.txtResultX.ReadOnly = true;
            this.txtResultX.Size = new System.Drawing.Size(83, 36);
            this.txtResultX.TabIndex = 21;
            this.txtResultX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNormVector
            // 
            this.txtNormVector.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.txtNormVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNormVector.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNormVector.Location = new System.Drawing.Point(872, 388);
            this.txtNormVector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNormVector.Name = "txtNormVector";
            this.txtNormVector.ReadOnly = true;
            this.txtNormVector.Size = new System.Drawing.Size(83, 36);
            this.txtNormVector.TabIndex = 27;
            this.txtNormVector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textResult
            // 
            this.textResult.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.textResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textResult.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResult.Location = new System.Drawing.Point(1091, 388);
            this.textResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(83, 36);
            this.textResult.TabIndex = 28;
            this.textResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // VectorOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1320, 778);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.txtNormVector);
            this.Controls.Add(this.labelZ);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.txtResultZ);
            this.Controls.Add(this.txtResultY);
            this.Controls.Add(this.txtResultX);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZV2);
            this.Controls.Add(this.YV2);
            this.Controls.Add(this.XV2);
            this.Controls.Add(this.ZV1);
            this.Controls.Add(this.YV1);
            this.Controls.Add(this.XV1);
            this.Controls.Add(this.txtZV2);
            this.Controls.Add(this.txtYV2);
            this.Controls.Add(this.txtXV2);
            this.Controls.Add(this.txtZV1);
            this.Controls.Add(this.txtYV1);
            this.Controls.Add(this.txtXV1);
            this.Controls.Add(this.Vector2);
            this.Controls.Add(this.Vector1);
            this.Controls.Add(this.cmbOption);
            this.Controls.Add(this.radVector3D);
            this.Controls.Add(this.radVector2D);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(1437, 836);
            this.MinimumSize = new System.Drawing.Size(1200, 586);
            this.Name = "VectorOps";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "VectorOps";
            this.Load += new System.EventHandler(this.VectorOps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderXV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderZV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderXV2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radVector2D;
        private System.Windows.Forms.RadioButton radVector3D;
        private System.Windows.Forms.ComboBox cmbOption;
        private System.Windows.Forms.Label Vector1;
        private System.Windows.Forms.Label Vector2;
        private System.Windows.Forms.TextBox txtXV1;
        private System.Windows.Forms.TextBox txtYV1;
        private System.Windows.Forms.TextBox txtZV1;
        private System.Windows.Forms.TextBox txtXV2;
        private System.Windows.Forms.TextBox txtYV2;
        private System.Windows.Forms.TextBox txtZV2;
        private System.Windows.Forms.Label XV1;
        private System.Windows.Forms.Label YV1;
        private System.Windows.Forms.Label ZV1;
        private System.Windows.Forms.Label XV2;
        private System.Windows.Forms.Label YV2;
        private System.Windows.Forms.Label ZV2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.ErrorProvider errorProviderXV1;
        private System.Windows.Forms.ErrorProvider errorProviderZV2;
        private System.Windows.Forms.ErrorProvider errorProviderZV1;
        private System.Windows.Forms.ErrorProvider errorProviderYV1;
        private System.Windows.Forms.ErrorProvider errorProviderYV2;
        private System.Windows.Forms.ErrorProvider errorProviderXV2;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox txtResultZ;
        private System.Windows.Forms.TextBox txtResultY;
        private System.Windows.Forms.TextBox txtResultX;
        private System.Windows.Forms.TextBox txtNormVector;
        private System.Windows.Forms.TextBox textResult;
    }
}

