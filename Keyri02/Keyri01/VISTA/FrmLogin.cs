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

namespace Keyri01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Login log = new Login();

            log.Usuario = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin cls = new ClsLogin();

            int variabledeevaluacion = cls.acceso(log);

            if (variabledeevaluacion ==1) {

                MessageBox.Show("WELCOME");
                FrmMenú frm = new FrmMenú();
                frm.Show();
                this.Hide();
            }
            else{
                MessageBox.Show("False");
            }
        }
    }
}
