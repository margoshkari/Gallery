using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Gallery
{
    public partial class Form1 : Form
    {
        private string directoryPath = string.Empty;
        private string imagePath = string.Empty;
        private List<string> images = new List<string>();
        private List<string> filters = new List<string>();
        public Form1()
        {
            InitializeComponent();
            filters.AddRange(new string[] { "*.png", "*.jpg", "*.jpeg" });
            OpenFile();
        }
        private void OpenFile()
        {
            int imageIndex = 0;
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Images|*.png; *.jpg; *.jpeg";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    directoryPath = Path.GetDirectoryName(dialog.FileName);
                    this.pictureBox.Image = Image.FromFile(imagePath);
                    foreach (var filterItem in filters)
                    {
                        foreach (var item in Directory.GetFiles(directoryPath, filterItem))
                        {
                            images.Add(item);
                        }
                    }
                    foreach (var item in this.pictureBoxes)
                    {
                        if (imageIndex + 1 <= images.Count())
                        {
                            item.Image = Image.FromFile(images[imageIndex]);
                            item.Name = images[imageIndex];
                            imageIndex++;
                        }
                    }
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int index = images.IndexOf(imagePath);
            if (index + 1 < images.Count())
            {
                imagePath = images[++index];
                this.pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            int index = images.IndexOf(imagePath);
            if (index - 1 >= 0)
            {
                imagePath = images[--index];
                this.pictureBox.Image = Image.FromFile(imagePath);
            }
        }

        private void allImagesBtn_Click(object sender, EventArgs e)
        {
            images.Clear();
            OpenFile();
        }

        private void pictureBoxes_Click(object sender, System.EventArgs e)
        {
            if((sender as PictureBox)?.Name != string.Empty)
            {
                imagePath = this.Controls[(sender as PictureBox)?.Name].Name;
                this.pictureBox.Image = Image.FromFile(imagePath);
            }
        }
    }
}
