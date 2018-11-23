﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    public class Fighter : Plane
    {

        public bool FrontWild { private set; get; }
        public bool Signs { private set; get; }
        public bool Signs2 { private set; get; }

        public Fighter(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       frontWild, bool middleWild, bool backWild, bool signs, bool signs2) : base(maxSpeed, weight, mainColor, middleWild, backWild)
        {
            FrontWild = frontWild;
            Signs = signs;
            Signs2 = signs2;
            DopColor = dopColor;
        }

        public override void DrawFighter(Graphics g)
        {
            Pen pen_18 = new Pen(DopColor, 16);
            Pen pen_8 = new Pen(DopColor, 8);
            Pen pen_5 = new Pen(DopColor, 5);
            Pen pen_9 = new Pen(MainColor, 10);
            Pen pen_6 = new Pen(MainColor, 6);
            Pen pen_3 = new Pen(MainColor, 3);
            Brush brush = new SolidBrush(DopColor);

            if (FrontWild)
            {
                g.DrawLine(pen_18, _startPosX + 46, _startPosY, _startPosX + 55, _startPosY + 10);
                g.DrawLine(pen_18, _startPosX + 46, _startPosY, _startPosX + 55, _startPosY - 10);
            }

            base.DrawFighter(g);

            if (Signs)
            {
                g.FillEllipse(brush, _startPosX + 18, _startPosY - 52, 10, 12);
                g.FillEllipse(brush, _startPosX + 18, _startPosY + 40, 10, 12);
            }

            if (Signs2)
            {
                g.FillEllipse(brush, _startPosX, _startPosY - 6, 10, 12);
            }

        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}
