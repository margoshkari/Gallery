
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gallery
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.prevBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.allImagesBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // prevBtn
            // 
            this.prevBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.prevBtn.Location = new System.Drawing.Point(12, 190);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(50, 44);
            this.prevBtn.TabIndex = 0;
            this.prevBtn.Text = "◀";
            this.prevBtn.UseVisualStyleBackColor = true;
            this.prevBtn.Click += new System.EventHandler(this.prevBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.nextBtn.Location = new System.Drawing.Point(738, 190);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(50, 44);
            this.nextBtn.TabIndex = 1;
            this.nextBtn.Text = "▶";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(58, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(680, 349);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // allImagesBtn
            // 
            this.allImagesBtn.Location = new System.Drawing.Point(748, 317);
            this.allImagesBtn.Name = "allImagesBtn";
            this.allImagesBtn.Size = new System.Drawing.Size(40, 38);
            this.allImagesBtn.TabIndex = 3;
            this.allImagesBtn.Text = "All";
            this.allImagesBtn.UseVisualStyleBackColor = true;
            this.allImagesBtn.Click += new System.EventHandler(this.allImagesBtn_Click);
            //
            //pictureBoxes
            //
            int posX = 0, posY = this.pictureBox.Location.Y + this.pictureBox.Height + 10;
            for (int i = 0; i < 10; i++)
            {
                this.pictureBoxes.Add(new PictureBox());
                this.pictureBoxes[i].Size = new System.Drawing.Size(100, 80);
                this.pictureBoxes[i].Location = new System.Drawing.Point(posX, posY);
                posX += 110;
                this.Controls.Add(this.pictureBoxes[i]);
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.allImagesBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.prevBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button allImagesBtn;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
    }
}

