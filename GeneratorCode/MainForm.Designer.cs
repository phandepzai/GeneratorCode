namespace QRDataMatrix
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputBox = new System.Windows.Forms.TextBox();
            this.radioQR = new System.Windows.Forms.RadioButton();
            this.radioDM = new System.Windows.Forms.RadioButton();
            this.chkAppendSuffix = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCode1 = new System.Windows.Forms.Label();
            this.lblCode2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBox.Location = new System.Drawing.Point(51, 8);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(475, 40);
            this.inputBox.TabIndex = 0;
            this.inputBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioQR
            // 
            this.radioQR.AutoSize = true;
            this.radioQR.Checked = true;
            this.radioQR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioQR.Location = new System.Drawing.Point(132, 62);
            this.radioQR.Name = "radioQR";
            this.radioQR.Size = new System.Drawing.Size(79, 21);
            this.radioQR.TabIndex = 1;
            this.radioQR.TabStop = true;
            this.radioQR.Text = "QR Code";
            this.radioQR.UseVisualStyleBackColor = true;
            // 
            // radioDM
            // 
            this.radioDM.AutoSize = true;
            this.radioDM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDM.Location = new System.Drawing.Point(231, 62);
            this.radioDM.Name = "radioDM";
            this.radioDM.Size = new System.Drawing.Size(95, 21);
            this.radioDM.TabIndex = 2;
            this.radioDM.Text = "DataMatrix";
            this.radioDM.UseVisualStyleBackColor = true;
            // 
            // chkAppendSuffix
            // 
            this.chkAppendSuffix.AutoSize = true;
            this.chkAppendSuffix.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAppendSuffix.Location = new System.Drawing.Point(363, 62);
            this.chkAppendSuffix.Name = "chkAppendSuffix";
            this.chkAppendSuffix.Size = new System.Drawing.Size(144, 21);
            this.chkAppendSuffix.TabIndex = 3;
            this.chkAppendSuffix.Text = "Thêm hậu tố #1 #2";
            this.chkAppendSuffix.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(30, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox2.Location = new System.Drawing.Point(350, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // lblCode1
            // 
            this.lblCode1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode1.Location = new System.Drawing.Point(30, 307);
            this.lblCode1.Name = "lblCode1";
            this.lblCode1.Size = new System.Drawing.Size(200, 60);
            this.lblCode1.TabIndex = 6;
            this.lblCode1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCode2
            // 
            this.lblCode2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode2.Location = new System.Drawing.Point(351, 307);
            this.lblCode2.Name = "lblCode2";
            this.lblCode2.Size = new System.Drawing.Size(200, 60);
            this.lblCode2.TabIndex = 7;
            this.lblCode2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(241, 370);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(5, 375);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblCopyright.ForeColor = System.Drawing.Color.DarkGray;
            this.lblCopyright.Location = new System.Drawing.Point(424, 404);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(146, 13);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "Copyright by Nông Văn Phấn";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 421);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblCode2);
            this.Controls.Add(this.lblCode1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chkAppendSuffix);
            this.Controls.Add(this.radioDM);
            this.Controls.Add(this.radioQR);
            this.Controls.Add(this.inputBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "QR & DataMatrix Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.RadioButton radioQR;
        private System.Windows.Forms.RadioButton radioDM;
        private System.Windows.Forms.CheckBox chkAppendSuffix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCode1;
        private System.Windows.Forms.Label lblCode2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCopyright;
    }
}
