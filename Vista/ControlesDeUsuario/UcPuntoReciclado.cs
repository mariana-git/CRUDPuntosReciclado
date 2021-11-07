using Logica;
using System;
using System.Windows.Forms;

namespace Vista.ControlesDeUsuario
{
    public partial class UcPuntoReciclado : UserControl
    {
        string tabla;
        bool nuevo = false;
        readonly string fallo = "No se ha podido realizar la operación.\n\n";
        readonly string exito = "Operación realizada con éxito.\n\n";

        #region CONSTRUCTORES
        public UcPuntoReciclado(string origen)
        {
            //CONSTRUCTOR PARA CREAR NUEVOS
            nuevo = true;
            InitializeComponent();
            OpcionesDgv();
            tabla = origen;
            lblMensajeTop.Visible = true;
            lblMensajeTop.Text = "NUEVO REGISTRO";
            LimpiarGB();

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
            if (origen == "Responsabilidades")
            {
                gbPersonas.Visible = true;
                gbResponsabilidad.Visible = true;
                gbPuntos.Visible = true;
                TextBoxEditables(gbResponsabilidad);
                btnGuardarResp.Visible = true;
                btnBuscarPersona.Visible = true;
                btnBuscarPunto.Visible = true;
                txtBuscarPersona.Visible = true;
                txtBuscarPunto.Visible = true;
            }
        }
        public UcPuntoReciclado(string origen,string parametro)
        {
            //CONSTRUCTOR DE BUSQUEDA
            InitializeComponent();
            OpcionesDgv();
            LimpiarGB();

            lblMensajeTop.Visible = true;
            lblMensajeTop.Text = "(Doble click para Seleccionar)"; 
            tabla = origen;
            dgvDatos.Visible = true;

            switch (tabla)
            {
                case "Responsabilidades":
                    try
                    {
                        CLBuscar cLBuscar = new CLBuscar
                        {
                            Palabra = parametro
                        };
                        dgvDatos.DataSource = cLBuscar.Responsabilidades();

                        dgvDatos.Columns["idPunto"].Visible = false;
                        dgvDatos.Columns["idPersona"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(fallo + ex.ToString());
                    }
                    break;
                case "Personas":
                    try
                    {
                        CLBuscar cLBuscar = new CLBuscar
                        {
                            Palabra = parametro
                        };
                        dgvDatos.DataSource = cLBuscar.Personas();
                        gbPuntos.Visible = false;
                        gbResponsabilidad.Visible = false;
                        dgvDatos.Columns["idPersona"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(fallo + ex.ToString());
                    }
                    break;
                case "Puntos":
                    try
                    {
                        CLBuscar cLBuscar = new CLBuscar
                        {
                            Palabra = parametro
                        };
                        dgvDatos.DataSource = cLBuscar.Puntos();
                        gbResponsabilidad.Visible = false;
                        gbPersonas.Visible = false;
                        dgvDatos.Columns["idPunto"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(fallo + ex.ToString());
                    }
                    break;

                default:
                    MessageBox.Show(fallo);
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
            btnEliminarResp.Visible = false;
            TextBoxEditables(gbResponsabilidad);
        }

        private void BtnModificarPersona_Click(object sender, EventArgs e)
        {
            btnGuardarPersona.Visible = true;
            btnModificarPersona.Visible = false;
            btnEliminarPersona.Visible = false;
            TextBoxEditables(gbPersonas);
        }

        private void BtnModificarPunto_Click(object sender, EventArgs e)
        {
            btnGuardarPunto.Visible = true;
            btnModificarPunto.Visible = false;
            btnEliminarPunto.Visible = false;
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
                    if (cLModificar.Puntos())
                    {
                        MessageBox.Show(exito);
                        dgvDatos.DataSource = new CLBuscar().Puntos();
                        LimpiarGB();
                    }
                    else
                    {
                        CLInsertar cLInsertar = new CLInsertar()
                        {
                            Denominacion = txtDenominacion.Text,
                            DiasYHorarios = txtDiasYHorarios.Text,
                            Espacio = txtEspacio.Text,
                            Direccion = txtDireccion.Text,
                        };
                        if (cLInsertar.Puntos())
                        {
                            MessageBox.Show(exito);
                            dgvDatos.DataSource = new CLBuscar().Puntos();
                            LimpiarGB();
                        }
                        else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(fallo + ex.ToString());
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
                    if (cLModificar.Personas())
                    {
                        MessageBox.Show(exito);
                        dgvDatos.DataSource = new CLBuscar().Personas();
                        LimpiarGB();
                    }
                    else
                    {
                        CLInsertar cLInsertar = new CLInsertar()
                        {
                            Nombre = txtNombre.Text,
                            Apellido = txtApellido.Text,
                            DNI = txtDNI.Text,
                            Telefono = txtTelefono.Text
                        };
                        if (cLInsertar.Personas())
                        {
                            MessageBox.Show(exito);
                            dgvDatos.DataSource = new CLBuscar().Personas();
                            LimpiarGB();
                        }
                        else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                    }
                    //TODO Mejorar: se puede mostrar en la grilla el registro modificado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(fallo + ex.ToString());
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
                    if (cLModificar.Responsabilidades())
                    {
                        MessageBox.Show(exito);
                        dgvDatos.DataSource = new CLBuscar().Responsabilidades();
                        LimpiarGB();
                    }
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
                            MessageBox.Show(exito);
                            dgvDatos.DataSource = new CLBuscar().Responsabilidades();
                            LimpiarGB();
                        }
                        else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                    }
                    //TODO Mejorar: se puede mostrar en la grilla el registro modificado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(fallo + ex.ToString());
                }
            }
        }

        private void BtnAtrasPunto_Click(object sender, EventArgs e)
        {
            LimpiarGB();
        }

        private void BtnAtrasPersona_Click(object sender, EventArgs e)
        {
            LimpiarGB();
        }

        private void BtnAtrasResp_Click(object sender, EventArgs e)
        {
            LimpiarGB();
        }

        private void BtnBuscarPunto_Click(object sender, EventArgs e)
        {
            tabla = "Puntos";
            try
            {
                CLBuscar cLBuscar = new CLBuscar
                {
                    Palabra = txtBuscarPunto.Text
                };
                dgvDatos.Visible = true;
                lblMensajeTop.Text = "Doble click para Seleccionar";
                dgvDatos.DataSource = cLBuscar.Puntos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(fallo + ex.ToString());
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
                dgvDatos.DataSource = cLBuscar.Personas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(fallo + ex);
            }
        }

        private void BtnEliminarPunto_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Se eliminará el registro de forma permanente", "ATENCION", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if( resultado == DialogResult.OK)
            {
                try
                {
                    CLEliminar cLEliminar = new CLEliminar
                    {
                        IDPunto = lblIDPunto.Text
                    };
                    //dgvDatos.Visible = true;
                    if (cLEliminar.Puntos())
                    {
                        MessageBox.Show(exito);
                        dgvDatos.DataSource = new CLBuscar().Puntos();
                        LimpiarGB();
                    }
                    else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(fallo + ex.ToString());
                }
            }
            
        }

