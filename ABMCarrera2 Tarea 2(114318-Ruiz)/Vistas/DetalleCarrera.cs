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
    public partial class DetalleCarrera : Form
    {
        private int CarreraNro;
        public DetalleCarrera(int carreranro)
        {
            InitializeComponent();
            this.CarreraNro = carreranro;
            
        }

        private void DetalleCarrera_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + CarreraNro.ToString();
            string sp = "SP_CONSULTAR_DETALLE_CARRERA";
            List<Parametro> lista = new List<Parametro>();

            lista.Add(new Parametro("@idCarrera",CarreraNro));
            DataTable tabla = DBHelper.ObtenerInstancia().ConsultaSQL(sp, lista);
            bool primero = true;

            foreach(DataRow fila in tabla.Rows)
            {
                if (primero)
                {
                   txtTitulo.Text = fila["Titulo"].ToString();
                    primero = false;
                }
                dgvDetalle.Rows.Add(new object[] { fila["nombre_asignatura"].ToString(),
                fila["AnioCursado"].ToString(), fila["Cuatrimestre"]});
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
