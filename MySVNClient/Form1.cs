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

    public partial class SvnClient : Form
    {
        public SvnClient()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            object command = cbCmdList.SelectedItem;
            if (command == null)//Boş ise
            {
                MessageBox.Show("svn komutu seç");
                return;
            }
            switch (command.ToString())
            {
                case "svn checkout":
                    frmCheckout checkOutFrm = new frmCheckout();
                    checkOutFrm.ShowDialog();
                   

                    break;
                case "svn commit":
                    frmCommit commitFrm = new frmCommit();
                    commitFrm.ShowDialog();
                    break;
                case "svn proplist":
                    frmPropList propListFrm = new frmPropList();
                    propListFrm.ShowDialog();
                    break;

                case "svn propset":
                    frmPropSet setPropSet = new frmPropSet();
                    setPropSet.ShowDialog();
                    break;
                default:
                    MessageBox.Show("svn komutu sec");
                    break;
            }
        }

        internal void Commit(string text, SvnCommitArgs args,  SvnCommitResult result)
        {
           

            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {
                SvnCommitArgs ca = new SvnCommitArgs();
                client.Commit(args.LogMessage , ca);
            }

            

        }

        internal bool CheckOut(SvnUriTarget target, string path, SvnCheckOutArgs args, out SvnUpdateResult result)
        {
            bool checkoutResult;
            

            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {

                client.Authentication.ForceCredentials("selin", "123456");

                checkoutResult = client.CheckOut(new Uri("https://DESKTOP-CK68HBF/svn/test"),
                                        path , out result);

             
            }

            return checkoutResult;
        }
     
    }

}