        private void BtnEliminarPersona_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Se eliminará el registro de forma permanente", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                try
                {
                    CLEliminar cLEliminar = new CLEliminar
                    {
                        IDPersona = lblIDPersona.Text
                    };
                    // dgvDatos.Visible = true;
                    if (cLEliminar.Personas())
                    {
                        MessageBox.Show(exito);
                        dgvDatos.DataSource = new CLBuscar().Personas();
                        LimpiarGB();
                    }
                    else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(fallo + ex.ToString());
                }
            }
        }

        private void BtnEliminarResp_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Se eliminará el registro de forma permanente", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resultado == DialogResult.OK)
            {
                try
                {
                    CLEliminar cLEliminar = new CLEliminar
                    {
                        IDPunto = lblIDPunto.Text,
                        IDPersona = lblIDPersona.Text
                    };
                    //dgvDatos.Visible = true;
                    if (cLEliminar.Responsabilidades())
                    {
                        MessageBox.Show(exito);
                        dgvDatos.DataSource = new CLBuscar().Responsabilidades();
                        LimpiarGB();
                    }
                    else MessageBox.Show("Verifique los datos ingresados e inténtelo nuevamente", "ALGO FALLÓ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(fallo + ex.ToString());
                }
            }
        }

        #endregion

        #region EVENTOS
        private void DgvDatos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if(!nuevo) LimpiarGB();
                PasarDgvATextBox(tabla);
                if (!nuevo)
                {
                    if (tabla == "Responsabilidades")
                    {
                        btnModificarResp.Visible = true;
                        btnAtrasResp.Visible = true;
                        btnEliminarResp.Visible = true;
                    }
                    if (tabla == "Personas")
                    {
                        btnModificarPersona.Visible = true;
                        btnAtrasPersona.Visible = true;
                        btnEliminarPersona.Visible = true;
                    }
                    if (tabla == "Puntos")
                    {
                        btnModificarPunto.Visible = true;
                        btnAtrasPunto.Visible = true;
                        btnEliminarPunto.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(fallo + ex);
            }
            
        }
        #endregion

        #region METODOS

        private void PasarDgvATextBox(string tipo)
        {
            if (tipo == "Responsabilidades")
            {
                lblIDPunto.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["idPunto"].Value.ToString();
                txtDenominacion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DENOMINACION"].Value.ToString();
                txtDiasYHorarios.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DIASYHORARIOS"].Value.ToString();
                txtEspacio.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["ESPACIO"].Value.ToString();
                txtDireccion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DIRECCION"].Value.ToString();
                lblIDPersona.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["idPersona"].Value.ToString();
                txtNombre.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["NOMBRE"].Value.ToString();
                txtApellido.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["APELLIDO"].Value.ToString();
                txtDNI.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DNI"].Value.ToString();
                txtTelefono.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["TELEFONO"].Value.ToString();
                txtResponsabilidad.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["RESPONSABILIDAD"].Value.ToString();

            }
            if (tipo == "Personas")
            {
                lblIDPersona.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["idPersona"].Value.ToString();
                txtNombre.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["NOMBRE"].Value.ToString();
                txtApellido.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["APELLIDO"].Value.ToString();
                txtDNI.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DNI"].Value.ToString();
                txtTelefono.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["TELEFONO"].Value.ToString();
            }
            if (tipo == "Puntos")
            {
                lblIDPunto.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["idPunto"].Value.ToString();
                txtDenominacion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DENOMINACION"].Value.ToString();
                txtDiasYHorarios.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DIASYHORARIOS"].Value.ToString();
                txtEspacio.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["ESPACIO"].Value.ToString();
                txtDireccion.Text = dgvDatos.Rows[dgvDatos.SelectedRows[0].Index].Cells["DIRECCION"].Value.ToString();
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
            dgvDatos.RowHeadersVisible = false; // no muestra la primera columna
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

        private void LimpiarGB()
        {          
            foreach (GroupBox gb in flpTablas.Controls)
            {
                foreach (Control control in gb.Controls)
                {
                    if (control is TextBox)
                    {
                        TextBox t = control as TextBox;
                        t.Text = string.Empty;
                        t.ReadOnly = true;
                        t.BackColor = System.Drawing.Color.Pink;
                    }
                    if (control is Label)
                    {
                        Label l = control as Label;
                        if (l.BackColor == System.Drawing.Color.Pink) l.Text = string.Empty;
                    }
                    if (control is FlowLayoutPanel)
                    {
                        FlowLayoutPanel f = control as FlowLayoutPanel;
                        foreach (Control control2 in f.Controls)
                        {
                            if (control2 is Button)
                            {
                                Button b = control2 as Button;
                                b.Visible = false;
                            }
                        }
                    }
                }
            }
        }

        #endregion
    }
}
