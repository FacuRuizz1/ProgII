namespace ABMCarrera2.Vistas
{
    partial class NuevaCarrera
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
            this.lblCarreraNro = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.lblAñoCursado = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboAsignatura = new System.Windows.Forms.ComboBox();
            this.dtpAñoCursado = new System.Windows.Forms.DateTimePicker();
            this.rbtPrimerCuatrimestre = new System.Windows.Forms.RadioButton();
            this.rbtSegundoCuatrimestre = new System.Windows.Forms.RadioButton();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ColAsignaturas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAñoCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarreraNro
            // 
            this.lblCarreraNro.AutoSize = true;
            this.lblCarreraNro.Location = new System.Drawing.Point(39, 29);
            this.lblCarreraNro.Name = "lblCarreraNro";
            this.lblCarreraNro.Size = new System.Drawing.Size(56, 13);
            this.lblCarreraNro.TabIndex = 0;
            this.lblCarreraNro.Text = "Carrera N°";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(107, 56);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(107, 90);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(57, 13);
            this.lblAsignatura.TabIndex = 2;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // lblAñoCursado
            // 
            this.lblAñoCursado.AutoSize = true;
            this.lblAñoCursado.Location = new System.Drawing.Point(81, 121);
            this.lblAñoCursado.Name = "lblAñoCursado";
            this.lblAñoCursado.Size = new System.Drawing.Size(83, 13);
            this.lblAñoCursado.TabIndex = 3;
            this.lblAñoCursado.Text = "Año de Cursado";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(97, 154);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 4;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(168, 53);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(128, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // cboAsignatura
            // 
            this.cboAsignatura.FormattingEnabled = true;
            this.cboAsignatura.Location = new System.Drawing.Point(168, 87);
            this.cboAsignatura.Name = "cboAsignatura";
            this.cboAsignatura.Size = new System.Drawing.Size(128, 21);
            this.cboAsignatura.TabIndex = 6;
            // 
            // dtpAñoCursado
            // 
            this.dtpAñoCursado.Location = new System.Drawing.Point(168, 121);
            this.dtpAñoCursado.Name = "dtpAñoCursado";
            this.dtpAñoCursado.Size = new System.Drawing.Size(200, 20);
            this.dtpAñoCursado.TabIndex = 7;
            // 
            // rbtPrimerCuatrimestre
            // 
            this.rbtPrimerCuatrimestre.AutoSize = true;
            this.rbtPrimerCuatrimestre.Location = new System.Drawing.Point(168, 154);
            this.rbtPrimerCuatrimestre.Name = "rbtPrimerCuatrimestre";
            this.rbtPrimerCuatrimestre.Size = new System.Drawing.Size(115, 17);
            this.rbtPrimerCuatrimestre.TabIndex = 8;
            this.rbtPrimerCuatrimestre.TabStop = true;
            this.rbtPrimerCuatrimestre.Text = "Primer Cuatrimestre";
            this.rbtPrimerCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // rbtSegundoCuatrimestre
            // 
            this.rbtSegundoCuatrimestre.AutoSize = true;
            this.rbtSegundoCuatrimestre.Location = new System.Drawing.Point(289, 154);
            this.rbtSegundoCuatrimestre.Name = "rbtSegundoCuatrimestre";
            this.rbtSegundoCuatrimestre.Size = new System.Drawing.Size(129, 17);
            this.rbtSegundoCuatrimestre.TabIndex = 9;
            this.rbtSegundoCuatrimestre.TabStop = true;
            this.rbtSegundoCuatrimestre.Text = "Segundo Cuatrimestre";
            this.rbtSegundoCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAsignaturas,
            this.ColAñoCursado,
            this.ColCuatrimestre,
            this.ColAcciones});
            this.dgvDetalle.Location = new System.Drawing.Point(81, 188);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(516, 150);
            this.dgvDetalle.TabIndex = 10;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // ColAsignaturas
            // 
            this.ColAsignaturas.HeaderText = "Asignaturas";
            this.ColAsignaturas.Name = "ColAsignaturas";
            this.ColAsignaturas.ReadOnly = true;
            this.ColAsignaturas.Width = 150;
            // 
            // ColAñoCursado
            // 
            this.ColAñoCursado.HeaderText = "Año de Cursado";
            this.ColAñoCursado.Name = "ColAñoCursado";
            this.ColAñoCursado.ReadOnly = true;
            this.ColAñoCursado.Width = 120;
            // 
            // ColCuatrimestre
            // 
            this.ColCuatrimestre.HeaderText = "Cuatrimestre";
            this.ColCuatrimestre.Name = "ColCuatrimestre";
            this.ColCuatrimestre.ReadOnly = true;
            this.ColCuatrimestre.Width = 110;
            // 
            // ColAcciones
            // 
            this.ColAcciones.HeaderText = "Acciones";
            this.ColAcciones.Name = "ColAcciones";
            this.ColAcciones.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(431, 154);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.Location = new System.Drawing.Point(522, 154);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 23);
            this.btnGrabar.TabIndex = 12;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // NuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 380);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.rbtSegundoCuatrimestre);
            this.Controls.Add(this.rbtPrimerCuatrimestre);
            this.Controls.Add(this.dtpAñoCursado);
            this.Controls.Add(this.cboAsignatura);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAñoCursado);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCarreraNro);
            this.Name = "NuevaCarrera";
            this.Text = "NuevaCarrera";
            this.Load += new System.EventHandler(this.NuevaCarrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarreraNro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblAñoCursado;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboAsignatura;
        private System.Windows.Forms.DateTimePicker dtpAñoCursado;
        private System.Windows.Forms.RadioButton rbtPrimerCuatrimestre;
        private System.Windows.Forms.RadioButton rbtSegundoCuatrimestre;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsignaturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAñoCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatrimestre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridViewButtonColumn ColAcciones;
    }
}