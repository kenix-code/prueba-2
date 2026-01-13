using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace desarrollo_actual
{
    public partial class frmfuncion_4 : Form
    {
        public frmfuncion_4()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Close();
            this.Close();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
            this.Close();
        }

        private void frmfuncion_4_Load(object sender, EventArgs e)
        {

        }

        private void btmansiedad_Click(object sender, EventArgs e)
        {
            ansiedad ansiedad = new ansiedad();
            ansiedad.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            derecion derecion = new derecion();
            derecion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            estres estres = new estres();
            estres.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TDHA tDHA = new TDHA();
            tDHA.Show();
        }
    }
}
