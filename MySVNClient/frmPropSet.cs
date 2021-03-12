using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SharpSvn;

namespace MySVNClient
{
    public partial class frmPropSet : Form
    {
        public frmPropSet()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                tbFileValue.Text = ofdOpenFile.FileName;
            }

        }

        private void btnPropSet_Click(object sender, EventArgs e)
        {
            using(SharpSvn.SvnClient client =new SharpSvn.SvnClient())
            {
                try
                {
                    if (rbFileValue.Checked)
                    {
                 
                        client.SetProperty(tbFilePath.Text, tbPropName.Text, File.ReadAllBytes(tbFileValue.Text));
                        MessageBox.Show("eklenen özellik" + tbPropName.Text + "'," + tbFilePath.Text);

                    }
                    
                   
                       
                  
                    
                    
                }
                catch (SvnException se)
                {
                    MessageBox.Show(se.Message, "yeni özellik eklenirken hata oluştu",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                }
                catch (FileNotFoundException fnfe)
                {
                    MessageBox.Show(fnfe.Message,
                    "Geçersiz dosya adı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
