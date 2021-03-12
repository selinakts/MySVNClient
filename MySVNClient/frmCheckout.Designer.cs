namespace MySVNClient
{
    partial class frmCheckout
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
            this.lbLRepoURI = new System.Windows.Forms.Label();
            this.lblLocalPath = new System.Windows.Forms.Label();
            this.lblRevision = new System.Windows.Forms.Label();
            this.tbRepoURI = new System.Windows.Forms.TextBox();
            this.tbLocalPath = new System.Windows.Forms.TextBox();
            this.tbRevision = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLRepoURI
            // 
            this.lbLRepoURI.AutoSize = true;
            this.lbLRepoURI.Location = new System.Drawing.Point(39, 35);
            this.lbLRepoURI.Name = "lbLRepoURI";
            this.lbLRepoURI.Size = new System.Drawing.Size(60, 13);
            this.lbLRepoURI.TabIndex = 0;
            this.lbLRepoURI.Text = "Repository:";
            // 
            // lblLocalPath
            // 
            this.lblLocalPath.AutoSize = true;
            this.lblLocalPath.Location = new System.Drawing.Point(39, 85);
            this.lblLocalPath.Name = "lblLocalPath";
            this.lblLocalPath.Size = new System.Drawing.Size(61, 13);
            this.lblLocalPath.TabIndex = 1;
            this.lblLocalPath.Text = "Local Path:";
            // 
            // lblRevision
            // 
            this.lblRevision.AutoSize = true;
            this.lblRevision.Location = new System.Drawing.Point(39, 130);
            this.lblRevision.Name = "lblRevision";
            this.lblRevision.Size = new System.Drawing.Size(51, 13);
            this.lblRevision.TabIndex = 2;
            this.lblRevision.Text = "Revision:";
            // 
            // tbRepoURI
            // 
            this.tbRepoURI.Location = new System.Drawing.Point(109, 35);
            this.tbRepoURI.Name = "tbRepoURI";
            this.tbRepoURI.Size = new System.Drawing.Size(185, 20);
            this.tbRepoURI.TabIndex = 3;
            // 
            // tbLocalPath
            // 
            this.tbLocalPath.Location = new System.Drawing.Point(109, 85);
            this.tbLocalPath.Name = "tbLocalPath";
            this.tbLocalPath.Size = new System.Drawing.Size(185, 20);
            this.tbLocalPath.TabIndex = 4;
            // 
            // tbRevision
            // 
            this.tbRevision.Location = new System.Drawing.Point(109, 130);
            this.tbRevision.Name = "tbRevision";
            this.tbRevision.Size = new System.Drawing.Size(92, 20);
            this.tbRevision.TabIndex = 5;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(109, 190);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(75, 23);
            this.btnCheckOut.TabIndex = 6;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 189);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 304);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.tbRevision);
            this.Controls.Add(this.tbLocalPath);
            this.Controls.Add(this.tbRepoURI);
            this.Controls.Add(this.lblRevision);
            this.Controls.Add(this.lblLocalPath);
            this.Controls.Add(this.lbLRepoURI);
            this.Name = "frmCheckout";
            this.Text = "frmCheckout";
            this.Load += new System.EventHandler(this.frmCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLRepoURI;
        private System.Windows.Forms.Label lblLocalPath;
        private System.Windows.Forms.Label lblRevision;
        private System.Windows.Forms.TextBox tbRepoURI;
        private System.Windows.Forms.TextBox tbLocalPath;
        private System.Windows.Forms.TextBox tbRevision;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Button btnCancel;
    }
}