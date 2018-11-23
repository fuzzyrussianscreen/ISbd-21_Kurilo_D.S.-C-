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
        
        MultiLevelHangar hangar;
        private const int countLevel = 3;
        FormConfig form;
        public FormHangar()
        {
            InitializeComponent();
            hangar = new MultiLevelHangar(countLevel, pictureBoxHangar.Width, pictureBoxHangar.Height);
            for (int i = 0; i < countLevel; i++)
            {
                listBoxLevels.Items.Add("Уровень " + (i + 1));
            }
            listBoxLevels.SelectedIndex = 0;
           
        }

        /// <summary>
        /// Метод отрисовки
        /// </summary>
        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxHangar.Width, pictureBoxHangar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                hangar[listBoxLevels.SelectedIndex].Draw(gr);
                pictureBoxHangar.Image = bmp;
            }
        }
        

        private void buttonCreateWarPlaner_Click(object sender, EventArgs e)
        {
            form = new FormConfig();
            form.AddEvent(AddFighter);
            form.Show();
        }

        private void buttonTakePlane_Click(object sender, EventArgs e)
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                if (maskedTextBox1.Text != "")
                {
                    var fighter = hangar[listBoxLevels.SelectedIndex] - (Convert.ToInt32(maskedTextBox1.Text) - 1);
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

        private void listBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void AddFighter(IAircraft fighter)
        {
            if (fighter != null && listBoxLevels.SelectedIndex > -1)
            {
                int place = hangar[listBoxLevels.SelectedIndex] + fighter;
                if (place > -1)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
                }
            }
        }
    }
}
