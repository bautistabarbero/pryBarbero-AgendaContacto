namespace pryBarberoAgendaContacto
{
    public partial class frmAgenda : Form
    {
        string vTelefono;
        string vContacto;
        string[] vecTelefono = new string[5];
        string[] vecContacto = new string[5];
        int indice = 0;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            vecTelefono[indice] = msbTelefono.Text;
            vecContacto[indice] = txtContacto.Text;

            lstContactos.Items.Add("Contacto: " + vecContacto[indice] + " - Telefono: " + vecTelefono[indice]);

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
            if(msbTelefono.Text=="")
            {
                btnAgendar.Enabled = false;
            }
            else
            {
                btnAgendar.Enabled = true;
            }
        }
    }
}
