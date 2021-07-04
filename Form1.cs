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
        public Form1()
        {
            InitializeComponent();
            OpenFile();
        }
        private void OpenFile()
        {
            using(OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Images|*.png; *.jpg";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    directoryPath = Path.GetDirectoryName(dialog.FileName);
                }
            }
        }
    }
}
