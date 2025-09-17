using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryBarberoAgendaContacto
{
    public partial class frmVerContactos : Form
    {
        int indice = 0;
        int indicemostrar = 0;
        private string[] vContactos;
        private string[] vTelefonos;
        public string[] pasardatos;

        public frmVerContactos(string[] contactos, string[] telefonos)
        {
            InitializeComponent();
            this.vContactos = contactos;
            this.vTelefonos = telefonos;

        }

        private void frmVerContactos_Load(object sender, EventArgs e)
        {
            lblNombreContacto.Text = vContactos[0];
            lblTelefonoContacto.Text = vTelefonos[0];
            indice++;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                lblNombreContacto.Text = vContactos[indicemostrar];
                lblTelefonoContacto.Text = vTelefonos[indicemostrar];
            }
            else
            {
                indicemostrar = vContactos.Length - 1;
                while (vContactos[indicemostrar] == null)
                {
                    indicemostrar--;
                }

                lblNombreContacto.Text = vContactos[indicemostrar];
                lblTelefonoContacto.Text = vTelefonos[indicemostrar];
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indicemostrar < vContactos.Length - 1)
            {
                indicemostrar++;
                lblNombreContacto.Text = vContactos[indicemostrar];
                lblTelefonoContacto.Text = vTelefonos[indicemostrar];
            }
            else
            {
                indicemostrar = 0;
                lblNombreContacto.Text = vContactos[indicemostrar];
                lblTelefonoContacto.Text = vTelefonos[indicemostrar];
            }
        }
    }
}
