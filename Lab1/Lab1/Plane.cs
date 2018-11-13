﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Plane : War_plane
    {
        protected const int planeWidth = 120;
        protected const int planeHeight = 120;
        protected bool MiddleWild { private set; get; }
        protected bool BackWild { private set; get; }
        
        public Plane(int maxSpeed, float weight, Color mainColor, bool middleWild, bool backWild)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            MiddleWild = middleWild;
            BackWild = backWild;
        }

        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        public override void DrawFighter(Graphics g)
        {
            
            Pen pen_18 = new Pen(DopColor, 16);
            Pen pen_8 = new Pen(Color.Green, 8);
            Pen pen_5 = new Pen(Color.Green, 5);
            Pen pen_9 = new Pen(MainColor, 10);
            Pen pen_6 = new Pen(MainColor, 6);
            Pen pen_3 = new Pen(MainColor, 3);

            Brush spoiler = new SolidBrush(MainColor);

            if (BackWild)
            {
                g.DrawLine(pen_9, _startPosX + 31, _startPosY - 24, _startPosX + 31, _startPosY + 24);

                g.DrawLine(pen_8, _startPosX + 4, _startPosY - 5, _startPosX, _startPosY - 20);
                g.DrawLine(pen_8, _startPosX + 14, _startPosY - 5, _startPosX, _startPosY - 20);

                g.DrawLine(pen_8, _startPosX + 4, _startPosY + 5, _startPosX, _startPosY + 20);
                g.DrawLine(pen_8, _startPosX + 14, _startPosY + 5, _startPosX, _startPosY + 20);
            }
            
            if (MiddleWild)
            {
                g.DrawLine(pen_8, _startPosX + 24, _startPosY - 5, _startPosX + 22, _startPosY - 50);
                g.DrawLine(pen_8, _startPosX + 40, _startPosY - 5, _startPosX + 22, _startPosY - 50);

                g.DrawLine(pen_8, _startPosX + 24, _startPosY + 5, _startPosX + 22, _startPosY + 50);
                g.DrawLine(pen_8, _startPosX + 40, _startPosY + 5, _startPosX + 22, _startPosY + 50);
            }

            g.FillRectangle(spoiler, _startPosX, _startPosY - 6, 80, 12);
            g.DrawLine(pen_6, _startPosX + 79, _startPosY - 3, _startPosX + 100, _startPosY);
            g.DrawLine(pen_6, _startPosX + 79, _startPosY + 3, _startPosX + 100, _startPosY);
            
            g.DrawLine(pen_5, _startPosX + 100, _startPosY, _startPosX + 110, _startPosY);
        }
    }
}
