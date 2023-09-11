namespace ABMCarrera
{
    partial class frmNuevaCarrera
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
            this.lblAniodeCursado = new System.Windows.Forms.Label();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboAsignaturas = new System.Windows.Forms.ComboBox();
            this.dtpAnioCursado = new System.Windows.Forms.DateTimePicker();
            this.rbtPrimerCuatrismestre = new System.Windows.Forms.RadioButton();
            this.rbtSegundoCuatrimestre = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ColAsignacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAñoCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCarreraNro
            // 
            this.lblCarreraNro.AutoSize = true;
            this.lblCarreraNro.Location = new System.Drawing.Point(42, 54);
            this.lblCarreraNro.Name = "lblCarreraNro";
            this.lblCarreraNro.Size = new System.Drawing.Size(56, 13);
            this.lblCarreraNro.TabIndex = 0;
            this.lblCarreraNro.Text = "Carrera N°";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(138, 100);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(135, 138);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(57, 13);
            this.lblAsignatura.TabIndex = 2;
            this.lblAsignatura.Text = "Asignatura";
            // 
            // lblAniodeCursado
            // 
            this.lblAniodeCursado.AutoSize = true;
            this.lblAniodeCursado.Location = new System.Drawing.Point(126, 177);
            this.lblAniodeCursado.Name = "lblAniodeCursado";
            this.lblAniodeCursado.Size = new System.Drawing.Size(83, 13);
            this.lblAniodeCursado.TabIndex = 3;
            this.lblAniodeCursado.Text = "Año de Cursado";
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(135, 211);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 4;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(202, 97);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(162, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // cboAsignaturas
            // 
            this.cboAsignaturas.FormattingEnabled = true;
            this.cboAsignaturas.Location = new System.Drawing.Point(219, 135);
            this.cboAsignaturas.Name = "cboAsignaturas";
            this.cboAsignaturas.Size = new System.Drawing.Size(145, 21);
            this.cboAsignaturas.TabIndex = 6;
            // 
            // dtpAnioCursado
            // 
            this.dtpAnioCursado.Location = new System.Drawing.Point(219, 171);
            this.dtpAnioCursado.Name = "dtpAnioCursado";
            this.dtpAnioCursado.Size = new System.Drawing.Size(200, 20);
            this.dtpAnioCursado.TabIndex = 7;
            // 
            // rbtPrimerCuatrismestre
            // 
            this.rbtPrimerCuatrismestre.AutoSize = true;
            this.rbtPrimerCuatrismestre.Location = new System.Drawing.Point(233, 211);
            this.rbtPrimerCuatrismestre.Name = "rbtPrimerCuatrismestre";
            this.rbtPrimerCuatrismestre.Size = new System.Drawing.Size(101, 17);
            this.rbtPrimerCuatrismestre.TabIndex = 8;
            this.rbtPrimerCuatrismestre.TabStop = true;
            this.rbtPrimerCuatrismestre.Text = "1er Cuatrimestre";
            this.rbtPrimerCuatrismestre.UseVisualStyleBackColor = true;
            // 
            // rbtSegundoCuatrimestre
            // 
            this.rbtSegundoCuatrimestre.AutoSize = true;
            this.rbtSegundoCuatrimestre.Location = new System.Drawing.Point(343, 211);
            this.rbtSegundoCuatrimestre.Name = "rbtSegundoCuatrimestre";
            this.rbtSegundoCuatrimestre.Size = new System.Drawing.Size(104, 17);
            this.rbtSegundoCuatrimestre.TabIndex = 9;
            this.rbtSegundoCuatrimestre.TabStop = true;
            this.rbtSegundoCuatrimestre.Text = "2do Cuatrimestre";
            this.rbtSegundoCuatrimestre.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(473, 208);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAsignacion,
            this.ColAñoCursado,
            this.ColCuatrimestre,
            this.ColAccion});
            this.dgvDetalle.Location = new System.Drawing.Point(94, 246);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(493, 150);
            this.dgvDetalle.TabIndex = 11;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(233, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(401, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // ColAsignacion
            // 
            this.ColAsignacion.HeaderText = "Asignacion";
            this.ColAsignacion.Name = "ColAsignacion";
            this.ColAsignacion.ReadOnly = true;
            this.ColAsignacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAsignacion.Width = 150;
            // 
            // ColAñoCursado
            // 
            this.ColAñoCursado.HeaderText = "Año De Cursado";
            this.ColAñoCursado.Name = "ColAñoCursado";
            this.ColAñoCursado.ReadOnly = true;
            // 
            // ColCuatrimestre
            // 
            this.ColCuatrimestre.HeaderText = "Cuatrimestre";
            this.ColCuatrimestre.Name = "ColCuatrimestre";
            this.ColCuatrimestre.ReadOnly = true;
            this.ColCuatrimestre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColCuatrimestre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColAccion
            // 
            this.ColAccion.HeaderText = "Accion";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmNuevaCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbtSegundoCuatrimestre);
            this.Controls.Add(this.rbtPrimerCuatrismestre);
            this.Controls.Add(this.dtpAnioCursado);
            this.Controls.Add(this.cboAsignaturas);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.lblAniodeCursado);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCarreraNro);
            this.Name = "frmNuevaCarrera";
            this.Text = "Nueva Carrera";
            this.Load += new System.EventHandler(this.Nueva_Carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarreraNro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.Label lblAniodeCursado;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboAsignaturas;
        private System.Windows.Forms.DateTimePicker dtpAnioCursado;
        private System.Windows.Forms.RadioButton rbtPrimerCuatrismestre;
        private System.Windows.Forms.RadioButton rbtSegundoCuatrimestre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAsignacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAñoCursado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuatrimestre;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
    }
}