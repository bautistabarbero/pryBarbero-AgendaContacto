namespace pryBarberoAgendaContacto
{
    partial class frmVerContactos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDatosDelContacto = new Label();
            lblTel = new Label();
            lblNomb = new Label();
            lblTelefonoContacto = new Label();
            lblNombreContacto = new Label();
            btnAnterior = new Button();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // lblDatosDelContacto
            // 
            lblDatosDelContacto.AutoSize = true;
            lblDatosDelContacto.Font = new Font("Segoe UI", 12F);
            lblDatosDelContacto.Location = new Point(88, 24);
            lblDatosDelContacto.Name = "lblDatosDelContacto";
            lblDatosDelContacto.Size = new Size(141, 21);
            lblDatosDelContacto.TabIndex = 0;
            lblDatosDelContacto.Text = "Datos del contacto:";
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Location = new Point(114, 107);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(0, 15);
            lblTel.TabIndex = 1;
            // 
            // lblNomb
            // 
            lblNomb.AutoSize = true;
            lblNomb.Location = new Point(114, 66);
            lblNomb.Name = "lblNomb";
            lblNomb.Size = new Size(0, 15);
            lblNomb.TabIndex = 2;
            // 
            // lblTelefonoContacto
            // 
            lblTelefonoContacto.AutoSize = true;
            lblTelefonoContacto.Location = new Point(30, 107);
            lblTelefonoContacto.Name = "lblTelefonoContacto";
            lblTelefonoContacto.Size = new Size(56, 15);
            lblTelefonoContacto.TabIndex = 3;
            lblTelefonoContacto.Text = "Telefono:";
            // 
            // lblNombreContacto
            // 
            lblNombreContacto.AutoSize = true;
            lblNombreContacto.Location = new Point(32, 66);
            lblNombreContacto.Name = "lblNombreContacto";
            lblNombreContacto.Size = new Size(54, 15);
            lblNombreContacto.TabIndex = 4;
            lblNombreContacto.Text = "Nombre:";
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(46, 158);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(100, 36);
            btnAnterior.TabIndex = 5;
            btnAnterior.Text = "<---";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(181, 158);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(101, 36);
            btnSiguiente.TabIndex = 6;
            btnSiguiente.Text = "--->";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // frmVerContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(335, 239);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAnterior);
            Controls.Add(lblNombreContacto);
            Controls.Add(lblTelefonoContacto);
            Controls.Add(lblNomb);
            Controls.Add(lblTel);
            Controls.Add(lblDatosDelContacto);
            Name = "frmVerContactos";
            Text = "Form1";
            Load += frmVerContactos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosDelContacto;
        private Label lblTel;
        private Label lblNomb;
        private Label lblTelefonoContacto;
        private Label lblNombreContacto;
        private Button btnAnterior;
        private Button btnSiguiente;
    }
}