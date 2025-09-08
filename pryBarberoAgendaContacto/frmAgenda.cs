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
            
            txtContacto.Text = "";
            msbTelefono.Text = "";


            lstContactos.Items.Add("Contacto: " + vContacto + " - Telefono: " + vTelefono);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            msbTelefono.Text = "";
        }
    }
}
