using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class frmPropList : Form
    {
        public frmPropList()
        {
            InitializeComponent();
        }

        private void btnGetProp_Click(object sender, EventArgs e)
        {
            if (tbFileURI.Text.Length == 0)
            {
                MessageBox.Show("geçerli bir URI girin");
                return;
            }

            lvProps.Items.Clear();//liste görüntüsünü temizliyor

            SvnTarget tgt = SvnTarget.FromString(tbFileURI.Text);// Bu, özellikleri aldığımız hedef dosya olacak
            System.Collections.ObjectModel.Collection<SvnPropertyListEventArgs> proplist;
            SvnPropertyListArgs args = new SvnPropertyListArgs();//argmanlar koyabilecegimiz yer
            if (cbRecurse.Checked == true)
            {
                args.Depth = SvnDepth.Infinity;
            }
            using (SharpSvn.SvnClient client = new SharpSvn.SvnClient())
            {
                try
                {
                    client.GetPropertyList(tgt, args, out proplist);
                    foreach (SvnPropertyListEventArgs node in proplist)
                    {
                        foreach (SvnPropertyValue propVal in node.Properties)
                        {
                            ListViewItem entry = new ListViewItem(node.Path);
                            entry.SubItems.Add(propVal.Key);
                            entry.SubItems.Add(propVal.StringValue);
                            lvProps.Items.Add(entry);
                        }

                    }
                    for (int i = 0; i < 3; i++) 
                        
                             lvProps.Columns[i].Width = -2;
                }
                catch(SvnException se)
                {
                    MessageBox.Show(se.Message + Environment.NewLine +
            "Error:" + se.SvnErrorCode,
            "svn proplist error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
                }
            }
        }

        private void lvProps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
