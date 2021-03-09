using Keyri01.DAO;
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
    public partial class FrmVisualUsuario : Form
    {
        public FrmVisualUsuario()
        {
            InitializeComponent();
        }

        private void FrmVisualUsuario_Load(object sender, EventArgs e)
        {
            ClsListaUsuarios cls = new ClsListaUsuarios();

            foreach (var iteracion in cls.user) {
                dataGridView1.Rows.Add(iteracion.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
