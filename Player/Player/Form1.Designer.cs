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
            this.button1.Click += button1_Click;

            this.button2.Location = new Point(208, 128);
            this.button2.Size = new Size(104, 23);
            this.button2.Text = "Remove Image";
            this.button2.Click += button2_Click; 

            this.button3.Location = new Point(320, 128);
            this.button3.Text = "Clear List";
            this.button3.Click += button3_Click;

            this.button4.Location = new Point(16, 128);
            this.button4.Text = "Open Image";
            this.button4.Click += button4_Click;

            

            this.imageList1.ImageSize = new Size(30, 30);
            this.imageList1.TransparentColor = Color.Transparent;

            this.panel1.Location = new Point(8, 240);
            this.panel1.Size = new Size(296, 184);

            this.label5.Location = new Point(168, 168);
            this.label5.Size = new Size(312, 40);
            this.label5.Text = "label5";

            
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.ResumeLayout(false);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (imageList1.Images.Empty != true)
            {
                if (imageList1.Images.Count - 1 > currentImage)
                {
                    currentImage++;
                }
                else
                {
                    currentImage = 0;
                }
                panel1.Refresh();

                
                imageList1.Draw(myGraphics, 10, 10, currentImage);

                
                
                label3.Text = "Current image is " + currentImage;
                listBox1.SelectedIndex = currentImage;
                label5.Text = "Image is " + listBox1.Text;
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            imageList1.Images.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

       
        private void button3_Click(object sender, System.EventArgs e)
        {
            imageList1.Images.Clear();
            listBox1.Items.Clear();
        }

       
        private void button4_Click(object sender, System.EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.FileNames != null)
                {
                    for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                    {
                        addImage(openFileDialog1.FileNames[i]);
                    }
                }
                else
                {
                    addImage(openFileDialog1.FileName);
                }
            }
        }

        private void addImage(string imageToLoad)
        {
            if (imageToLoad != "")
            {
                imageList1.Images.Add(Image.FromFile(imageToLoad));
                listBox1.BeginUpdate();
                listBox1.Items.Add(imageToLoad);
                listBox1.EndUpdate();
            }
        }

        ListBox listBox1;
        Label label3;
        Button button1;
        Button button2;
        Button button3;
        Button button4;
      
        ImageList imageList1;
        OpenFileDialog openFileDialog1;
        protected Graphics myGraphics;
        Panel panel1;
        Label label5;

        #endregion
    }
}

