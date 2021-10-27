using Logica;
using System;
using System.Windows.Forms;

namespace Vista.ControlesDeUsuario
{
    public partial class UcPuntoReciclado : UserControl
    {
        private int xClick = 0, yClick = 0;//variables para mover el form  al no tener bordes
        public UcPuntoReciclado()
        {
            InitializeComponent();
            dgvDatos.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnGuardarNuevo.Visible = true;
        }
        public UcPuntoReciclado(string parametro)
        {
            InitializeComponent();
            dgvDatos.Visible = true;
            dgvDatos.BringToFront();
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnGuardarNuevo.Visible = false;
            DiseñoDgv(); 
            try
            {
                CLBuscar cLBuscar = new CLBuscar
                {
                    Parametro = parametro
                };
                dgvDatos.DataSource = cLBuscar.Buscar();
            }
            catch (Exception error)
            {
                MessageBox.Show("NO FUE POSIBLE REALIZAR LA ACCIÓN\n\n" + error.ToString(), "Vuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        private void DiseñoDgv()
        {
            dgvDatos.RowHeadersVisible = false; // elimina la primera columna
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgvDatos.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvDatos.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LavenderBlush;//alterna colores de las filas
            dgvDatos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;//alterna colores de las filas
            dgvDatos.AllowUserToAddRows = false; //desactiva la ultima fila 
            dgvDatos.MultiSelect = false; //desactiva la seleccion multiple
        }

        private void DgvDatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CargarDatosDgv();
            TxtNoEditables();
            dgvDatos.Visible = false;            
        }
        private void CargarDatosDgv()
        {
            txtDenominacion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["denominacion"].Value.ToString();
            txtDiasYHorarios.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DiasYHorarios"].Value.ToString();
            txtEspacio.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["espacio"].Value.ToString();
            txtDireccion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["direccion"].Value.ToString();
            txtNombre.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["nombre"].Value.ToString();
            txtApellido.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["apellido"].Value.ToString();
            txtTelefono.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Telefono"].Value.ToString();
            txtResponsabilidad.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["responsabilidad"].Value.ToString();
        }
        private void TxtNoEditables()
        {
            txtApellido.ReadOnly = true;
            txtDenominacion.ReadOnly = true;
            txtDiasYHorarios.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtEspacio.ReadOnly = true;
            txtNombre.ReadOnly = true;
            txtResponsabilidad.ReadOnly = true;
            txtTelefono.ReadOnly = true;
        }
        private void TxtEditables()
        {
            txtApellido.ReadOnly = false;
            txtDenominacion.ReadOnly = false;
            txtDiasYHorarios.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtEspacio.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtResponsabilidad.ReadOnly = false;
            txtTelefono.ReadOnly = false;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnModificar.Text = "Guardar";
                btnEliminar.Text = "Cancelar";
                TxtEditables();
            }
            else
            {
                btnModificar.Text = "Guardar";
                //TODO modificar registro
                MessageBox.Show("Registro actualizado con éxito");
                btnModificar.Text = "Modificar";
                btnEliminar.Text = "Eliminar";
                btnEliminar.Enabled = true;
                TxtNoEditables();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if(btnEliminar.Text == "Cancelar")
            {
                btnEliminar.Text = "Eliminar";
                btnModificar.Text = "Modificar";
                TxtNoEditables();
                Dispose();
            }
            else
            {
                DialogResult resultado = MessageBox.Show("El registro se eliminará de forma permanente", "ATENCIÓN", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (resultado == DialogResult.OK)
                {
                    MessageBox.Show("Registro eliminado con éxito");
                    //TODO eliminar registro
                    Dispose();
                }
            }            
        }

        private void BtnGuardarNuevo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registro Agregado con éxito");
            //TODO insertar registro
            Dispose();
        }

        private void UcPuntoReciclado_MouseMove(object sender, MouseEventArgs e)
        {
            //evento MouseMove del Form, para poder desplazar el Form sin Bordes
            {
                if (e.Button != MouseButtons.Left)
                { xClick = e.X; yClick = e.Y; }
                else
                { Left += e.X - xClick; Top += e.Y - yClick; }
            }
        }

        private void DgvDatos_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
