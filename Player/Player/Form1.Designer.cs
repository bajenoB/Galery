using System;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;
namespace Player
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private int currentImage = 0;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 461);
            this.Text = "Form1";

            this.listBox1 = new ListBox();
            this.label3 = new Label();
            this.button1 = new Button();
            this.button2 = new Button();
            this.button3 = new Button();
            this.button4 = new Button();
            this.pictureBox1 = new PictureBox();
            this.imageList1 = new ImageList(this.components);

            this.panel1 = new Panel();
            this.label5 = new Label();
            this.listBox1.Location = new Point(16, 16);
            this.listBox1.Size = new Size(400, 95);
            this.listBox1.TabIndex = 0;

            this.label3.Location = new Point(24, 168);
            this.label3.Text = "label3";

            this.button1.Location = new Point(96, 128);
            this.button1.Size = new Size(104, 23);
            this.button1.Text = "Show Next Image";
            this.button1.Click += Button1_Click;

            this.button2.Location = new Point(208, 128);
            this.button2.Size = new Size(104, 23);
            this.button2.Text = "Remove Image";
            this.button2.Click += Button2_Click; 

            this.button3.Location = new Point(320, 128);
            this.button3.Text = "Clear List";
            this.button3.Click += Button3_Click;

            this.button4.Location = new Point(16, 128);
            this.button4.Text = "Open Image";
            this.button4.Click += Button4_Click;

            this.pictureBox1.Location = new Point(328, 232);
            this.pictureBox1.Size = new Size(336, 192);

            this.imageList1.ImageSize = new Size(16, 16);
            this.imageList1.TransparentColor = Color.Transparent;

            this.panel1.Location = new Point(8, 240);
            this.panel1.Size = new Size(296, 184);

            this.label5.Location = new Point(168, 168);
            this.label5.Size = new Size(312, 40);
            this.label5.Text = "label5";

            
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.ResumeLayout(false);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        ListBox listBox1;
        Label label3;
        Button button1;
        Button button2;
        Button button3;
        Button button4;
        PictureBox pictureBox1;
        ImageList imageList1;
        OpenFileDialog openFileDialog1;
        protected Graphics myGraphics;
        Panel panel1;
        Label label5;

        #endregion
    }
}

