namespace Wİndows_Forms_Labirent_Oyunu
{
    public partial class Form1 : Form
    {

        System.Media.SoundPlayer wall = new System.Media.SoundPlayer(@"C:\Windows\Media\chord.wav");
        System.Media.SoundPlayer finish = new System.Media.SoundPlayer(@"C:\Windows\Media\tada.wav");

        public Form1()
        {
            InitializeComponent();
            MoveTo_Start();
        }

        private void Finish_lbl_MouseEnter(object sender, EventArgs e)
        {
            finish.Play();
            MessageBox.Show("Tebrikler, Labirenti Başardınız!");
        }

        private void MoveTo_Start()
        {
            Point startPoint = Start_lbl.Location;
            Cursor.Position = PointToScreen(startPoint);
            wall.Play();
        }

        private void Wall_MouseEnter(object sender, EventArgs e)
        {
            MoveTo_Start();
        }
    }
}
