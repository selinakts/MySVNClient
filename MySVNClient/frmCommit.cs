using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpSvn;
using SharpSvn.UI;

namespace MySVNClient
{
    public partial class frmCommit : Form
    {
        public frmCommit()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (ofdFileSelector.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = ofdFileSelector.FileName;
            }

        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (tbFileName.Text.Length == 0)
            {
                MessageBox.Show("dosya seç");
                return;
            }
            SvnCommitArgs args = new SvnCommitArgs();
            args.LogMessage = tbMessage.Text;
            SvnCommitResult result;

            using (SharpSvn.SvnClient client =new SharpSvn.SvnClient())
            {
                try
                {
                    SvnUI.Bind(client,this);
                    
                    client.Commit(tbFileName.Text, args, out result);
                    if (result != null)
                    {
                        MessageBox.Show("başarıyla revize edildi" + result.Revision + ".");

                    }
                    else
                    {
                        MessageBox.Show("teslim edildiğinden beri hiçbir değişiklilik yapılmamıştır");
                    }

                }
               
                   catch (SvnException se)
                {
                    MessageBox.Show(se.Message + "Error: " + se.SvnErrorCode + Environment.NewLine,
                    "svn commit error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }

                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
