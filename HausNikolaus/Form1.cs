namespace HausNikolaus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Koordinaten f�r das Haus berechnen
            int Ax, Ay, Bx, By, Cx, Cy, Dx, Dy, Ex, Ey;
            int breite = pictureBox1.Width;
            int h�he = pictureBox1.Height;

            // Haus-Koordinaten in Abh�ngigkeit von der Gr��e des Fensters
            Ax = breite / 4; // Untere linke Ecke
            Ay = 3 * h�he / 4;

            Bx = 3 * breite / 4; // Untere rechte Ecke
            By = 3 * h�he / 4;

            Cx = breite / 2; // Spitze des Daches
            Cy = h�he / 4;

            Dx = Ax; // Linke obere Ecke des Hauses
            Dy = h�he / 2;

            Ex = Bx; // Rechte obere Ecke des Hauses
            Ey = h�he / 2;

            // Zeichnen des Hauses
            Graphics leinwand = pictureBox1.CreateGraphics();
            Pen stift = new Pen(Color.DarkRed, 2);
            leinwand.Clear(Color.SkyBlue);

            // Reihenfolge der Linien (Haus vom Nikolaus)
            System.Threading.Thread.Sleep(500);
            leinwand.DrawLine(stift, Ax, Ay, Bx, By); // Boden
            System.Threading.Thread.Sleep(500);
            leinwand.DrawLine(stift, Ax, Ay, Dx, Dy); // Linke Wand
            System.Threading.Thread.Sleep(500);
            leinwand.DrawLine(stift, Dx, Dy, Cx, Cy); // Dach links
            System.Threading.Thread.Sleep(500);
            leinwand.DrawLine(stift, Cx, Cy, Ex, Ey); // Dach rechts
            System.Threading.Thread.Sleep(500);
            leinwand.DrawLine(stift, Dx, Dy, Ex, Ey); // Horizontale Linie
            System.Threading.Thread.Sleep(500);
            leinwand.DrawLine(stift, Bx, By, Dx, Dy); // Diagonale rechts
            System.Threading.Thread.Sleep(500);
            leinwand.DrawLine(stift, Ex, Ey, Bx, By); // Rechte Wand
            System.Threading.Thread.Sleep(500);
            leinwand.DrawLine(stift, Ax, Ay, Ex, Ey); // Diagonale links
        }
    }
}
