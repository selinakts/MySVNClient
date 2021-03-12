namespace MySVNClient
{
    partial class frmPropList
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
            this.cbRecurse = new System.Windows.Forms.CheckBox();
            this.lbFileURI = new System.Windows.Forms.Label();
            this.lbProperties = new System.Windows.Forms.Label();
            this.tbFileURI = new System.Windows.Forms.TextBox();
            this.btnGetProp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lvProps = new System.Windows.Forms.ListView();
            this.chFilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPropName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPropValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbRecurse
            // 
            this.cbRecurse.AutoSize = true;
            this.cbRecurse.Location = new System.Drawing.Point(30, 92);
            this.cbRecurse.Name = "cbRecurse";
            this.cbRecurse.Size = new System.Drawing.Size(145, 17);
            this.cbRecurse.TabIndex = 1;
            this.cbRecurse.Text = "Recurse into Directories?";
            this.cbRecurse.UseVisualStyleBackColor = true;
            // 
            // lbFileURI
            // 
            this.lbFileURI.AutoSize = true;
            this.lbFileURI.Location = new System.Drawing.Point(27, 28);
            this.lbFileURI.Name = "lbFileURI";
            this.lbFileURI.Size = new System.Drawing.Size(48, 13);
            this.lbFileURI.TabIndex = 2;
            this.lbFileURI.Text = "File URI:";
            // 
            // lbProperties
            // 
            this.lbProperties.AutoSize = true;
            this.lbProperties.Location = new System.Drawing.Point(22, 134);
            this.lbProperties.Name = "lbProperties";
            this.lbProperties.Size = new System.Drawing.Size(57, 13);
            this.lbProperties.TabIndex = 3;
            this.lbProperties.Text = "Properties:";
            // 
            // tbFileURI
            // 
            this.tbFileURI.Location = new System.Drawing.Point(81, 25);
            this.tbFileURI.Name = "tbFileURI";
            this.tbFileURI.Size = new System.Drawing.Size(313, 20);
            this.tbFileURI.TabIndex = 4;
            // 
            // btnGetProp
            // 
            this.btnGetProp.Location = new System.Drawing.Point(193, 88);
            this.btnGetProp.Name = "btnGetProp";
            this.btnGetProp.Size = new System.Drawing.Size(91, 23);
            this.btnGetProp.TabIndex = 5;
            this.btnGetProp.Text = "Get Properties\r\n";
            this.btnGetProp.UseVisualStyleBackColor = true;
            this.btnGetProp.Click += new System.EventHandler(this.btnGetProp_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 88);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lvProps
            // 
            this.lvProps.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFilePath,
            this.chPropName,
            this.chPropValue});
            this.lvProps.GridLines = true;
            this.lvProps.Location = new System.Drawing.Point(25, 160);
            this.lvProps.Name = "lvProps";
            this.lvProps.Size = new System.Drawing.Size(369, 169);
            this.lvProps.TabIndex = 7;
            this.lvProps.UseCompatibleStateImageBehavior = false;
            this.lvProps.View = System.Windows.Forms.View.Details;
            this.lvProps.SelectedIndexChanged += new System.EventHandler(this.lvProps_SelectedIndexChanged);
            // 
            // chFilePath
            // 
            this.chFilePath.Text = "File";
            this.chFilePath.Width = -2;
            // 
            // chPropName
            // 
            this.chPropName.Text = "Name";
            this.chPropName.Width = -2;
            // 
            // chPropValue
            // 
            this.chPropValue.Width = -2;
            // 
            // frmPropList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 341);
            this.Controls.Add(this.lvProps);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetProp);
            this.Controls.Add(this.tbFileURI);
            this.Controls.Add(this.lbProperties);
            this.Controls.Add(this.lbFileURI);
            this.Controls.Add(this.cbRecurse);
            this.Location = new System.Drawing.Point(12, 88);
            this.Name = "frmPropList";
            this.Text = "frmPropList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbRecurse;
        private System.Windows.Forms.Label lbFileURI;
        private System.Windows.Forms.Label lbProperties;
        private System.Windows.Forms.TextBox tbFileURI;
        private System.Windows.Forms.Button btnGetProp;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListView lvProps;
        private System.Windows.Forms.ColumnHeader chFilePath;
        private System.Windows.Forms.ColumnHeader chPropName;
        private System.Windows.Forms.ColumnHeader chPropValue;
    }
}