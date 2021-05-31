using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphicDesigns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(0, 0, 0, 0), 6);
            SolidBrush theBrush = new SolidBrush(Color.White);

            g.Clear(Color.Gray);


            g.TranslateTransform(35, 250);
            g.RotateTransform(-45); // Rotate the Domino 45 Degrees

            theBrush.Color = Color.White; // White Outline
            g.FillRectangle(theBrush, 10, 0, 275, 150);
            g.FillRectangle(theBrush, 0, 10, 295, 130);
            g.FillPie(theBrush, 0, 0, 20, 20, 180, 90);
            g.FillPie(theBrush, 0, 130, 20, 20, 90, 90);
            g.FillPie(theBrush, 275, 130, 20, 20, 0, 90);
            g.FillPie(theBrush, 275, 0, 20, 20, -90, 90);


            theBrush.Color = Color.SteelBlue; // Blue Domino
            g.FillRectangle(theBrush, 10, 5, 135, 140);
            g.FillRectangle(theBrush, 5, 10, 140, 130);

            g.FillPie(theBrush, 5, 5, 10, 10, 180, 90);
            g.FillPie(theBrush, 5, 135, 10, 10, 90, 90);


            theBrush.Color = Color.Tomato; // Red Domino
            g.FillRectangle(theBrush, 10+145-5, 5, 135, 140);
            g.FillRectangle(theBrush, 5+145, 10, 140, 130);
            g.FillPie(theBrush, 280-1, 135-1, 11, 10, 0, 90);
            g.FillPie(theBrush, 280-1, 5, 11, 10, -90, 90);


            theBrush.Color = Color.White; // Three Domino Dots
            g.FillEllipse(theBrush, 25, 25, 45, 45);
            g.FillEllipse(theBrush, 80, 80, 45, 45);
            g.FillEllipse(theBrush, 52+145, 52, 45, 45);

            g.ResetTransform();

            Font drawFont = new Font("Segoe UI Black", 48); // Domino's Text
            g.DrawString("Domino's", drawFont, theBrush, 25, 350);

        }
    }
}
