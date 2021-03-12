namespace MySVNClient
{
    partial class frmPropSet
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblPropName = new System.Windows.Forms.Label();
            this.rbTextValue = new System.Windows.Forms.RadioButton();
            this.rbFileValue = new System.Windows.Forms.RadioButton();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.tbPropName = new System.Windows.Forms.TextBox();
            this.tbTextValue = new System.Windows.Forms.TextBox();
            this.tbFileValue = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnPropSet = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "\"\"";
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(26, 54);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(51, 13);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "File Path:";
            // 
            // lblPropName
            // 
            this.lblPropName.AutoSize = true;
            this.lblPropName.Location = new System.Drawing.Point(26, 81);
            this.lblPropName.Name = "lblPropName";
            this.lblPropName.Size = new System.Drawing.Size(80, 13);
            this.lblPropName.TabIndex = 1;
            this.lblPropName.Text = "Property Name:";
            // 
            // rbTextValue
            // 
            this.rbTextValue.AutoSize = true;
            this.rbTextValue.Checked = true;
            this.rbTextValue.Location = new System.Drawing.Point(29, 119);
            this.rbTextValue.Name = "rbTextValue";
            this.rbTextValue.Size = new System.Drawing.Size(113, 17);
            this.rbTextValue.TabIndex = 2;
            this.rbTextValue.TabStop = true;
            this.rbTextValue.Text = "Enter a Text Value";
            this.rbTextValue.UseVisualStyleBackColor = true;
            // 
            // rbFileValue
            // 
            this.rbFileValue.AutoSize = true;
            this.rbFileValue.Location = new System.Drawing.Point(29, 159);
            this.rbFileValue.Name = "rbFileValue";
            this.rbFileValue.Size = new System.Drawing.Size(132, 17);
            this.rbFileValue.TabIndex = 3;
            this.rbFileValue.Text = "İmport Value  From File";
            this.rbFileValue.UseVisualStyleBackColor = true;
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(167, 47);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(272, 20);
            this.tbFilePath.TabIndex = 4;
            // 
            // tbPropName
            // 
            this.tbPropName.Location = new System.Drawing.Point(167, 81);
            this.tbPropName.Name = "tbPropName";
            this.tbPropName.Size = new System.Drawing.Size(272, 20);
            this.tbPropName.TabIndex = 5;
            // 
            // tbTextValue
            // 
            this.tbTextValue.Location = new System.Drawing.Point(167, 119);
            this.tbTextValue.Name = "tbTextValue";
            this.tbTextValue.Size = new System.Drawing.Size(272, 20);
            this.tbTextValue.TabIndex = 6;
            // 
            // tbFileValue
            // 
            this.tbFileValue.Location = new System.Drawing.Point(167, 159);
            this.tbFileValue.Name = "tbFileValue";
            this.tbFileValue.Size = new System.Drawing.Size(272, 20);
            this.tbFileValue.TabIndex = 7;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(463, 157);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 8;
            this.btnBrowse.Text = "Browse..";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnPropSet
            // 
            this.btnPropSet.Location = new System.Drawing.Point(229, 209);
            this.btnPropSet.Name = "btnPropSet";
            this.btnPropSet.Size = new System.Drawing.Size(75, 23);
            this.btnPropSet.TabIndex = 9;
            this.btnPropSet.Text = "Set Property";
            this.btnPropSet.UseVisualStyleBackColor = true;
            this.btnPropSet.Click += new System.EventHandler(this.btnPropSet_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(354, 209);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPropSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 321);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPropSet);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFileValue);
            this.Controls.Add(this.tbTextValue);
            this.Controls.Add(this.tbPropName);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.rbFileValue);
            this.Controls.Add(this.rbTextValue);
            this.Controls.Add(this.lblPropName);
            this.Controls.Add(this.lblFilePath);
            this.Name = "frmPropSet";
            this.Text = "frmPropSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblPropName;
        private System.Windows.Forms.RadioButton rbTextValue;
        private System.Windows.Forms.RadioButton rbFileValue;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox tbPropName;
        private System.Windows.Forms.TextBox tbTextValue;
        private System.Windows.Forms.TextBox tbFileValue;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnPropSet;
        private System.Windows.Forms.Button btnClose;
    }
}