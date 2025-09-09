namespace pryBarberoAgendaContacto
{
    public partial class frmAgenda : Form
    {
        string vTelefono;
        string vContacto;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vTelefono = msbTelefono.Text;
            vContacto = txtContacto.Text;

            lstContactos.Items.Add("Contacto: " + vContacto + " - Telefono: " + vTelefono);

            txtContacto.Text = "";
            msbTelefono.Text = "";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            msbTelefono.Text = "";
        }

        private void msbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if(msbTelefono.MaskFull)
            {
                btnAgendar.Enabled = true;
            }
            else
            {
                btnAgendar.Enabled = false;
            }
        }
    }
}
