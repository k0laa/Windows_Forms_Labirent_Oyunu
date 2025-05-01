namespace Wİndows_Forms_Labirent_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveTo_Start();
        }

        private void Finish_lbl_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler, Labirenti Başardınız!");
            Close();
        }

        private void MoveTo_Start()
        {
            Point startPoint = Start_lbl.Location;
            Cursor.Position = PointToScreen(startPoint);
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            MoveTo_Start();
        }
    }
}
