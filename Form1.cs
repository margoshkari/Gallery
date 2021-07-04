using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            filters.AddRange(new string[] { "*.png", "*.jpg" });
            OpenFile();
        }
        private void OpenFile()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Images|*.png; *.jpg";
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
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
