using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    

namespace ABMCarrera
{
    public partial class frmNuevaCarrera : Form
    {
        DBHelper gestor;
        Carrea nuevaCarrera;

        public frmNuevaCarrera()
        {
            InitializeComponent();
            nuevaCarrera = new Carrea();
            gestor = new DBHelper();
            

        }

        private void Nueva_Carrera_Load(object sender, EventArgs e)
        {
            CargarAsignatura();
            lblCarreraNro.Text = lblCarreraNro.Text + "" + gestor.ProximaCarrera().ToString();



        }

        

        private void CargarAsignatura()
        {
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = @"Data Source=DESKTOP-3PA9VUQ\SQLEXPRESS;Initial Catalog=Carrera;Integrated Security=True";
            conexion.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = "sp_ConsultarAsignaturas";
            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());
            conexion.Close();

            cboAsignaturas.DataSource = tabla;
            cboAsignaturas.ValueMember = tabla.Columns[0].ColumnName;
            cboAsignaturas.DisplayMember = tabla.Columns[1].ColumnName;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitulo.Text))
            {
                MessageBox.Show("Debe ingresar un titulo"
                    ,"Control"
                    ,MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation );
                return;
            }
            if(cboAsignaturas.SelectedIndex == -1)
            {

                MessageBox.Show("Debe seleccionar una asignatura"
                    , "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }
            if(!rbtPrimerCuatrismestre.Checked && !rbtSegundoCuatrimestre.Checked)
            {

                MessageBox.Show("Debe seleccionar  el cuiatrimestre"
                    , "Control"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Exclamation);
                return;
            }
            foreach(DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Cells["Asignaturas"].Value.Equals(cboAsignaturas.Text))
                {

                    MessageBox.Show("Esta asignatura ya esta agregada "
                        , "Control"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Exclamation);
                    return;
                }
            }
            DataRowView item = (DataRowView)cboAsignaturas.SelectedItem;

            int id = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            Asignatura a = new Asignatura(id,nom);

            DateTime cursado = Convert.ToDateTime(dtpAnioCursado.Value);
            int cuatrimestre = 0;
            if (rbtPrimerCuatrismestre.Checked == true)
            {
                cuatrimestre = 1;
            }
            else
            {
                cuatrimestre = 2;
            }
            DetalleCarrera detalle = new DetalleCarrera(cursado, cuatrimestre, a);
            nuevaCarrera.AgregarDetalle(detalle);
            dgvDetalle.Rows.Add(detalle.Asignatura.NomAsignatura,
                                 detalle.AñoCursado,
                                 detalle.Cuatrimestre,
                                 "Quitar");


        }


        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalle.CurrentCell.ColumnIndex == 3)
            {
                nuevaCarrera.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.RemoveAt(dgvDetalle.CurrentRow.Index);
            }
        }
    }
}
