using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A5_Menu_While_JS
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnOp2_Click(object sender, EventArgs e)
        {
            Pares_e_Impares pares = new Pares_e_Impares();
            pares.Show();

            this.Hide();
        }

        private void btnOp1_Click(object sender, EventArgs e)
        {
            Repetir_texto repetir = new Repetir_texto();
            repetir.Show();

            this.Hide();
        }

        private void btnOp3_Click(object sender, EventArgs e)
        {
            Sumatoria sumatoria = new Sumatoria();
            sumatoria.Show();

            this.Hide();
        }
    }
}
