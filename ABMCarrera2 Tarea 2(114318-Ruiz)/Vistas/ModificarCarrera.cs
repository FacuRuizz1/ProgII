using ABMCarrera2.Datos;
using ABMCarrera2.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMCarrera2.Vistas
{
    public partial class ModificarCarrera : Form
    {
        private Carrera oCarrera;
        public ModificarCarrera(int nroCarrera)
        {
            InitializeComponent();
            oCarrera = new Carrera();
            oCarrera.IdCarrera = nroCarrera;
            CargarAsignaturas();

        }

        private void ModificarCarrera_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + oCarrera.IdCarrera.ToString();
            string sp = "SP_CONSULTAR_DETALLE_CARRERA";
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@idCarrera", oCarrera.IdCarrera));
            DataTable dt = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lista);
            bool primero = true;
            foreach(DataRow fila in dt.Rows)
            {
                if (primero)
                {
                    oCarrera.NombreCarrera = fila["Titulo"].ToString();
                    txtTitulo.Text = oCarrera.NombreCarrera;
                    primero = false;
                }
                int NroAsignatura = int.Parse(fila["id_asignatura"].ToString());
                string nombre = fila["nombre_asignatura"].ToString();

                Asignatura oAsignatura = new Asignatura(NroAsignatura, nombre);
                DateTime Año = Convert.ToDateTime(fila["AnioCursado"].ToString());
                int cuatri = int.Parse(fila["Cuatrimestre"].ToString());
                Dominio.DetalleCarrera detalle = new Dominio.DetalleCarrera(Año, cuatri, oAsignatura);
                oCarrera.AgregarDetalle(detalle);
                dgvDetalle.Rows.Add(new object[]
                {
                    oAsignatura.IdAsignatura,
                    oAsignatura.NombreAsignatura,
                    detalle.AñoCursado,
                    detalle.Cuatrimestre
                });
            }
        }
        private void CargarAsignaturas()
        {
            DBHelper helper = DBHelper.ObtenerInstancia();
            DataTable tabla = helper.ConsultaSQL("sp_ConsultarAsignaturas", null);
            if(tabla != null)
            {
                cboAsignatura.DataSource = tabla;
                cboAsignatura.DisplayMember = "nombre_asignatura";
                cboAsignatura.ValueMember = "id_asignatura";

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(txtTitulo.Text))
            //{
            //    MessageBox.Show("Debe ingresar un titulo"
            //        , "Control"
            //        , MessageBoxButtons.OK
            //        , MessageBoxIcon.Exclamation);
            //    return;
            //}
            if (cboAsignatura.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un Asignatura"
                    , "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }
            if (!rbtPrimerCuatrimestre.Checked && !rbtSegundoCautrimestre.Checked)
            {
                MessageBox.Show("Debe ingresar un titulo"
                    , "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["ColAsignaturas"].Value.Equals(cboAsignatura.Text))
                {
                    MessageBox.Show("Esta asignatura ya esta agregada"
                   , "Control"
                   , MessageBoxButtons.OK
                   , MessageBoxIcon.Exclamation);
                    return;
                }
            }
            DataRowView item = (DataRowView)cboAsignatura.SelectedItem;
            int id= Convert.ToInt32(item.Row.ItemArray[0]);
            string nombre = item.Row.ItemArray[1].ToString();
            Asignatura asignatura = new Asignatura();

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

            Dominio.DetalleCarrera detalle = new Dominio.DetalleCarrera(cursado, cuatrimestre, asignatura);
            oCarrera.AgregarDetalle(detalle);
            dgvDetalle.Rows.Add(new object[] {
            detalle.Asignatura.NombreAsignatura,
            detalle.AñoCursado,
            detalle.Cuatrimestre, "Quitar"});
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalle.CurrentCell.ColumnIndex == 4)
            {
                oCarrera.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            }
        }
        private void GrabarCarrera()
        {
            oCarrera.NombreCarrera = txtTitulo.Text;
            DBHelper helper = DBHelper.ObtenerInstancia();
            if (helper.ModificarCarrera(oCarrera))
            {
                MessageBox.Show("Se ha actualizo con exito la carrera", "Correcto"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();

            }
            else
            {
                MessageBox.Show("No se pudo actualizar","Error"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);  

            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos una carrera", "Control"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            GrabarCarrera();
        }
    }
}
