using ABMCarrera2.Datos;
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
    public partial class ConsultarCarrera : Form
    {
        public ConsultarCarrera()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ConsultarCarrera_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sp = "sp_ConsultarCarrera";
            List<Parametro> lista = new List<Parametro>();
            lista.Add(new Parametro("@titulo",txtCarrera.Text));

            dgvConsultarCarrera.Rows.Clear();
            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lista);
            foreach (DataRow fila in tabla.Rows)
            {
                dgvConsultarCarrera.Rows.Add(new object[] { fila["id_Carrera"].ToString(),
                fila["Titulo"].ToString(),
                    "Ver Detalle"});
            }
        }

        private void dgvConsultarCarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvConsultarCarrera.CurrentCell.ColumnIndex == 2)
            {
                int nro = int.Parse(dgvConsultarCarrera.CurrentRow.Cells["ColCarreraNro"].Value.ToString());
                new DetalleCarrera(nro).ShowDialog();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int nro = int.Parse(dgvConsultarCarrera.CurrentRow.Cells["ColCarreraNro"].Value.ToString());
            new ModificarCarrera(nro).ShowDialog();
            this.btnConsultar_Click(null,null);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea quitar la carrera seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dgvConsultarCarrera.CurrentRow != null)
                {
                    int nro = int.Parse(dgvConsultarCarrera.CurrentRow.Cells["ColCarreraNro"].Value.ToString());
                    List<Parametro> lista = new List<Parametro>();
                    lista.Add(new Parametro("@idCarrera", nro));

                    int afectadas = DBHelper.ObtenerInstancia().EjecutarSQL("SP_ELIMINAR_CARRERA", lista);
                    if (afectadas == 1)
                    {
                        MessageBox.Show("La carrera se quitó correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.btnConsultar_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("La carrera NO se quitó!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que quiere salir?", "Confirmacion"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
