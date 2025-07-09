using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace ProjetoCorreios
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {

            InitializeComponent();

        }

        private void btnCorreios_Click(object sender, EventArgs e)
        {

            FormCorreio correio = new FormCorreio();
            correio.Show();

        }

        private void btnClimatempo_Click(object sender, EventArgs e)
        {

            FormClima clima = new FormClima();
            clima.Show();

        }
    }
}
