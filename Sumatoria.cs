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
    public partial class Sumatoria : Form
    {
        public Sumatoria()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {  String texto = textnum.Text;
            listBox1.Items.Clear();//limpia los numeros anteriores
            int i = 0;

            while (i <= 20)
            {
                if (i % 2 == 0)
                {
                    listBox1.Items.Add(i);
                }
                i = i + 1;
            }

        }
    }
}
