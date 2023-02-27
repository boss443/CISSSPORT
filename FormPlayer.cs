using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CisESport
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forminfo FormInfo =new Forminfo();
            FormInfo.ShowDialog();

            if(FormInfo.DialogResult== DialogResult.OK )
            {
               
            }
        }

        
    }
}
