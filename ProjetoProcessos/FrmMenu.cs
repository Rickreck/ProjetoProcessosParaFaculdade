using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoProcessos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void ProcessMenu_Click(object sender, EventArgs e)
        {
            FormProcess frm=new FormProcess();
            frm.ShowDialog();
        }

        private void userMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
