namespace pryBarberoAgendaContacto
{
    public partial class frmAgenda : Form
    {
        string vTelefono;
        string vContacto;
        public string[] vecTelefono = new string[5];
        public string[] vecContacto = new string[5];

        public int indice = 0;
        public int indicemostrar = 0;

        int Contactos = 0;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {

            if (indice >= 5)
            {
                indice = 0;
            }

            vecTelefono[indice] = msbTelefono.Text;
            vecContacto[indice] = txtContacto.Text;

            Contactos += 1;
            indice++;

            lstContactos.Items.Add("Contacto: " + vecContacto[indice] + " - Telefono: " + vecTelefono[indice]);

            lblNumContact.Text = Contactos.ToString();
            txtContacto.Text = "";
            msbTelefono.Text = "";


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtContacto.Text = "";
            msbTelefono.Text = "";
            btnAgendar.Enabled = false;
        }

        private void msbTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (msbTelefono.Text == "")
            {
                btnAgendar.Enabled = false;
            }
            else
            {
                btnAgendar.Enabled = true;
            }
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            txtContacto.Focus();
        }

        private void bntVerContactos_Click(object sender, EventArgs e)
        {
            frmVerContactos verContactos = new frmVerContactos(vecContacto, vecTelefono);
            verContactos.Show();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstContactos.Items.Clear();
            Contactos = 0;
            lstContactos.Text = "0";
        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text == "")
            {
                btnAgendar.Enabled = false;
            }
            else
            {
                btnAgendar.Enabled = true;
            }
        }

        private void lblNumContact_Click(object sender, EventArgs e)
        {

        }
    }
}
