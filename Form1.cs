using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABMCarrera
{
    public partial class Carrera : Form
    {
        public Carrera()
        {
            InitializeComponent();
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaCarrera nuevaCarrera = new frmNuevaCarrera();
            nuevaCarrera.ShowDialog();
        }
    }
}
