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
    public partial class Repetir_texto : Form
    {
        public Repetir_texto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = textpalabra.Text;
            listBox1.Items.Clear();
                int i = 0;
            while (i <= 4)
            {
                listBox1.Items.Add(texto);
                i = i + 1;
            }         
            }

        private void textpalabra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
