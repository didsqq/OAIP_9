﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ОАИП._2лаба.Фигуры;

namespace ОАИП._2лаба
{
    public partial class FormTriangle : Form
    {
        public FormTriangle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxX.Text, out int x)
                 && int.TryParse(textBoxY.Text, out int y)
                 && int.TryParse(textBoxL.Text, out int l)
                 && int.TryParse(textBoxZ.Text, out int z))
            {
                if (x + l < Init.pictureBox.Width && y + l < Init.pictureBox.Height && x > 0 && y > 0)
                {
                    Triangle triangle = new Triangle(x, y, l, z);
                    ShapeContainer.AddFigure(triangle);
                    Init.comboBox1.Items.Add("Треугольник");
                    triangle.Draw();
                    Close();
                }
                else
                {
                    textBoxX.Text = "";
                    textBoxY.Text = "";
                    textBoxL.Text = "";
                    textBoxZ.Text = "";
                    MessageBox.Show("Выход за границы");
                }
            }
            else
            {
                textBoxX.Text = "";
                textBoxY.Text = "";
                textBoxL.Text = "";
                textBoxZ.Text = "";
            }
        }
    }
}
