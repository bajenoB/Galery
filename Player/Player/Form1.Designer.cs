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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
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

