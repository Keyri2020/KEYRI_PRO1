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
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }

        private void FrmOperaciones_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {

                int suma;
                suma = Convert.ToInt32(txtDato1.Text) + Convert.ToInt32(txtDato2.Text);

                txtResultado.Text = suma.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ahh tus datos no son correctos, revisa");
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int resta;
            resta = Convert.ToInt32(txtDato1.Text) - Convert.ToInt32(txtDato2.Text);

            txtResultado.Text = resta.ToString();
        }
    }
}
