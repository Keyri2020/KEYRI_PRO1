using Keyri01.DOMINIO;
using Keyri01.NEGOCIO;
using Keyri01.VISTA;
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin cls = new ClsLogin();

            int variabledeevaluacion = cls.acceso(log);

            if (variabledeevaluacion == 1)
            {
                MessageBox.Show("WELCOME");
                FrmMenú frm = new FrmMenú();
                frm.usuarioEstado = txtUser.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
