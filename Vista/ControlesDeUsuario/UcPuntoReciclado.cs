using Logica;
using System;
using System.Windows.Forms;

namespace Vista.ControlesDeUsuario
{
    public partial class UcPuntoReciclado : UserControl
    {
        string tabla;
        bool nuevo =false;
        #region CONSTRUCTORES
        public UcPuntoReciclado(string origen)
        {
            InitializeComponent();
            OpcionesDgv();
            tabla = origen;
            lblMensajeTop.Visible = true;
            lblMensajeTop.Text = "NUEVO REGISTRO";

            if (origen == "Personas")
            {
                gbPuntos.Visible = false;
                gbResponsabilidad.Visible = false;
                TextBoxEditables(gbPersonas);
                btnGuardarPersona.Visible = true;
            }
            if (origen == "Puntos")
            {
                gbPersonas.Visible = false;
                gbResponsabilidad.Visible = false;
                TextBoxEditables(gbPuntos);
                btnGuardarPunto.Visible = true;
            }
            if (origen == "PersonaPunto")
            {
                gbPersonas.Visible = true;
                gbResponsabilidad.Visible = true;
                gbPuntos.Visible = true;
                TextBoxEditables(gbResponsabilidad);
                TextBoxNoEditables(gbPersonas);
                TextBoxNoEditables(gbPuntos);
                btnGuardarResp.Visible = true;
                btnBuscarPersona.Visible = true;
                btnBuscarPunto.Visible = true;
                txtBuscarPersona.Visible = true;
                txtBuscarPunto.Visible = true;
            }
        }
        public UcPuntoReciclado(string origen,string parametro)
        {
            InitializeComponent();
            OpcionesDgv();
            lblMensajeTop.Text = "(Doble click para Seleccionar)";
            TextBoxNoEditables(gbPersonas);
            TextBoxNoEditables(gbPuntos);
            TextBoxNoEditables(gbResponsabilidad);     
            tabla = origen;
            dgvDatos.Visible = true;
            switch (tabla)
            {
                case "PersonaPunto":
                    try
                    {
                        CLBuscar cLBuscar = new CLBuscar
                        {
                            Palabra = parametro
                        };
                        dgvDatos.DataSource = cLBuscar.PersonaPunto();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("NO FUE POSIBLE REALIZAR LA ACCIÓN\n\n" + error.ToString(), "Vuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Personas":
                    try
                    {
                        CLBuscar cLBuscar = new CLBuscar
                        {
                            Palabra = parametro
                        };
                        dgvDatos.DataSource = cLBuscar.Persona();
                        gbPuntos.Visible = false;
                        gbResponsabilidad.Visible = false;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("NO FUE POSIBLE REALIZAR LA ACCIÓN\n\n" + error.ToString(), "Vuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Puntos":
                    try
                    {
                        CLBuscar cLBuscar = new CLBuscar
                        {
                            Palabra = parametro
                        };
                        dgvDatos.DataSource = cLBuscar.Punto();
                        gbResponsabilidad.Visible = false;
                        gbPersonas.Visible = false;
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("NO FUE POSIBLE REALIZAR LA ACCIÓN\n\n" + error.ToString(), "Vuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                default:
                    MessageBox.Show("NO FUE POSIBLE REALIZAR LA ACCIÓN\n\nVuelva a intentarlo","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            
        }
        #endregion

        #region BOTONES

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }       

        private void BtnModificarResp_Click(object sender, EventArgs e)
        {
            btnGuardarResp.Visible = true;
            btnModificarResp.Visible = false;
            TextBoxEditables(gbResponsabilidad);
        }

        private void BtnModificarPersona_Click(object sender, EventArgs e)
        {
            btnGuardarPersona.Visible = true;
            btnModificarPersona.Visible = false;
            TextBoxEditables(gbPersonas);
        }

        private void BtnModificarPunto_Click(object sender, EventArgs e)
        {
            btnGuardarPunto.Visible = true;
            btnModificarPunto.Visible = false;
            TextBoxEditables(gbPuntos);
        }

        private void BtnGuardarPunto_Click(object sender, EventArgs e)
        {
            if(TextBoxVacio(gbPuntos)) MessageBox.Show("Debe completar todos los campos");
            else
            {
                try
                {
                    CLModificar cLModificar = new CLModificar()
                    {
                        IDPunto = lblIDPunto.Text,
                        Denominacion = txtDenominacion.Text,
                        DiasYHorarios = txtDiasYHorarios.Text,
                        Espacio = txtEspacio.Text,
                        Direccion = txtDireccion.Text,
                    };
                    if (cLModificar.Puntos()) MessageBox.Show("Registro actualizado con éxito");
                    else
                    {
                        CLInsertar cLInsertar = new CLInsertar()
                        {
                            Denominacion = txtDenominacion.Text,
                            DiasYHorarios = txtDiasYHorarios.Text,
                            Espacio = txtEspacio.Text,
                            Direccion = txtDireccion.Text,
                        };
                        if (cLInsertar.Puntos()) MessageBox.Show("Registro creado con éxito");
                        else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                    }
                    Dispose();
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha podido modificar el registro.\n\n Verificque los datos ingresados e intente nuevamente");
                }        
            }
        }

        private void BtnGuardarPersona_Click(object sender, EventArgs e)
        {
            if (TextBoxVacio(gbPersonas)) MessageBox.Show("Debe completar todos los campos");
            else
            {
                try
                {
                    CLModificar cLModificar = new CLModificar()
                    {
                        IDPersona = lblIDPersona.Text,
                        Nombre = txtNombre.Text,
                        Apellido = txtApellido.Text,
                        DNI = txtDNI.Text,
                        Telefono = txtTelefono.Text
                    };
                    if (cLModificar.Personas()) MessageBox.Show("Registro actualizado con éxito");
                    else
                    {
                        CLInsertar cLInsertar = new CLInsertar()
                        {
                            Nombre = txtNombre.Text,
                            Apellido = txtApellido.Text,
                            DNI = txtDNI.Text,
                            Telefono = txtTelefono.Text
                        };
                        if (cLInsertar.Personas()) MessageBox.Show("Registro creado con éxito");                        
                        else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                    }
                    Dispose();
                    //TODO Mejorar: se puede mostrar en la grilla el registro modificado
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha podido modificar el registro.\n\n Verificque los datos ingresados e intente nuevamente");
                }
                
            }

        }

        private void BtnGuardarResp_Click(object sender, EventArgs e)
        {
            if (TextBoxVacio(gbPersonas)||TextBoxVacio(gbPuntos)|| TextBoxVacio(gbResponsabilidad)) MessageBox.Show("Debe completar todos los datos");
            else
            {
                try
                {
                    CLModificar cLModificar = new CLModificar()
                    {
                        IDPersona = lblIDPersona.Text,
                        IDPunto = lblIDPunto.Text,
                        Responsabilidad = txtResponsabilidad.Text
                    };
                    if (cLModificar.PersonaPunto()) MessageBox.Show("Registro actualizado con éxito");
                    else
                    {
                        CLInsertar cLInsertar = new CLInsertar()
                        {
                            IDPersona = lblIDPersona.Text,
                            IDPunto = lblIDPunto.Text,
                            Responsabilidad = txtResponsabilidad.Text
                        };
                        if (cLInsertar.Responsabilidades()) 
                        {
                            MessageBox.Show("Registro Agregado con éxito");
                            Dispose();
                        }
                        else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                    }
                    Dispose();
                    //TODO Mejorar: se puede mostrar en la grilla el registro modificado
                }
                catch (Exception)
                {
                    MessageBox.Show("No se ha podido modificar el registro.\n\n Verificque los datos ingresados e intente nuevamente");
                }
            }
        }

        private void BtnAtrasPunto_Click(object sender, EventArgs e)
        {
            LimpiarTextBox(gbPuntos);
            TextBoxNoEditables(gbPuntos);
            btnGuardarPunto.Visible = false;
            btnAtrasPunto.Visible = false;
            btnModificarPunto.Visible = false;
            lblIDPunto.Text = "";
        }

        private void BtnAtrasPersona_Click(object sender, EventArgs e)
        {
            LimpiarTextBox(gbPersonas);
            TextBoxNoEditables(gbPersonas);
            lblIDPersona.Text = "";
            btnAtrasPersona.Visible = false;
            btnGuardarPersona.Visible = false;
            btnModificarPersona.Visible = false;
        }

        private void BtnAtrasResp_Click(object sender, EventArgs e)
        {
            LimpiarTextBox(gbResponsabilidad);
            TextBoxNoEditables(gbResponsabilidad);
            LimpiarTextBox(gbPersonas);
            TextBoxNoEditables(gbPersonas);
            LimpiarTextBox(gbPuntos);
            TextBoxNoEditables(gbPuntos);
            lblIDPersona.Text = "";
            lblIDPunto.Text = "";
            btnAtrasResp.Visible = false;
            btnGuardarResp.Visible = false;
            btnModificarResp.Visible = false;
        }

        private void BtnBuscarPunto_Click(object sender, EventArgs e)
        {
            nuevo = true;
            tabla = "Puntos";
            //TODO buscar
            try
            {
                CLBuscar cLBuscar = new CLBuscar
                {
                    Palabra = txtBuscarPunto.Text
                };
                dgvDatos.Visible = true;
                lblMensajeTop.Text = "Doble click para Seleccionar";
                dgvDatos.DataSource = cLBuscar.Punto();
            }
            catch (Exception error)
            {
                MessageBox.Show("NO FUE POSIBLE REALIZAR LA ACCIÓN\n\n" + error.ToString(), "Vuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBuscarPersona_Click(object sender, EventArgs e)
        {

            tabla = "Personas";
            nuevo = true;
            //TODO buscar
            try
            {
                CLBuscar cLBuscar = new CLBuscar
                {
                    Palabra = txtBuscarPersona.Text
                };
                dgvDatos.Visible = true;
                lblMensajeTop.Text = "Doble click para Seleccionar";
                dgvDatos.DataSource = cLBuscar.Persona();
            }
            catch (Exception error)
            {
                MessageBox.Show("NO FUE POSIBLE REALIZAR LA ACCIÓN\n\n" + error.ToString(), "Vuelva a intentarlo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region EVENTOS
        private void UcPuntoReciclado_Load(object sender, EventArgs e)
        {
            //EstadoLoad();
        }
        private void DgvDatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnAtrasResp.PerformClick();
            PasarDgvATextBox(tabla);
            if (!nuevo)
            {
                if (tabla == "PersonaPunto")
                {
                    btnModificarResp.Visible = true;
                    btnAtrasResp.Visible = true;
                }
                if (tabla == "Personas")
                {
                    btnModificarPersona.Visible = true;
                    btnAtrasPersona.Visible = true; ;
                }
                if (tabla == "Puntos")
                {
                    btnModificarPunto.Visible = true;
                    btnAtrasPunto.Visible = true;
                }
            }
            
            
        }
        #endregion

        #region METODOS
        private void EstadoLoad()
        {
            this.btnCerrar.Focus();
            
            btnBuscarPersona.Visible = false;
            btnBuscarPunto.Visible = false;
            txtBuscarPersona.Visible = false;
            txtBuscarPunto.Visible = false;
            btnGuardarPersona.Visible = false;
            btnGuardarPunto.Visible = false;
            btnGuardarResp.Visible = false;
            btnModificarPersona.Visible = true;
            btnModificarPunto.Visible = true;
            btnModificarResp.Visible = true;
            btnEliminarPersona.Visible = true;
            btnEliminarPunto.Visible = true;
            btnEliminarResp.Visible = true;
            TextBoxNoEditables(gbPersonas);
            TextBoxNoEditables(gbPuntos);
            TextBoxNoEditables(gbResponsabilidad);
            LimpiarTextBox(gbPersonas);
            LimpiarTextBox(gbPuntos);
            LimpiarTextBox(gbResponsabilidad);
            lblIDPersona.Text = string.Empty;
            lblIDPunto.Text = string.Empty;

        }

        private void PasarDgvATextBox(string tipo)
        {
            if (tipo == "PersonaPunto")
            {
                lblIDPunto.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["idPunto"].Value.ToString();
                txtDenominacion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["denominacion"].Value.ToString();
                txtDiasYHorarios.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DiasYHorarios"].Value.ToString();
                txtEspacio.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["espacio"].Value.ToString();
                txtDireccion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["direccion"].Value.ToString();
                lblIDPersona.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["idPersona"].Value.ToString();
                txtNombre.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["apellido"].Value.ToString();
                txtDNI.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DNI"].Value.ToString();
                txtTelefono.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Telefono"].Value.ToString();
                txtResponsabilidad.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["responsabilidad"].Value.ToString();

            }
            if (tipo == "Personas")
            {
                lblIDPersona.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["idPersona"].Value.ToString();
                txtNombre.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["nombre"].Value.ToString();
                txtApellido.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["apellido"].Value.ToString();
                txtDNI.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DNI"].Value.ToString();
                txtTelefono.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["Telefono"].Value.ToString();
            }
            if (tipo == "Puntos")
            {
                lblIDPunto.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["idPunto"].Value.ToString();
                txtDenominacion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["denominacion"].Value.ToString();
                txtDiasYHorarios.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DiasYHorarios"].Value.ToString();
                txtEspacio.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["espacio"].Value.ToString();
                txtDireccion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["direccion"].Value.ToString();
            }
        }

        private void TextBoxNoEditables(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = control as TextBox;
                    t.ReadOnly = true;
                    t.BackColor = System.Drawing.Color.Pink;
                }
            }
        }

        private void TextBoxEditables(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = control as TextBox;
                    t.ReadOnly = false;
                    t.BackColor = System.Drawing.Color.White;
                }
            }
        }

        private void OpcionesDgv()
        {
            dgvDatos.Visible = true;
            dgvDatos.BringToFront();
            dgvDatos.RowHeadersVisible = false; // elimina la primera columna
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Selecciona toda la fila
            dgvDatos.ReadOnly = true; //hace que la grilla no se pueda editar
            dgvDatos.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LavenderBlush;//alterna colores de las filas
            dgvDatos.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;//alterna colores de las filas
            dgvDatos.AllowUserToAddRows = false; //desactiva la ultima fila 
            dgvDatos.MultiSelect = false; //desactiva la seleccion multiple
        }        

        private bool TextBoxVacio(GroupBox gb)
        {
            bool verificar = false;
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text == string.Empty)
                    {
                        verificar = true;
                    }
                }
            }
            return verificar;
        }

        private void LimpiarTextBox(GroupBox gb)
        {
            foreach (Control control in gb.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = control as TextBox;
                    t.Text = string.Empty;
                }
            }
        }

        #endregion
    }
}
