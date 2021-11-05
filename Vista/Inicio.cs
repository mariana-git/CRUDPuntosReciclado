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
        private UserControl userControlActivo = null; //variable para manipular en el metodo del ControlUser Activo en el panel
        public Inicio()
        {
            InitializeComponent();
        }
        #region EVENTOS

        private void Inicio_Load(object sender, EventArgs e)
        {
            panelBtnConsultar.Visible = false;
            panelPrincipal.Visible = false;
            StartPosition = FormStartPosition.CenterScreen;
            AcceptButton = btnConsultar;
        }
        #endregion

        #region BOTONES
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (panelBtnNuevo.Visible) panelBtnNuevo.Visible = false;
            if (panelBtnConsultar.Visible) panelBtnConsultar.Visible = false;
            else panelBtnConsultar.Visible = true;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (panelBtnConsultar.Visible) panelBtnConsultar.Visible = false;
            if (panelBtnNuevo.Visible) panelBtnNuevo.Visible = false;
            else panelBtnNuevo.Visible = true;

        }

        private void BtnCPersonaPunto_Click(object sender, EventArgs e)
        {
            panelBtnConsultar.Visible = false;
            panelPrincipal.Visible = true;
            AbrirUC(new ControlesDeUsuario.UcPuntoReciclado("PersonaPunto",txtBuscar.Text));
            txtBuscar.Text = "";
        }

        private void BtnCPersonas_Click(object sender, EventArgs e)
        {
            panelBtnConsultar.Visible = false;
            panelPrincipal.Visible = true;
            AbrirUC(new ControlesDeUsuario.UcPuntoReciclado("Personas",txtBuscar.Text));
            txtBuscar.Text = "";
        }

        private void BtnCPunto_Click(object sender, EventArgs e)
        {
            panelBtnConsultar.Visible = false;
            panelPrincipal.Visible = true;
            AbrirUC(new ControlesDeUsuario.UcPuntoReciclado("Puntos",txtBuscar.Text));
            txtBuscar.Text = "";
        }

        private void BtnNPersonaPunto_Click(object sender, EventArgs e)
        {
            panelBtnNuevo.Visible = false;
            panelPrincipal.Visible = true;
            AbrirUC(new ControlesDeUsuario.UcPuntoReciclado("PersonaPunto"));
        }

        private void BtnNPersona_Click(object sender, EventArgs e)
        {
            panelBtnNuevo.Visible = false;
            panelPrincipal.Visible = true;
            AbrirUC(new ControlesDeUsuario.UcPuntoReciclado("Personas"));
        }

        private void BtnNPunto_Click(object sender, EventArgs e)
        {
            panelBtnNuevo.Visible = false;
            panelPrincipal.Visible = true;
            AbrirUC(new ControlesDeUsuario.UcPuntoReciclado("Puntos"));
        }
        #endregion

        #region MÉTODOS

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
        #endregion
    }
}
