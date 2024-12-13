using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public abstract class Figure
    {
            protected int centerX;
            protected int centerY;
            protected static bool status = false;
            protected static bool rightDirection = true;

            public abstract void DrawBlack(Graphics g);
            public abstract void HideDrawingBackGround(Graphics g);

            public void MoveRight(Graphics g)
            {
                for (int i = 0; i < 100; i++)
                {
                    DrawBlack(g);
                    Thread.Sleep(50);
                    HideDrawingBackGround(g);
                    centerX++;
                }
                status = false;
            }

            public static bool IsCreated()
            {
                return status;
            }
    }

}
