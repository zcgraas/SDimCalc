//Grading ID: R1161
//Lab 3
//2/9/20
//199-01
//This program is designed to calculate the radius, diameter, and volume of a sphere when given the radius.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double radius;//variable for storing input radius
            double areap;//power that area calc needs to be raised to
            double volumep;//power that volume calc needs to be raised to
            double diameter;//store diameter calc
            double area;//store area calc
            double volume;//store volume calc
          

            areap = 2;//setting areap = 2
            volumep = 3;//setting volumep = 3
            radius = Convert.ToDouble(txtRadius.Text);//setting radius to user input

            diameter = radius * 2;//calculation for diameter
            area = 4 * Math.PI * (Math.Pow(radius, areap));//calculation for area
            volume = (4 * Math.PI * (Math.Pow(radius, volumep))) / 3;//calculation for volume;

           

            txtDiameter.Text = diameter.ToString("0.00");//converts diameter to string and displays in textbox
            txtSurfaceArea.Text = area.ToString("0.00");//converts surface area to a string and displays in textbox
            txtVolume.Text = volume.ToString("0.00");//converts volume to a string and displays in textbox




            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
