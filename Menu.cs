using System.Drawing;

using System.Drawing.Drawing2D;

using System.Windows.Forms; 


namespace desarrollo_actual
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
            btmfuncion1.FlatStyle = FlatStyle.Flat;
            

            int radius = 80;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); 
            path.AddArc(btmfuncion1.Width - radius, 0, radius, radius, 270, 90); 

            path.AddArc(btmfuncion1.Width - radius, btmfuncion1.Height - radius, radius, radius, 0, 90); 

            path.AddArc(0, btmfuncion1.Height - radius, radius, radius, 90, 90); 

            path.CloseFigure();

            btmfuncion1.Region = new Region(path);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmfuncion_4 frmfuncion_4 = new frmfuncion_4();
            frmfuncion_4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmmenu_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
