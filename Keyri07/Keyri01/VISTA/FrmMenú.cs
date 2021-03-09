using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyri01.VISTA
{
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
        }
        public String usuarioEstado;
        private void FrmMenú_Load(object sender, EventArgs e)
        {
            label1.Text = usuarioEstado;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clickParaMásInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAcercade frm = new FrmAcercade();
            frm.MdiParent = this;
            frm.Show();
        }

        private void arreglosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisualUsuario visualUsuario = new FrmVisualUsuario();
            visualUsuario.MdiParent = this;
            visualUsuario.Show();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmop = new FrmOperaciones();
            frmop.MdiParent = this;
            frmop.btnResta.Enabled = false;

            frmop.Show();
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOperaciones frmop = new FrmOperaciones();
            frmop.MdiParent = this;
            frmop.btnSuma.Enabled = false;

            frmop.Show();
        }

        private void cRUDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.MdiParent = this;
            usuarios.Show();
        }
    }
}
