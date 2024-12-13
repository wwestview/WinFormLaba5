using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    class Circle : Figure
    {
        protected int radius;
        public Circle(int centerX, int centerY, int radius)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
            status = true;
        }
    
        public override void DrawBlack(Graphics g)
        {
            g.DrawEllipse(Pens.Black, GetCurrentPoints());   
        }
       
         public override void HideDrawingBackGround(Graphics g)
         {
            g.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), GetCurrentPoints());
         }
       
       private Rectangle GetCurrentPoints()
        {
            return new Rectangle(centerX - radius, centerY - radius, radius * 2, radius * 2);
        }
    }
}
