using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab1
{
    

    class Fighter
    {

        /// <summary>
        /// Левая координата отрисовки 
        /// </summary>
        private float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки
        /// </summary>
        private float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;

        //Высота окна отрисовки
        private int _pictureHeight;

        /// <summary>
        /// Ширина отрисовки 
        /// </summary>
        private const int carWidth = 100;

        /// <summary>
        /// Ширина отрисовки 
        /// </summary>
        private const int carHeight = 60;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }

        /// <summary>
        /// Вес 
        /// </summary>
        public float Weight { private set; get; }

        /// <summary>
        /// Основной цвет 
        /// </summary>
        public Color MainColor { private set; get; }

        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Признак наличия переднего крыла
        /// </summary>
        public bool FrontWind { private set; get; }

        /// <summary>
        /// Признак наличия боковых крыльев
        /// </summary>
        public bool MiddleWind { private set; get; }

        /// <summary>
        /// Признак наличия заднего крыла
        /// </summary>
        public bool BackWind { private set; get; }
        
        public Fighter(int maxSpeed, float weight, Color mainColor, Color dopColor, bool
       frontSpoiler, bool middleSpoiler, bool backSpoiler)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            MiddleWind = middleSpoiler;
            FrontWind = frontSpoiler;
            BackWind = backSpoiler;
        }
        
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
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
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawFighter(Graphics g)
        {
            Pen pen_18 = new Pen(DopColor, 16);
            Pen pen_8 = new Pen(DopColor, 8);
            Pen pen_5 = new Pen(DopColor, 5);
            Pen pen_9 = new Pen(MainColor, 10);
            Pen pen_6 = new Pen(MainColor, 6);
            Pen pen_3 = new Pen(MainColor, 3);

            Brush spoiler = new SolidBrush(Color.Black);
            
            if (BackWind)
            {
                g.DrawLine(pen_9, _startPosX + 31, _startPosY - 24, _startPosX + 31, _startPosY + 24);

                g.DrawLine(pen_8, _startPosX + 4, _startPosY - 5, _startPosX, _startPosY - 20);
                g.DrawLine(pen_8, _startPosX + 14, _startPosY - 5, _startPosX, _startPosY - 20);

                g.DrawLine(pen_8, _startPosX + 4, _startPosY + 5, _startPosX, _startPosY + 20);
                g.DrawLine(pen_8, _startPosX + 14, _startPosY + 5, _startPosX, _startPosY + 20);
            }

            if (MiddleWind)
            {
                g.DrawLine(pen_8, _startPosX + 24, _startPosY - 5, _startPosX + 22, _startPosY - 50);
                g.DrawLine(pen_8, _startPosX + 40, _startPosY - 5, _startPosX + 22, _startPosY - 50);

                g.DrawLine(pen_8, _startPosX + 24, _startPosY + 5, _startPosX + 22, _startPosY + 50);
                g.DrawLine(pen_8, _startPosX + 40, _startPosY + 5, _startPosX + 22, _startPosY + 50);

                g.DrawLine(pen_18, _startPosX + 46, _startPosY , _startPosX + 55, _startPosY + 10);
                g.DrawLine(pen_18, _startPosX + 46, _startPosY , _startPosX + 55, _startPosY - 10);
            }


            g.FillRectangle(spoiler, _startPosX, _startPosY - 6, 80, 12);
            g.DrawLine(pen_6, _startPosX + 79, _startPosY - 3, _startPosX + 100, _startPosY);
            g.DrawLine(pen_6, _startPosX + 79, _startPosY + 3, _startPosX + 100, _startPosY);

            if (FrontWind)
            {
                g.DrawLine(pen_5, _startPosX + 100, _startPosY, _startPosX + 110, _startPosY);
            }

        }
    }
}
