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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(428, 43);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(332, 54);
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
            this.radVector2D.Location = new System.Drawing.Point(116, 105);
            this.radVector2D.Name = "radVector2D";
            this.radVector2D.Size = new System.Drawing.Size(69, 65);
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
            this.radVector3D.Location = new System.Drawing.Point(215, 105);
            this.radVector3D.Name = "radVector3D";
            this.radVector3D.Size = new System.Drawing.Size(69, 65);
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
            this.cmbOption.Location = new System.Drawing.Point(51, 191);
            this.cmbOption.MaxDropDownItems = 2;
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOption.Size = new System.Drawing.Size(284, 39);
            this.cmbOption.TabIndex = 0;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // Vector1
            // 
            this.Vector1.AutoSize = true;
            this.Vector1.BackColor = System.Drawing.Color.Transparent;
            this.Vector1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vector1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Vector1.Location = new System.Drawing.Point(51, 316);
            this.Vector1.Name = "Vector1";
            this.Vector1.Size = new System.Drawing.Size(102, 31);
            this.Vector1.TabIndex = 4;
            this.Vector1.Text = "Vector 1";
            // 
            // Vector2
            // 
            this.Vector2.AutoSize = true;
            this.Vector2.BackColor = System.Drawing.Color.Transparent;
            this.Vector2.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vector2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Vector2.Location = new System.Drawing.Point(49, 426);
            this.Vector2.Name = "Vector2";
            this.Vector2.Size = new System.Drawing.Size(104, 31);
            this.Vector2.TabIndex = 5;
            this.Vector2.Text = "Vector 2";
            // 
            // txtXV1
            // 
            this.txtXV1.BackColor = System.Drawing.Color.SkyBlue;
            this.txtXV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXV1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXV1.Location = new System.Drawing.Point(66, 371);
            this.txtXV1.Name = "txtXV1";
            this.txtXV1.Size = new System.Drawing.Size(74, 31);
            this.txtXV1.TabIndex = 6;
            this.txtXV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYV1
            // 
            this.txtYV1.BackColor = System.Drawing.Color.SkyBlue;
            this.txtYV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYV1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYV1.Location = new System.Drawing.Point(215, 371);
            this.txtYV1.Name = "txtYV1";
            this.txtYV1.Size = new System.Drawing.Size(74, 31);
            this.txtYV1.TabIndex = 7;
            this.txtYV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZV1
            // 
            this.txtZV1.BackColor = System.Drawing.Color.SkyBlue;
            this.txtZV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZV1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZV1.Location = new System.Drawing.Point(381, 371);
            this.txtZV1.Name = "txtZV1";
            this.txtZV1.Size = new System.Drawing.Size(74, 31);
            this.txtZV1.TabIndex = 8;
            this.txtZV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtXV2
            // 
            this.txtXV2.BackColor = System.Drawing.Color.SkyBlue;
            this.txtXV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtXV2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXV2.Location = new System.Drawing.Point(66, 478);
            this.txtXV2.Name = "txtXV2";
            this.txtXV2.Size = new System.Drawing.Size(74, 31);
            this.txtXV2.TabIndex = 9;
            this.txtXV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYV2
            // 
            this.txtYV2.BackColor = System.Drawing.Color.SkyBlue;
            this.txtYV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYV2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYV2.Location = new System.Drawing.Point(215, 478);
            this.txtYV2.Name = "txtYV2";
            this.txtYV2.Size = new System.Drawing.Size(74, 31);
            this.txtYV2.TabIndex = 10;
            this.txtYV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtZV2
            // 
            this.txtZV2.BackColor = System.Drawing.Color.SkyBlue;
            this.txtZV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZV2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZV2.Location = new System.Drawing.Point(381, 478);
            this.txtZV2.Name = "txtZV2";
            this.txtZV2.Size = new System.Drawing.Size(74, 31);
            this.txtZV2.TabIndex = 11;
            this.txtZV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // XV1
            // 
            this.XV1.AutoSize = true;
            this.XV1.BackColor = System.Drawing.Color.Transparent;
            this.XV1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XV1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.XV1.Location = new System.Drawing.Point(136, 357);
            this.XV1.Name = "XV1";
            this.XV1.Size = new System.Drawing.Size(49, 54);
            this.XV1.TabIndex = 12;
            this.XV1.Text = "X";
            // 
            // YV1
            // 
            this.YV1.AutoSize = true;
            this.YV1.BackColor = System.Drawing.Color.Transparent;
            this.YV1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YV1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.YV1.Location = new System.Drawing.Point(286, 357);
            this.YV1.Name = "YV1";
            this.YV1.Size = new System.Drawing.Size(47, 54);
            this.YV1.TabIndex = 13;
            this.YV1.Text = "Y";
            // 
            // ZV1
            // 
            this.ZV1.AutoSize = true;
            this.ZV1.BackColor = System.Drawing.Color.Transparent;
            this.ZV1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZV1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZV1.Location = new System.Drawing.Point(449, 357);
            this.ZV1.Name = "ZV1";
            this.ZV1.Size = new System.Drawing.Size(47, 54);
            this.ZV1.TabIndex = 14;
            this.ZV1.Text = "Z";
            // 
            // XV2
            // 
            this.XV2.AutoSize = true;
            this.XV2.BackColor = System.Drawing.Color.Transparent;
            this.XV2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XV2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.XV2.Location = new System.Drawing.Point(136, 464);
            this.XV2.Name = "XV2";
            this.XV2.Size = new System.Drawing.Size(49, 54);
            this.XV2.TabIndex = 15;
            this.XV2.Text = "X";
            // 
            // YV2
            // 
            this.YV2.AutoSize = true;
            this.YV2.BackColor = System.Drawing.Color.Transparent;
            this.YV2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YV2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.YV2.Location = new System.Drawing.Point(286, 464);
            this.YV2.Name = "YV2";
            this.YV2.Size = new System.Drawing.Size(47, 54);
            this.YV2.TabIndex = 16;
            this.YV2.Text = "Y";
            // 
            // ZV2
            // 
            this.ZV2.AutoSize = true;
            this.ZV2.BackColor = System.Drawing.Color.Transparent;
            this.ZV2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZV2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZV2.Location = new System.Drawing.Point(449, 464);
            this.ZV2.Name = "ZV2";
            this.ZV2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ZV2.Size = new System.Drawing.Size(47, 54);
            this.ZV2.TabIndex = 17;
            this.ZV2.Text = "Z";
            // 
            // VectorOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 633);
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
            this.MaximumSize = new System.Drawing.Size(1280, 680);
            this.MinimumSize = new System.Drawing.Size(780, 480);
            this.Name = "VectorOps";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "VectorOps";
            this.Load += new System.EventHandler(this.VectorOps_Load);
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
    }
}

