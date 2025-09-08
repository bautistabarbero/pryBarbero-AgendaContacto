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
            lblContacto = new Label();
            lblTelefono = new Label();
            txtContacto = new TextBox();
            lstContactos = new ListBox();
            btnCancelar = new Button();
            btnAgendar = new Button();
            lblTitulo = new Label();
            msbTelefono = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(50, 87);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(59, 15);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(50, 141);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(55, 15);
            lblTelefono.TabIndex = 1;
            lblTelefono.Text = "Telefono:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(115, 87);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(199, 23);
            txtContacto.TabIndex = 2;
            // 
            // lstContactos
            // 
            lstContactos.FormattingEnabled = true;
            lstContactos.ItemHeight = 15;
            lstContactos.Location = new Point(50, 281);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(308, 169);
            lstContactos.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(63, 206);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 32);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += this.btnCancelar_Click;
            // 
            // btnAgendar
            // 
            btnAgendar.Location = new Point(231, 206);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(114, 32);
            btnAgendar.TabIndex = 6;
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
            msbTelefono.Location = new Point(115, 133);
            msbTelefono.Mask = "(999)000-0000";
            msbTelefono.Name = "msbTelefono";
            msbTelefono.Size = new Size(199, 23);
            msbTelefono.TabIndex = 8;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 481);
            Controls.Add(msbTelefono);
            Controls.Add(lblTitulo);
            Controls.Add(btnAgendar);
            Controls.Add(btnCancelar);
            Controls.Add(lstContactos);
            Controls.Add(txtContacto);
            Controls.Add(lblTelefono);
            Controls.Add(lblContacto);
            Name = "frmAgenda";
            Text = "Form1";
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
    }
}
