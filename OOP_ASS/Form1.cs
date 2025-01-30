using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ASS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(txtLength.Text);
            double width = Convert.ToDouble(txtWidth.Text);
            double area = CalculateArea(length, width);
            DisplayResult($"Rectangle: {area}");
        }

        private void circle_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(txtRadius.Text);
            double area = CalculateArea(radius);
            DisplayResult($"Circle: {area}");
        }

        private void triangle_Click(object sender, EventArgs e)
        {
            double baseLength = Convert.ToDouble(txtBase.Text);
            double height = Convert.ToDouble(txtHeight.Text);
            double area = CalculateArea(baseLength, height, true);
            DisplayResult($"Triangle: {area}");
        }
        private double CalculateArea(double length, double width)
        {
            return length * width;
        }
        private double CalculateArea(double radius)
        {
            double pi = 3.14159;
            return pi * radius * radius;
        }
        private double CalculateArea(double baseLength, double height, bool isTriangle)
        {
            return 0.5 * baseLength * height;
        }
        private void DisplayResult(string result)
        {
            listBoxResult.Items.Add(result);
            txtResult.Text = result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtRadius_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
