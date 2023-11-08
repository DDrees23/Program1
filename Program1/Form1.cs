using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//K7151
//CIS-199-01
//Program1
//9/29/2022
//This program is a simple program to dsiplay the surface area, diameter, and volume of a circle when given the radius.

namespace Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double ILLUMINATED = 75;
            
            string widthInput;
            widthInput = widthInputTextBox.Text;

            double width;
            width = double.Parse(widthInput);


            string lengthInput;
            lengthInput = lengthInputTextBox.Text;

            double length;
            length = double.Parse(lengthInput);


            string colorInput;
            colorInput = colorInputTextBox.Text;

            int color;
            color = int.Parse(colorInput);


            string paintInput;
            paintInput = paintInputTextBox.Text;

            double paint;
            paint = double.Parse(paintInput);


            string coatsInput;
            coatsInput = coatsInputTextBox.Text;

            int coats;
            coats = int.Parse(coatsInput);


            string illuminateInput;
            illuminateInput = illuminateInputTextBox.Text;

            int illuminate;
            illuminate = int.Parse(illuminateInput);

            //gave all the input text boxes string values to plug into the equations later and made the values of each textbox convert to the correct data types (double, int).


            double area = length * width;
            string output1 = $"{area:F1}";

            areaOutput.Text = output1;

            //calculated square area and put the value into the first output box as a text with one decimal(F1).

            double costs = area * paint * 0.10 + area * paint + color * 8.50;
            string output2 = $"{costs:C}";

            paintingCostsOutput.Text = output2;

            //calculated painting costs and displayed it as a currency. 

            double layers = coats * 10;
            string output3 = $"{layers:C}";

            coatsOutput.Text = output3;

            //calculated coats cost and diaplayed it as a currency.

            double labor = 6.50 * area + illuminate * ILLUMINATED;
            string output4 = $"{labor:C}";

            laborCostsOutput.Text = output4;

            //calculated labor costs and displayed it as a currency

            double total = costs + layers + labor;
            string output5 = $"{total:C}";

            totalCostsOutput.Text = output5;

            //calculated total costs and diaplyed it as a currency.
        }
    }
}
