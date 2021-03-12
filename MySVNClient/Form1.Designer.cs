namespace MySVNClient
{
    partial class SvnClient
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
            this.lblPrompt = new System.Windows.Forms.Label();
            this.cbCmdList = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Maiandra GD", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(79, 42);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(374, 14);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "Çalıştırmak için bir SVN komutu seçin ve ardından \'Git\'i tıklayın";
            // 
            // cbCmdList
            // 
            this.cbCmdList.FormattingEnabled = true;
            this.cbCmdList.Items.AddRange(new object[] {
            "svn checkout",
            "svn commit",
            "svn proplist",
            "svn propset"});
            this.cbCmdList.Location = new System.Drawing.Point(185, 88);
            this.cbCmdList.Name = "cbCmdList";
            this.cbCmdList.Size = new System.Drawing.Size(159, 21);
            this.cbCmdList.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(185, 149);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(51, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "GİT";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(269, 149);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 3;
            this.btnQuit.Text = "ÇIK";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // SvnClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 267);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbCmdList);
            this.Controls.Add(this.lblPrompt);
            this.Name = "SvnClient";
            this.Text = "SVN Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.ComboBox cbCmdList;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnQuit;
    }
}

