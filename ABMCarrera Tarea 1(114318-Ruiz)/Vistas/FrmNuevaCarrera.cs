using ABMCarrera.Datos;
using ABMCarrera.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMCarrera.Vistas
{
    public partial class FrmNuevaCarrera : Form
    {
        DBHelper gestor;
        Carrera nueva;
        public FrmNuevaCarrera()
        {
            InitializeComponent();
            nueva = new Carrera();
            gestor = new DBHelper();
        }

        private void FrmNuevaCarrera_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            dtpAñoCursado.Text = DateTime.Now.ToShortDateString();
            rbtPrimerCuatrimestre.Checked = false;
            rbtSegundoCuatrimestre.Checked = false;
            CargarAsignaturas();
            lblCarreraNro.Text = lblCarreraNro.Text + " " + gestor.ProximaCarrera().ToString();
        }
        public void CargarAsignaturas()
        {
            DataTable tabla = gestor.Consultar("sp_ConsultarAsignaturas");
            cboAsignatura.DataSource = tabla;
            cboAsignatura.ValueMember = tabla.Columns[0].ColumnName;
            cboAsignatura.DisplayMember = tabla.Columns[1].ColumnName;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar un titulo","Control"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(cboAsignatura.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una asignatura", "Control"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if(!rbtPrimerCuatrimestre.Checked && !rbtSegundoCuatrimestre.Checked)
            {
                MessageBox.Show("Debe elegir el cuatrimestre","Control"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            foreach(DataGridViewRow fila in dgvDetalle.Rows)
            {
                MessageBox.Show("Esta asigantura ya esta agregada", "Control"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataRowView item = (DataRowView)cboAsignatura.SelectedItem;

            int id = Convert.ToInt32(item.Row.ItemArray[0]);
            string nombre = item.Row.ItemArray[1].ToString();
            Asignatura a = new Asignatura(id, nombre);

            DateTime cursado = Convert.ToDateTime(dtpAñoCursado.Value);
            int cuatrimestre = 0;
            if(rbtPrimerCuatrimestre.Checked == true)
            {
                cuatrimestre = 1;
            }
            else
            {
                cuatrimestre = 2;
            }

            DetalleCarrera detalle = new DetalleCarrera(cursado, cuatrimestre,a);
            nueva.AgregarDetalle(detalle);
            dgvDetalle.Rows.Add(new object[] {detalle.Asignatura.NombreAsignatura,
            detalle.AñoCursado,
            detalle.Cuatrimestre,"Quitar"});
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar una carrera","Control"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Exclamation); 
                return;
            }
            GrabarCarrera();
        }
        public void GrabarCarrera()
        {
            nueva.NombreCarrera = txtTitulo.Text;
            if (gestor.ConfirmarCarrera(nueva))
            {
                MessageBox.Show("Se ha guardado con exito","Correcto"
                    ,MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Algo salio mal", "Error"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalle.CurrentCell.ColumnIndex == 3)
            {
                nueva.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index) ;
            }
        }
    }
}
