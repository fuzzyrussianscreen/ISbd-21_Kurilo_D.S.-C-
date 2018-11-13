using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class FormHangar : Form
    {
        Hangar<IAircraft> hangar;

        public FormHangar()
        {
            InitializeComponent();
            hangar = new Hangar<IAircraft>(16, pictureBoxHangar.Width, pictureBoxHangar.Height);
            Draw();
        }

        /// <summary>
        /// Метод отрисовки
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
            Graphics gr = Graphics.FromImage(bmp);
            hangar.Draw(gr);
            pictureBoxHangar.Image = bmp;
        }

        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateFighter_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var fighter = new Fighter(11000, 2450, dialog.Color, dialogDop.Color, true, true, true, true, true);
                    int place = hangar + fighter;

                    Draw();
                }
            }
        }

        private void buttonCreateWarPlaner_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fighter = new Plane(11000, 2450, dialog.Color, true, true);
                int place = hangar + fighter;
                Draw();
            }
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "")
            {
                var fighter = hangar - Convert.ToInt32(maskedTextBox1.Text);
                if (fighter != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeFighter.Width, pictureBoxTakeFighter.Height);
                    Graphics gr = Graphics.FromImage(bmp);
                    fighter.SetPosition(25, 85, pictureBoxTakeFighter.Width, pictureBoxTakeFighter.Height);
                    fighter.DrawFighter(gr);
                    pictureBoxTakeFighter.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTakeFighter.Width,
                   pictureBoxTakeFighter.Height);
                    pictureBoxTakeFighter.Image = bmp;
                }
                Draw();
            }
        }

    }
}
