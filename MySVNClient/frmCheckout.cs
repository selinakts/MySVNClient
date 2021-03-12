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

namespace MySVNClient
{
    public partial class frmCheckout : Form
    {
        public frmCheckout()
        {
            InitializeComponent();
        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (tbLocalPath.Text.Length == 0 || tbRepoURI.Text.Length == 0)
            {
                MessageBox.Show("repository ve localpath alanları boş olamaz");
                return;
            }
            SvnUpdateResult result;
            long revision;
            SvnCheckOutArgs args = new SvnCheckOutArgs();
            string path = tbLocalPath.Text;
            if (long.TryParse(tbRevision.Text, out revision))
            {
                args.Revision = new SvnRevision(revision);
            }
            else
            {
                MessageBox.Show("geçersiz revizyon numarası ,varsayılan HEAD");
            }
            using (SvnClient client = new SvnClient())//SVN deposu için sarmalayıcı sınıf
            {
                try
                {
                    SvnUriTarget target = new SvnUriTarget(tbRepoURI.Text);
                    if (client.CheckOut(target, path, args, out result))
                    {
                        MessageBox.Show("basarılı" + result.Revision + ".");
                    }

                }
                catch(SvnException se)
                {
                    MessageBox.Show(se.Message, "SVN checkout error",
                       MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                catch(UriFormatException ufe)
                {
                    MessageBox.Show(ufe.Message, "SVN checkout error",
                       MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        
        }

        private void frmCheckout_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
