using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juegode_Craps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Form2 formulario = new Form2();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

      