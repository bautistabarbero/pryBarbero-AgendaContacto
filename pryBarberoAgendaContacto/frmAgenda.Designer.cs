namespace pryBarberoAgendaContacto
{
    partial class frmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            lblContacto = new Label();
            lblTelefono = new Label();
            txtContacto = new TextBox();
            lstContactos = new ListBox();
            btnCancelar = new Button();
            btnAgendar = new Button();
            lblTitulo = new Label();
            msbTelefono = new MaskedTextBox();
            bntVerContactos = new Button();
            btnLimpiar = new Button();
            lblCantidad = new Label();
            lblNumContact = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(50, 68);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(59, 15);
            lblContacto.TabIndex = 4;
            lblContacto.Text = "Contacto:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(50, 114);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Telefono:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(115, 65);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(199, 23);
            txtContacto.TabIndex = 0;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lstContactos
            // 
            lstContactos.BackColor = SystemColors.ScrollBar;
            lstContactos.FormattingEnabled = true;
            lstContactos.ItemHeight = 15;
            lstContactos.Location = new Point(79, 207);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(235, 169);
            lstContactos.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(171, 153);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 32);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Enabled = false;
            btnAgendar.Location = new Point(291, 153);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(114, 32);
            btnAgendar.TabIndex = 2;
            btnAgendar.Text = "Agendar";
            btnAgendar.UseVisualStyleBackColor = true;
            btnAgendar.Click += btnAgendar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(193, 21);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "AGENDA DE CONTACTOS:";
            // 
            // msbTelefono
            // 
            msbTelefono.Location = new Point(115, 111);
            msbTelefono.Mask = "(99)0000-000000";
            msbTelefono.Name = "msbTelefono";
            msbTelefono.Size = new Size(199, 23);
            msbTelefono.TabIndex = 1;
            msbTelefono.MaskInputRejected += msbTelefono_MaskInputRejected;
            // 
            // bntVerContactos
            // 
            bntVerContactos.Enabled = false;
            bntVerContactos.Location = new Point(250, 420);
            bntVerContactos.Name = "bntVerContactos";
            bntVerContactos.Size = new Size(131, 49);
            bntVerContactos.TabIndex = 8;
            bntVerContactos.Text = "Ver Contactos ";
            bntVerContactos.UseVisualStyleBackColor = true;
            bntVerContactos.Click += bntVerContactos_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Enabled = false;
            btnLimpiar.Location = new Point(50, 437);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 32);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(33, 407);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(129, 15);
            lblCantidad.TabIndex = 10;
            lblCantidad.Text = "Cantidad de contactos:";
            // 
            // lblNumContact
            // 
            lblNumContact.Location = new Point(168, 395);
            lblNumContact.Name = "lblNumContact";
            lblNumContact.Size = new Size(32, 27);
            lblNumContact.TabIndex = 11;
            lblNumContact.Click += lblNumContact_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 481);
            Controls.Add(lblNumContact);
            Controls.Add(lblCantidad);
            Controls.Add(btnLimpiar);
            Controls.Add(bntVerContactos);
            Controls.Add(msbTelefono);
            Controls.Add(lblTitulo);
            Controls.Add(btnAgendar);
            Controls.Add(btnCancelar);
            Controls.Add(lstContactos);
            Controls.Add(txtContacto);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAgenda";
            Text = "Form1";
            Load += frmAgenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblTelefono;
        private TextBox txtContacto;
        private ListBox lstContactos;
        private Button btnCancelar;
        private Button btnAgendar;
        private Label lblTitulo;
        private MaskedTextBox msbTelefono;
        private Button button1;
        private Button button2;
        private Button bntVerContactos;
        private Button btnLimpiar;
        private Label lblCantidad;
        private Label lblNumContact;
    }
}
