
namespace Vista.ControlesDeUsuario
{
    partial class UcPuntoReciclado
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcPuntoReciclado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbPuntos = new System.Windows.Forms.GroupBox();
            this.flpPuntos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscarPunto = new System.Windows.Forms.Button();
            this.txtBuscarPunto = new System.Windows.Forms.TextBox();
            this.btnEliminarPunto = new System.Windows.Forms.Button();
            this.btnGuardarPunto = new System.Windows.Forms.Button();
            this.btnModificarPunto = new System.Windows.Forms.Button();
            this.btnAtrasPunto = new System.Windows.Forms.Button();
            this.lblIDPunto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEspacio = new System.Windows.Forms.TextBox();
            this.txtDiasYHorarios = new System.Windows.Forms.TextBox();
            this.txtDenominacion = new System.Windows.Forms.TextBox();
            this.gbPersonas = new System.Windows.Forms.GroupBox();
            this.lblIDPersona = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flpPersonas = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscarPersona = new System.Windows.Forms.Button();
            this.txtBuscarPersona = new System.Windows.Forms.TextBox();
            this.btnEliminarPersona = new System.Windows.Forms.Button();
            this.btnGuardarPersona = new System.Windows.Forms.Button();
            this.btnModificarPersona = new System.Windows.Forms.Button();
            this.btnAtrasPersona = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.gbResponsabilidad = new System.Windows.Forms.GroupBox();
            this.txtResponsabilidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flpResponsabilidad = new System.Windows.Forms.FlowLayoutPanel();
            this.btnEliminarResp = new System.Windows.Forms.Button();
            this.btnGuardarResp = new System.Windows.Forms.Button();
            this.btnModificarResp = new System.Windows.Forms.Button();
            this.btnAtrasResp = new System.Windows.Forms.Button();
            this.lblMensajeTop = new System.Windows.Forms.Label();
            this.flpContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.flpTablas = new System.Windows.Forms.FlowLayoutPanel();
            this.gbPuntos.SuspendLayout();
            this.flpPuntos.SuspendLayout();
            this.gbPersonas.SuspendLayout();
            this.flpPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.gbResponsabilidad.SuspendLayout();
            this.flpResponsabilidad.SuspendLayout();
            this.flpContenedor.SuspendLayout();
            this.flpTablas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(60)))), ((int)(((byte)(152)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnCerrar.Location = new System.Drawing.Point(0, 587);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(1009, 33);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Denominación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(16, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(16, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Espacio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Días Y Hs:";
            // 
            // gbPuntos
            // 
            this.gbPuntos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.gbPuntos.Controls.Add(this.flpPuntos);
            this.gbPuntos.Controls.Add(this.lblIDPunto);
            this.gbPuntos.Controls.Add(this.label10);
            this.gbPuntos.Controls.Add(this.txtDireccion);
            this.gbPuntos.Controls.Add(this.txtEspacio);
            this.gbPuntos.Controls.Add(this.txtDiasYHorarios);
            this.gbPuntos.Controls.Add(this.txtDenominacion);
            this.gbPuntos.Controls.Add(this.label7);
            this.gbPuntos.Controls.Add(this.label8);
            this.gbPuntos.Controls.Add(this.label2);
            this.gbPuntos.Controls.Add(this.label6);
            this.gbPuntos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPuntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbPuntos.ForeColor = System.Drawing.Color.Aqua;
            this.gbPuntos.Location = new System.Drawing.Point(3, 3);
            this.gbPuntos.Name = "gbPuntos";
            this.gbPuntos.Size = new System.Drawing.Size(331, 273);
            this.gbPuntos.TabIndex = 15;
            this.gbPuntos.TabStop = false;
            this.gbPuntos.Text = "Punto de Reciclado";
            // 
            // flpPuntos
            // 
            this.flpPuntos.Controls.Add(this.btnBuscarPunto);
            this.flpPuntos.Controls.Add(this.txtBuscarPunto);
            this.flpPuntos.Controls.Add(this.btnEliminarPunto);
            this.flpPuntos.Controls.Add(this.btnGuardarPunto);
            this.flpPuntos.Controls.Add(this.btnModificarPunto);
            this.flpPuntos.Controls.Add(this.btnAtrasPunto);
            this.flpPuntos.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPuntos.Location = new System.Drawing.Point(3, 22);
            this.flpPuntos.Name = "flpPuntos";
            this.flpPuntos.Size = new System.Drawing.Size(312, 29);
            this.flpPuntos.TabIndex = 27;
            // 
            // btnBuscarPunto
            // 
            this.btnBuscarPunto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPunto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPunto.BackgroundImage")));
            this.btnBuscarPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPunto.FlatAppearance.BorderSize = 0;
            this.btnBuscarPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnBuscarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPunto.ForeColor = System.Drawing.Color.Transparent;
            this.btnBuscarPunto.Location = new System.Drawing.Point(286, 3);
            this.btnBuscarPunto.Name = "btnBuscarPunto";
            this.btnBuscarPunto.Size = new System.Drawing.Size(23, 23);
            this.btnBuscarPunto.TabIndex = 27;
            this.btnBuscarPunto.UseVisualStyleBackColor = false;
            this.btnBuscarPunto.Visible = false;
            this.btnBuscarPunto.Click += new System.EventHandler(this.BtnBuscarPunto_Click);
            // 
            // txtBuscarPunto
            // 
            this.txtBuscarPunto.BackColor = System.Drawing.Color.Aquamarine;
            this.txtBuscarPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBuscarPunto.Location = new System.Drawing.Point(150, 3);
            this.txtBuscarPunto.Name = "txtBuscarPunto";
            this.txtBuscarPunto.Size = new System.Drawing.Size(130, 23);
            this.txtBuscarPunto.TabIndex = 19;
            this.txtBuscarPunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarPunto.Visible = false;
            // 
            // btnEliminarPunto
            // 
            this.btnEliminarPunto.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPunto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarPunto.BackgroundImage")));
            this.btnEliminarPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPunto.FlatAppearance.BorderSize = 0;
            this.btnEliminarPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnEliminarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPunto.ForeColor = System.Drawing.Color.Transparent;
            this.btnEliminarPunto.Location = new System.Drawing.Point(119, 3);
            this.btnEliminarPunto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminarPunto.Name = "btnEliminarPunto";
            this.btnEliminarPunto.Size = new System.Drawing.Size(23, 23);
            this.btnEliminarPunto.TabIndex = 29;
            this.btnEliminarPunto.UseVisualStyleBackColor = false;
            this.btnEliminarPunto.Visible = false;
            this.btnEliminarPunto.Click += new System.EventHandler(this.BtnEliminarPunto_Click);
            // 
            // btnGuardarPunto
            // 
            this.btnGuardarPunto.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPunto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarPunto.BackgroundImage")));
            this.btnGuardarPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPunto.FlatAppearance.BorderSize = 0;
            this.btnGuardarPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnGuardarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPunto.ForeColor = System.Drawing.Color.Transparent;
            this.btnGuardarPunto.Location = new System.Drawing.Point(86, 3);
            this.btnGuardarPunto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuardarPunto.Name = "btnGuardarPunto";
            this.btnGuardarPunto.Size = new System.Drawing.Size(23, 23);
            this.btnGuardarPunto.TabIndex = 31;
            this.btnGuardarPunto.UseVisualStyleBackColor = false;
            this.btnGuardarPunto.Visible = false;
            this.btnGuardarPunto.Click += new System.EventHandler(this.BtnGuardarPunto_Click);
            // 
            // btnModificarPunto
            // 
            this.btnModificarPunto.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarPunto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarPunto.BackgroundImage")));
            this.btnModificarPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPunto.FlatAppearance.BorderSize = 0;
            this.btnModificarPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnModificarPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPunto.ForeColor = System.Drawing.Color.Transparent;
            this.btnModificarPunto.Location = new System.Drawing.Point(53, 3);
            this.btnModificarPunto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnModificarPunto.Name = "btnModificarPunto";
            this.btnModificarPunto.Size = new System.Drawing.Size(23, 23);
            this.btnModificarPunto.TabIndex = 28;
            this.btnModificarPunto.UseVisualStyleBackColor = false;
            this.btnModificarPunto.Visible = false;
            this.btnModificarPunto.Click += new System.EventHandler(this.BtnModificarPunto_Click);
            // 
            // btnAtrasPunto
            // 
            this.btnAtrasPunto.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasPunto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtrasPunto.BackgroundImage")));
            this.btnAtrasPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasPunto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasPunto.FlatAppearance.BorderSize = 0;
            this.btnAtrasPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnAtrasPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasPunto.ForeColor = System.Drawing.Color.Transparent;
            this.btnAtrasPunto.Location = new System.Drawing.Point(20, 3);
            this.btnAtrasPunto.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAtrasPunto.Name = "btnAtrasPunto";
            this.btnAtrasPunto.Size = new System.Drawing.Size(23, 23);
            this.btnAtrasPunto.TabIndex = 32;
            this.btnAtrasPunto.UseVisualStyleBackColor = false;
            this.btnAtrasPunto.Visible = false;
            this.btnAtrasPunto.Click += new System.EventHandler(this.BtnAtrasPunto_Click);
            // 
            // lblIDPunto
            // 
            this.lblIDPunto.BackColor = System.Drawing.Color.Pink;
            this.lblIDPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIDPunto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblIDPunto.Location = new System.Drawing.Point(116, 69);
            this.lblIDPunto.Name = "lblIDPunto";
            this.lblIDPunto.Size = new System.Drawing.Size(201, 23);
            this.lblIDPunto.TabIndex = 26;
            this.lblIDPunto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 18);
            this.label10.TabIndex = 25;
            this.label10.Text = "Identificador:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(116, 232);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(201, 23);
            this.txtDireccion.TabIndex = 18;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEspacio
            // 
            this.txtEspacio.Location = new System.Drawing.Point(116, 189);
            this.txtEspacio.Name = "txtEspacio";
            this.txtEspacio.Size = new System.Drawing.Size(201, 23);
            this.txtEspacio.TabIndex = 17;
            this.txtEspacio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDiasYHorarios
            // 
            this.txtDiasYHorarios.Location = new System.Drawing.Point(116, 148);
            this.txtDiasYHorarios.Name = "txtDiasYHorarios";
            this.txtDiasYHorarios.Size = new System.Drawing.Size(201, 23);
            this.txtDiasYHorarios.TabIndex = 16;
            this.txtDiasYHorarios.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDenominacion
            // 
            this.txtDenominacion.Location = new System.Drawing.Point(116, 108);
            this.txtDenominacion.Name = "txtDenominacion";
            this.txtDenominacion.Size = new System.Drawing.Size(201, 23);
            this.txtDenominacion.TabIndex = 15;
            this.txtDenominacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbPersonas
            // 
            this.gbPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.gbPersonas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbPersonas.Controls.Add(this.lblIDPersona);
            this.gbPersonas.Controls.Add(this.label11);
            this.gbPersonas.Controls.Add(this.txtDNI);
            this.gbPersonas.Controls.Add(this.label5);
            this.gbPersonas.Controls.Add(this.flpPersonas);
            this.gbPersonas.Controls.Add(this.txtTelefono);
            this.gbPersonas.Controls.Add(this.label4);
            this.gbPersonas.Controls.Add(this.txtApellido);
            this.gbPersonas.Controls.Add(this.label3);
            this.gbPersonas.Controls.Add(this.txtNombre);
            this.gbPersonas.Controls.Add(this.label1);
            this.gbPersonas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbPersonas.ForeColor = System.Drawing.Color.Aqua;
            this.gbPersonas.Location = new System.Drawing.Point(340, 3);
            this.gbPersonas.Name = "gbPersonas";
            this.gbPersonas.Size = new System.Drawing.Size(329, 273);
            this.gbPersonas.TabIndex = 19;
            this.gbPersonas.TabStop = false;
            this.gbPersonas.Text = "Persona";
            // 
            // lblIDPersona
            // 
            this.lblIDPersona.BackColor = System.Drawing.Color.Pink;
            this.lblIDPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblIDPersona.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblIDPersona.Location = new System.Drawing.Point(114, 69);
            this.lblIDPersona.Name = "lblIDPersona";
            this.lblIDPersona.Size = new System.Drawing.Size(201, 23);
            this.lblIDPersona.TabIndex = 27;
            this.lblIDPersona.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(17, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 18);
            this.label11.TabIndex = 27;
            this.label11.Text = "Identificador:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(113, 189);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(201, 23);
            this.txtDNI.TabIndex = 19;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(17, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "DNI:";
            // 
            // flpPersonas
            // 
            this.flpPersonas.Controls.Add(this.btnBuscarPersona);
            this.flpPersonas.Controls.Add(this.txtBuscarPersona);
            this.flpPersonas.Controls.Add(this.btnEliminarPersona);
            this.flpPersonas.Controls.Add(this.btnGuardarPersona);
            this.flpPersonas.Controls.Add(this.btnModificarPersona);
            this.flpPersonas.Controls.Add(this.btnAtrasPersona);
            this.flpPersonas.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPersonas.Location = new System.Drawing.Point(5, 22);
            this.flpPersonas.Name = "flpPersonas";
            this.flpPersonas.Size = new System.Drawing.Size(312, 29);
            this.flpPersonas.TabIndex = 30;
            // 
            // btnBuscarPersona
            // 
            this.btnBuscarPersona.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarPersona.BackgroundImage")));
            this.btnBuscarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPersona.FlatAppearance.BorderSize = 0;
            this.btnBuscarPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnBuscarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPersona.ForeColor = System.Drawing.Color.Lime;
            this.btnBuscarPersona.Location = new System.Drawing.Point(286, 3);
            this.btnBuscarPersona.Name = "btnBuscarPersona";
            this.btnBuscarPersona.Size = new System.Drawing.Size(23, 23);
            this.btnBuscarPersona.TabIndex = 27;
            this.btnBuscarPersona.UseVisualStyleBackColor = false;
            this.btnBuscarPersona.Visible = false;
            this.btnBuscarPersona.Click += new System.EventHandler(this.BtnBuscarPersona_Click);
            // 
            // txtBuscarPersona
            // 
            this.txtBuscarPersona.BackColor = System.Drawing.Color.Aquamarine;
            this.txtBuscarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBuscarPersona.Location = new System.Drawing.Point(150, 3);
            this.txtBuscarPersona.Name = "txtBuscarPersona";
            this.txtBuscarPersona.Size = new System.Drawing.Size(130, 23);
            this.txtBuscarPersona.TabIndex = 26;
            this.txtBuscarPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarPersona.Visible = false;
            // 
            // btnEliminarPersona
            // 
            this.btnEliminarPersona.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarPersona.BackgroundImage")));
            this.btnEliminarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarPersona.FlatAppearance.BorderSize = 0;
            this.btnEliminarPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnEliminarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPersona.ForeColor = System.Drawing.Color.Lime;
            this.btnEliminarPersona.Location = new System.Drawing.Point(119, 3);
            this.btnEliminarPersona.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminarPersona.Name = "btnEliminarPersona";
            this.btnEliminarPersona.Size = new System.Drawing.Size(23, 23);
            this.btnEliminarPersona.TabIndex = 29;
            this.btnEliminarPersona.UseVisualStyleBackColor = false;
            this.btnEliminarPersona.Visible = false;
            this.btnEliminarPersona.Click += new System.EventHandler(this.BtnEliminarPersona_Click);
            // 
            // btnGuardarPersona
            // 
            this.btnGuardarPersona.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarPersona.BackgroundImage")));
            this.btnGuardarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarPersona.FlatAppearance.BorderSize = 0;
            this.btnGuardarPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnGuardarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarPersona.ForeColor = System.Drawing.Color.Lime;
            this.btnGuardarPersona.Location = new System.Drawing.Point(86, 3);
            this.btnGuardarPersona.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuardarPersona.Name = "btnGuardarPersona";
            this.btnGuardarPersona.Size = new System.Drawing.Size(23, 23);
            this.btnGuardarPersona.TabIndex = 30;
            this.btnGuardarPersona.UseVisualStyleBackColor = false;
            this.btnGuardarPersona.Visible = false;
            this.btnGuardarPersona.Click += new System.EventHandler(this.BtnGuardarPersona_Click);
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarPersona.BackgroundImage")));
            this.btnModificarPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarPersona.FlatAppearance.BorderSize = 0;
            this.btnModificarPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnModificarPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPersona.ForeColor = System.Drawing.Color.Lime;
            this.btnModificarPersona.Location = new System.Drawing.Point(53, 3);
            this.btnModificarPersona.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(23, 23);
            this.btnModificarPersona.TabIndex = 28;
            this.btnModificarPersona.UseVisualStyleBackColor = false;
            this.btnModificarPersona.Visible = false;
            this.btnModificarPersona.Click += new System.EventHandler(this.BtnModificarPersona_Click);
            // 
            // btnAtrasPersona
            // 
            this.btnAtrasPersona.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtrasPersona.BackgroundImage")));
            this.btnAtrasPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasPersona.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasPersona.FlatAppearance.BorderSize = 0;
            this.btnAtrasPersona.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnAtrasPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasPersona.ForeColor = System.Drawing.Color.Lime;
            this.btnAtrasPersona.Location = new System.Drawing.Point(20, 3);
            this.btnAtrasPersona.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAtrasPersona.Name = "btnAtrasPersona";
            this.btnAtrasPersona.Size = new System.Drawing.Size(23, 23);
            this.btnAtrasPersona.TabIndex = 33;
            this.btnAtrasPersona.UseVisualStyleBackColor = false;
            this.btnAtrasPersona.Visible = false;
            this.btnAtrasPersona.Click += new System.EventHandler(this.BtnAtrasPersona_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(113, 232);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(201, 23);
            this.txtTelefono.TabIndex = 17;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(113, 148);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(201, 23);
            this.txtApellido.TabIndex = 16;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(113, 108);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(201, 23);
            this.txtNombre.TabIndex = 15;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AllowUserToResizeColumns = false;
            this.dgvDatos.AllowUserToResizeRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(9)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDatos.GridColor = System.Drawing.Color.Purple;
            this.dgvDatos.Location = new System.Drawing.Point(3, 39);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatos.Size = new System.Drawing.Size(994, 247);
            this.dgvDatos.TabIndex = 20;
            this.dgvDatos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvDatos_CellMouseDoubleClick);
            // 
            // gbResponsabilidad
            // 
            this.gbResponsabilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.gbResponsabilidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbResponsabilidad.Controls.Add(this.txtResponsabilidad);
            this.gbResponsabilidad.Controls.Add(this.label9);
            this.gbResponsabilidad.Controls.Add(this.flpResponsabilidad);
            this.gbResponsabilidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbResponsabilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gbResponsabilidad.ForeColor = System.Drawing.Color.Aqua;
            this.gbResponsabilidad.Location = new System.Drawing.Point(675, 3);
            this.gbResponsabilidad.Name = "gbResponsabilidad";
            this.gbResponsabilidad.Size = new System.Drawing.Size(313, 273);
            this.gbResponsabilidad.TabIndex = 20;
            this.gbResponsabilidad.TabStop = false;
            this.gbResponsabilidad.Text = "Responsabilidad";
            // 
            // txtResponsabilidad
            // 
            this.txtResponsabilidad.Location = new System.Drawing.Point(50, 71);
            this.txtResponsabilidad.Name = "txtResponsabilidad";
            this.txtResponsabilidad.Size = new System.Drawing.Size(254, 23);
            this.txtResponsabilidad.TabIndex = 18;
            this.txtResponsabilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(9, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Rol:";
            // 
            // flpResponsabilidad
            // 
            this.flpResponsabilidad.Controls.Add(this.btnEliminarResp);
            this.flpResponsabilidad.Controls.Add(this.btnGuardarResp);
            this.flpResponsabilidad.Controls.Add(this.btnModificarResp);
            this.flpResponsabilidad.Controls.Add(this.btnAtrasResp);
            this.flpResponsabilidad.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpResponsabilidad.Location = new System.Drawing.Point(9, 24);
            this.flpResponsabilidad.Name = "flpResponsabilidad";
            this.flpResponsabilidad.Size = new System.Drawing.Size(300, 29);
            this.flpResponsabilidad.TabIndex = 31;
            // 
            // btnEliminarResp
            // 
            this.btnEliminarResp.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarResp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminarResp.BackgroundImage")));
            this.btnEliminarResp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEliminarResp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarResp.FlatAppearance.BorderSize = 0;
            this.btnEliminarResp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnEliminarResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarResp.ForeColor = System.Drawing.Color.Lime;
            this.btnEliminarResp.Location = new System.Drawing.Point(272, 3);
            this.btnEliminarResp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnEliminarResp.Name = "btnEliminarResp";
            this.btnEliminarResp.Size = new System.Drawing.Size(23, 23);
            this.btnEliminarResp.TabIndex = 29;
            this.btnEliminarResp.UseVisualStyleBackColor = false;
            this.btnEliminarResp.Visible = false;
            this.btnEliminarResp.Click += new System.EventHandler(this.BtnEliminarResp_Click);
            // 
            // btnGuardarResp
            // 
            this.btnGuardarResp.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarResp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarResp.BackgroundImage")));
            this.btnGuardarResp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardarResp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarResp.FlatAppearance.BorderSize = 0;
            this.btnGuardarResp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnGuardarResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarResp.ForeColor = System.Drawing.Color.Lime;
            this.btnGuardarResp.Location = new System.Drawing.Point(239, 3);
            this.btnGuardarResp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnGuardarResp.Name = "btnGuardarResp";
            this.btnGuardarResp.Size = new System.Drawing.Size(23, 23);
            this.btnGuardarResp.TabIndex = 31;
            this.btnGuardarResp.UseVisualStyleBackColor = false;
            this.btnGuardarResp.Visible = false;
            this.btnGuardarResp.Click += new System.EventHandler(this.BtnGuardarResp_Click);
            // 
            // btnModificarResp
            // 
            this.btnModificarResp.BackColor = System.Drawing.Color.Transparent;
            this.btnModificarResp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificarResp.BackgroundImage")));
            this.btnModificarResp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnModificarResp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarResp.FlatAppearance.BorderSize = 0;
            this.btnModificarResp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnModificarResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarResp.ForeColor = System.Drawing.Color.Lime;
            this.btnModificarResp.Location = new System.Drawing.Point(206, 3);
            this.btnModificarResp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnModificarResp.Name = "btnModificarResp";
            this.btnModificarResp.Size = new System.Drawing.Size(23, 23);
            this.btnModificarResp.TabIndex = 28;
            this.btnModificarResp.UseVisualStyleBackColor = false;
            this.btnModificarResp.Visible = false;
            this.btnModificarResp.Click += new System.EventHandler(this.BtnModificarResp_Click);
            // 
            // btnAtrasResp
            // 
            this.btnAtrasResp.BackColor = System.Drawing.Color.Transparent;
            this.btnAtrasResp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtrasResp.BackgroundImage")));
            this.btnAtrasResp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtrasResp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtrasResp.FlatAppearance.BorderSize = 0;
            this.btnAtrasResp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta;
            this.btnAtrasResp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtrasResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrasResp.ForeColor = System.Drawing.Color.Lime;
            this.btnAtrasResp.Location = new System.Drawing.Point(173, 3);
            this.btnAtrasResp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnAtrasResp.Name = "btnAtrasResp";
            this.btnAtrasResp.Size = new System.Drawing.Size(23, 23);
            this.btnAtrasResp.TabIndex = 34;
            this.btnAtrasResp.UseVisualStyleBackColor = false;
            this.btnAtrasResp.Visible = false;
            this.btnAtrasResp.Click += new System.EventHandler(this.BtnAtrasResp_Click);
            // 
            // lblMensajeTop
            // 
            this.lblMensajeTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.lblMensajeTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMensajeTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeTop.ForeColor = System.Drawing.Color.Magenta;
            this.lblMensajeTop.Location = new System.Drawing.Point(3, 0);
            this.lblMensajeTop.Name = "lblMensajeTop";
            this.lblMensajeTop.Size = new System.Drawing.Size(994, 36);
            this.lblMensajeTop.TabIndex = 25;
            this.lblMensajeTop.Text = "label";
            this.lblMensajeTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpContenedor
            // 
            this.flpContenedor.Controls.Add(this.lblMensajeTop);
            this.flpContenedor.Controls.Add(this.dgvDatos);
            this.flpContenedor.Controls.Add(this.flpTablas);
            this.flpContenedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpContenedor.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContenedor.Location = new System.Drawing.Point(0, 0);
            this.flpContenedor.Name = "flpContenedor";
            this.flpContenedor.Size = new System.Drawing.Size(1009, 581);
            this.flpContenedor.TabIndex = 26;
            // 
            // flpTablas
            // 
            this.flpTablas.Controls.Add(this.gbPuntos);
            this.flpTablas.Controls.Add(this.gbPersonas);
            this.flpTablas.Controls.Add(this.gbResponsabilidad);
            this.flpTablas.Location = new System.Drawing.Point(3, 292);
            this.flpTablas.Name = "flpTablas";
            this.flpTablas.Size = new System.Drawing.Size(994, 286);
            this.flpTablas.TabIndex = 28;
            // 
            // UcPuntoReciclado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(35)))), ((int)(((byte)(90)))));
            this.Controls.Add(this.flpContenedor);
            this.Controls.Add(this.btnCerrar);
            this.Name = "UcPuntoReciclado";
            this.Size = new System.Drawing.Size(1009, 620);
            this.gbPuntos.ResumeLayout(false);
            this.gbPuntos.PerformLayout();
            this.flpPuntos.ResumeLayout(false);
            this.flpPuntos.PerformLayout();
            this.gbPersonas.ResumeLayout(false);
            this.gbPersonas.PerformLayout();
            this.flpPersonas.ResumeLayout(false);
            this.flpPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.gbResponsabilidad.ResumeLayout(false);
            this.gbResponsabilidad.PerformLayout();
            this.flpResponsabilidad.ResumeLayout(false);
            this.flpContenedor.ResumeLayout(false);
            this.flpTablas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbPuntos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEspacio;
        private System.Windows.Forms.TextBox txtDiasYHorarios;
        private System.Windows.Forms.TextBox txtDenominacion;
        private System.Windows.Forms.GroupBox gbPersonas;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.GroupBox gbResponsabilidad;
        private System.Windows.Forms.TextBox txtResponsabilidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscarPunto;
        private System.Windows.Forms.TextBox txtBuscarPersona;
        private System.Windows.Forms.Label lblMensajeTop;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblIDPunto;
        private System.Windows.Forms.Label lblIDPersona;
        private System.Windows.Forms.FlowLayoutPanel flpPuntos;
        private System.Windows.Forms.Button btnBuscarPunto;
        private System.Windows.Forms.Button btnModificarPunto;
        private System.Windows.Forms.Button btnEliminarPunto;
        private System.Windows.Forms.FlowLayoutPanel flpPersonas;
        private System.Windows.Forms.Button btnBuscarPersona;
        private System.Windows.Forms.Button btnModificarPersona;
        private System.Windows.Forms.Button btnEliminarPersona;
        private System.Windows.Forms.FlowLayoutPanel flpResponsabilidad;
        private System.Windows.Forms.Button btnModificarResp;
        private System.Windows.Forms.Button btnEliminarResp;
        private System.Windows.Forms.Button btnGuardarPunto;
        private System.Windows.Forms.Button btnGuardarPersona;
        private System.Windows.Forms.Button btnGuardarResp;
        private System.Windows.Forms.FlowLayoutPanel flpContenedor;
        private System.Windows.Forms.Button btnAtrasPunto;
        private System.Windows.Forms.Button btnAtrasPersona;
        private System.Windows.Forms.Button btnAtrasResp;
        private System.Windows.Forms.FlowLayoutPanel flpTablas;
    }
}
