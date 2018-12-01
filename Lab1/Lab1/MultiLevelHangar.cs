using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class MultiLevelHangar
    {
        List<Hangar<IAircraft>> hangarStages;

        private const int countPlaces = 16;
        private int pictureWidth;
        private int pictureHeight;

        public MultiLevelHangar(int countStages, int pictureWidth, int pictureHeight)
        {
            hangarStages = new List<Hangar<IAircraft>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
            for (int i = 0; i < countStages; ++i)
            {
                hangarStages.Add(new Hangar<IAircraft>(countPlaces, pictureWidth, pictureHeight));
            }
        }

        public Hangar<IAircraft> this[int ind]
        {
            get
            {
                if (ind > -1 && ind < hangarStages.Count)
                {
                    return hangarStages[ind];
                }
                return null;
            }
        }

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    WriteToFile("CountLeveles:" + hangarStages.Count + Environment.NewLine, fs);
                    foreach (var level in hangarStages)
                    {
                        WriteToFile("Level" + Environment.NewLine, fs);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            try
                            {
                                var fighter = level[i];
                                if (fighter != null)
                                {
                                    if (fighter.GetType().Name == "Plane")
                                    {
                                        WriteToFile(i + ":Plane:", fs);
                                    }
                                    if (fighter.GetType().Name == "Fighter")
                                    {
                                        WriteToFile(i + ":Fighter:", fs);
                                    }
                                    WriteToFile(fighter + Environment.NewLine, fs);
                                }
                            }
                            finally { }
                        }
                    }
                }
            }
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            string bufferTextFromFile = "";
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        bufferTextFromFile += temp.GetString(b);
                    }
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("CountLeveles"))
            {
                int count = Convert.ToInt32(strs[0].Split(':')[1]);
                if (hangarStages != null)
                {
                    hangarStages.Clear();
                }
                hangarStages = new List<Hangar<IAircraft>>(count);
            }
            else
            {
                throw new Exception("Неверный формат файла");
            }
            int counter = -1;
            IAircraft fighter = null;
            for (int i = 1; i < strs.Length; ++i)
            {
                if (strs[i] == "Level")
                {
                    counter++;
                    hangarStages.Add(new Hangar<IAircraft>(countPlaces, pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(':')[1] == "Plane")
                {
                    fighter = new Plane(strs[i].Split(':')[2]);
                }
                else if (strs[i].Split(':')[1] == "Fighter")
                {
                    fighter = new Fighter(strs[i].Split(':')[2]);
                }
                hangarStages[counter][Convert.ToInt32(strs[i].Split(':')[0])] = fighter;
            }
        }
    }
}
