using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Square square;
        private Rhomb rhomb;
        private Circle circle;

        public Form1()
        {

            InitializeComponent();
            g = this.CreateGraphics();
            
        }
        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            circle = new Circle(100, 225, 50);
            DoubleBuffered = true;
            circle.MoveRight(g);

        }

        private void ButtonSquare_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            square = new Square(400, 225, 100);
            DoubleBuffered = true;
            square.MoveRight(g);
        }

        private void ButtonRhomb_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            rhomb = new Rhomb(400, 225, 120, 80);
            DoubleBuffered = true;
            rhomb.MoveRight(g);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
        
        }
    }


