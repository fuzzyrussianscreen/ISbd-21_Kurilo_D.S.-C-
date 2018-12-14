using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    public class Fighter : Plane, IComparable<Fighter>, IEquatable<Fighter>
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

        public Fighter(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 10)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                MiddleWild = Convert.ToBoolean(strs[3]);
                BackWild = Convert.ToBoolean(strs[4]);
                DopColor = Color.FromName(strs[5]);
                FrontWild = Convert.ToBoolean(strs[6]);
                Signs = Convert.ToBoolean(strs[7]);
                Signs2 = Convert.ToBoolean(strs[8]);
            }
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

        public override string ToString()
        {
            return base.ToString() + ";" + DopColor.Name + ";" + FrontWild + ";" + Signs + ";" + Signs2;//" + CountLines;
        }

        public int CompareTo(Fighter other)
        {
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
            if (FrontWild != other.FrontWild)
            {
                return FrontWild.CompareTo(other.FrontWild);
            }
            if (Signs != other.Signs)
            {
                return Signs.CompareTo(other.Signs);
            }
            if (Signs2 != other.Signs2)
            {
                return Signs2.CompareTo(other.Signs2);
            }
            return 0;
        }
        
        public bool Equals(Fighter other)
        {
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
            if (FrontWild != other.FrontWild)
            {
                return false;
            }
            if (Signs != other.Signs)
            {
                return false;
            }
            if (Signs2 != other.Signs2)
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
            Fighter fighterObj = obj as Fighter;
            if (fighterObj == null)
            {
                return false;
            }
            else
            {
                return Equals(fighterObj);
            }
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
