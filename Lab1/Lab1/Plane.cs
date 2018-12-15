using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Plane : War_plane, IComparable<Plane>, IEquatable<Plane>
    {
        protected const int planeWidth = 120;
        protected const int planeHeight = 120;
        public bool MiddleWild { protected set; get; }
        public bool BackWild { protected set; get; }

        public Plane(int maxSpeed, float weight, Color mainColor, bool middleWild, bool backWild)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            MiddleWild = middleWild;
            BackWild = backWild;
        }

        public Plane(string info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 5)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.Green;
                MiddleWild = Convert.ToBoolean(strs[3]);
                BackWild = Convert.ToBoolean(strs[4]);
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

        public override string ToString()
        {
            return MaxSpeed + ";" + Weight + ";" + MainColor.Name + ";" + MiddleWild + ";" + BackWild;
        }

        public int CompareTo(Plane other)
        {
            if (other == null)
            {
                return 1;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return MaxSpeed.CompareTo(other.MaxSpeed);
            }
            if (Weight != other.Weight)
            {
                return Weight.CompareTo(other.Weight);
            }
            if (MainColor != other.MainColor)
            {
                MainColor.Name.CompareTo(other.MainColor.Name);
            }
            if (DopColor != other.DopColor)
            {
                DopColor.Name.CompareTo(other.DopColor.Name);
            }
            if (MiddleWild != other.MiddleWild)
            {
                return MiddleWild.CompareTo(other.MiddleWild);
            }
            if (BackWild != other.BackWild)
            {
                return BackWild.CompareTo(other.BackWild);
            }
            return 0;
        }

        public bool Equals(Plane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            if (MiddleWild != other.MiddleWild)
            {
                return false;
            }
            if (BackWild != other.BackWild)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Plane planeObj = obj as Plane;
            if (planeObj == null)
            {
                return false;
            }
            else
            {
                return Equals(planeObj);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
