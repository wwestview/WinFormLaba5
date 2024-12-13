using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Thread thread;
        private Graphics g;
        private Square square;
        private Rhomb rhomb;
        private Circle circle;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            DoubleBuffered = true;

        }
        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            circle = new Circle(100, 225, 50);
            circle.MoveRight(g);
        }

        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            square = new Square(400, 225, 100);
            square.MoveRight(g);
        }

        private void ButtonRhomb_Click(object sender, EventArgs e)
        {
            rhomb = new Rhomb(400, 225, 120, 80);
            rhomb.MoveRight(g);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


