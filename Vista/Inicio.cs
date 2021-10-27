using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Logica
    ;
using System.Windows.Forms;

namespace Vista
{
    public partial class Inicio : Form
    {
        private int xClick = 0, yClick = 0;//variables para mover el form  al no tener bordes
        private UserControl userControlActivo = null; //variable para manipular en el metodo del ControlUser Activo en el panel
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            panelPrincipal.Visible = true;
            AbrirUC(new ControlesDeUsuario.UcPuntoReciclado(txtBuscar.Text));
            txtBuscar.Text = "";
        }
        private void AbrirUC(UserControl UControlActivo)
        {
            //Controla que solo haya un UserControl abierto dentro del Panel
            if (userControlActivo != null) userControlActivo.Dispose();
            userControlActivo = UControlActivo;
            panelPrincipal.Controls.Add(UControlActivo);
            panelPrincipal.Tag = UControlActivo;
            UControlActivo.BringToFront();
            UControlActivo.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {

            panelPrincipal.Visible = true;
            AbrirUC(new ControlesDeUsuario.UcPuntoReciclado());
        }

        private void Inicio_MouseMove(object sender, MouseEventArgs e)
        {
            //evento MouseMove del Form, para poder desplazar el Form sin Bordes
            {
                if (e.Button != MouseButtons.Left)
                { xClick = e.X; yClick = e.Y; }
                else
                { Left += e.X - xClick; Top += e.Y - yClick; }
            }
        }

        private void PanelPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            //evento MouseMove del Form, para poder desplazar el Form sin Bordes
            {
                if (e.Button != MouseButtons.Left)
                { xClick = e.X; yClick = e.Y; }
                else
                { Left += e.X - xClick; Top += e.Y - yClick; }
            }
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

            panelPrincipal.Visible = false;
            StartPosition = FormStartPosition.CenterScreen;
            AcceptButton = btnConsultar;
        }
    }
    
}
