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
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(432, 60);
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
            this.radVector2D.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVector2D.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.radVector2D.Location = new System.Drawing.Point(82, 140);
            this.radVector2D.Name = "radVector2D";
            this.radVector2D.Size = new System.Drawing.Size(70, 66);
            this.radVector2D.TabIndex = 1;
            this.radVector2D.TabStop = true;
            this.radVector2D.Text = "2D";
            this.radVector2D.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radVector2D.UseVisualStyleBackColor = false;
            // 
            // radVector3D
            // 
            this.radVector3D.AutoSize = true;
            this.radVector3D.BackColor = System.Drawing.Color.Transparent;
            this.radVector3D.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radVector3D.Font = new System.Drawing.Font("Segoe UI Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radVector3D.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.radVector3D.Location = new System.Drawing.Point(170, 140);
            this.radVector3D.Name = "radVector3D";
            this.radVector3D.Size = new System.Drawing.Size(70, 66);
            this.radVector3D.TabIndex = 3;
            this.radVector3D.TabStop = true;
            this.radVector3D.Text = "3D";
            this.radVector3D.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.radVector3D.UseVisualStyleBackColor = false;
            // 
            // cmbOption
            // 
            this.cmbOption.AllowDrop = true;
            this.cmbOption.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbOption.DropDownHeight = 68;
            this.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOption.DropDownWidth = 100;
            this.cmbOption.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOption.ForeColor = System.Drawing.Color.Black;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbOption.IntegralHeight = false;
            this.cmbOption.Location = new System.Drawing.Point(25, 226);
            this.cmbOption.MaxDropDownItems = 2;
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOption.Size = new System.Drawing.Size(284, 45);
            this.cmbOption.TabIndex = 0;
            // 
            // VectorOps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1173, 633);
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
    }
}

