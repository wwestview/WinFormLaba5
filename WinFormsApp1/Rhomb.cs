using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Rhomb : Figure
    {
        protected int horDiagLen;
        protected int vertDiagLen;
        public Rhomb(int centerX, int centerY, int horDiagLen, int vertDiagLen)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.horDiagLen = horDiagLen;
            this.vertDiagLen = vertDiagLen;
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
            new Point(centerX, centerY - vertDiagLen / 2), 
            new Point(centerX + horDiagLen / 2, centerY), 
            new Point(centerX, centerY + vertDiagLen / 2), 
            new Point(centerX - horDiagLen / 2, centerY)  
            };
        }
    }
}
