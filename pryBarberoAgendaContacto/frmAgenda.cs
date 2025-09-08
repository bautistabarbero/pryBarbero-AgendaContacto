namespace pryBarberoAgendaContacto
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            frmAgenda frmAgenda = new frmAgenda();
            frmAgenda.ShowDialog();

            txtContacto.Text = "";
            msbTelefono.Text = "";

            lstContactos.Items.Add(txtContacto.Text + " - " + msbTelefono.Text);
        }
    }
}
