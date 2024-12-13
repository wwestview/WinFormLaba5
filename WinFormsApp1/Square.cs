using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Square : Figure
    {
       protected int sideLength;
       public Square(int centerX,int centerY,int sideLen)
        {
            this.centerX = centerX;
            this.centerY = centerY; 
            this.sideLength = sideLen;
            status = true;
        }
        public override void DrawBlack(Graphics g)
        {
            g.DrawPolygon(Pens.Black, GetCurrentPoints());
        }
        public override void HideDrawingBackGround(Graphics g)
        {
            g.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetCurrentPoints());
        }

        private Point[] GetCurrentPoints()
        {
            return new Point[]
            {
            new Point(centerX - sideLength / 2, centerY - sideLength / 2), 
            new Point(centerX + sideLength / 2, centerY - sideLength / 2), 
            new Point(centerX + sideLength / 2, centerY + sideLength / 2), 
            new Point(centerX - sideLength / 2, centerY + sideLength / 2)
            };
        }
    }
}
