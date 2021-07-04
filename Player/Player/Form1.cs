using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            imageList1 = new ImageList();

            
            imageList1.ImageSize = new Size(255, 255);
            imageList1.TransparentColor = Color.White;

           
            myGraphics = Graphics.FromHwnd(panel1.Handle);
        }

    }
}
