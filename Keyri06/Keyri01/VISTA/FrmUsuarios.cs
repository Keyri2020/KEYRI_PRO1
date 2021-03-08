using Keyri01.MODEL;
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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            Carga();
        }

        void Carga()
        {
            dataGridView1.Rows.Clear();

            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {
                    dataGridView1.Rows.Add(iteracion.Id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);
                }
            }
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                using (programacionEntities db = new programacionEntities())
                {
                    /// Agregar datos a un modelo de clases///

                    UserList userList = new UserList();

                    userList.NombreUsuario = txtUserName.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("Save");
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                using (programacionEntities db = new programacionEntities())
                {
                    int eliminar = Convert.ToInt32(txtId.Text);
                    UserList userList = db.UserList.Where(x => x.Id == eliminar).Select(x => x).FirstOrDefault();
                    
                    //userList = db.UserList.Find(eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                    MessageBox.Show("Eliminado");
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());
            }
            Carga();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {

                using (programacionEntities db = new programacionEntities())
                {
                    int update = Convert.ToInt32(txtId.Text);
                    UserList user = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                    //UserList userList = new UserList();
                    //userList = db.UserList.Find();

                    user.NombreUsuario = txtUserName.Text;
                    user.Apellido = txtApellido.Text;
                    user.Edad = Convert.ToInt32(txtEdad.Text);
                    user.Pass = txtEdad.Text;
                    db.SaveChanges();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            Carga();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}