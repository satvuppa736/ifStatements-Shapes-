using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifStatements_Shapes_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Red, 12);
            Graphics fg = this.CreateGraphics();

            char colour = Convert.ToChar(colourInput.Text);
            string shape = shapeInput.Text;

            if (colour == 'g' && shape == "circle")
            {
                fg.Clear(Color.HotPink);
                pen.Color = Color.Green;
                fg.DrawEllipse(pen, 200, 300, 100, 100);
            }
            if (colour == 'r' && shape == "circle")
            {
                fg.Clear(Color.HotPink);
                pen.Color = Color.Red;
                fg.DrawEllipse(pen, 200, 300, 100, 100);
            }
            if (colour == 'b' && shape == "circle")
            {
                fg.Clear(Color.HotPink);
                pen.Color = Color.Blue;
                fg.DrawEllipse(pen, 200, 300, 100, 100);
            }

            if (colour == 'g' && shape == "square")
            {
                fg.Clear(Color.HotPink);
                pen.Color = Color.Green;
                fg.DrawRectangle(pen, 200, 300, 100, 100);
            }
            if (colour == 'r' && shape == "square")
            {
                fg.Clear(Color.HotPink);
                pen.Color = Color.Red;
                fg.DrawRectangle(pen, 200, 300, 100, 100);
            }
            if (colour == 'b' && shape == "square")
            {
                fg.Clear(Color.HotPink);
                pen.Color = Color.Blue;
                fg.DrawRectangle(pen, 200, 300, 100, 100);
            }
        }
    }
}
