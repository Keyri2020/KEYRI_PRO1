using Keyri01.DAO;
using Keyri01.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Keyri01.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            Carga();
            clear();
        }

        void clear()
        {
            txtId.Clear();
            txtUserName.Clear();
            txtApellido.Clear();
            txtEdad.Clear();
            txtPass.Clear();

        }
        void Carga()
        {
            dtgListaUsuarios.Rows.Clear();
            ClsDUserList clsDUser = new ClsDUserList();
            List<UserList> Lista = clsDUser.cargarDatosUserList();

            foreach (var iteracion in Lista)
            {
                dtgListaUsuarios.Rows.Add(iteracion.Id, iteracion.NombreUsuario, iteracion.Apellido, iteracion.Edad, iteracion.Pass);
            }

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(""))
            {
                ClsDUserList dUserList = new ClsDUserList();
                //dUserList.SaveDatosUser(txtUserName.Text, txtApellido.Text, Convert.ToInt32(txtEdad.Text), txtPass.Text);
                UserList userList = new UserList();
                userList.NombreUsuario = txtUserName.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;
                dUserList.SaveDatosUser(userList);

            } else
            {
                ClsDUserList dUserList = new ClsDUserList();

                UserList userList = new UserList();
                userList.Id = Convert.ToInt32(txtId.Text);
                userList.NombreUsuario = txtUserName.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;
                dUserList.updateUser(userList);

            }

            Carga();
            clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ClsDUserList user = new ClsDUserList();
            user.deleteUser(Convert.ToInt32(txtId.Text));
            Carga();
            clear();

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
            Carga();
            clear();
        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String Id = dtgListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            String Nombre = dtgListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            String Apellido = dtgListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            String Edad = dtgListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            String Pass = dtgListaUsuarios.CurrentRow.Cells[4].Value.ToString();


            txtId.Text = Id;
            txtUserName.Text = Nombre;
            txtApellido.Text = Apellido;
            txtEdad.Text = Edad;
            txtPass.Text = Pass;
        }
    }
}