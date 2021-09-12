using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        double converter(string unit, double number, int dimension)
        {
            double converted;
            if (dimension == 1)
                // distance conversion
            {
                if ("mm" == unit)
                    converted = number* Math.Pow(10, 3);

                else if ("cm" == unit)
                    converted = number * Math.Pow(10, 2);

                else if ("m" == unit)
                    converted = number*Math.Pow(10, 0);

                else if ("km" == unit)
                    converted = number * Math.Pow(10, -3);
                else
                    converted = number * 1;
                return converted;
            }
            else if(dimension == 2)
                // area conversion 
            {
                if ("mm²" == unit)
                    converted = number * Math.Pow(10, 6);

                else if ("cm²" == unit)
                    converted = number * Math.Pow(10, 4);

                else if ("m²" == unit)
                    converted = number * Math.Pow(10, 0);

                else if ("km²" == unit)
                    converted = number * Math.Pow(10, -6);
                else
                    converted = 1;
                return converted;

            }
            else //volume conversion is default 
            {
                if ("mm³" == unit)
                    converted = number * Math.Pow(10, 9);

                else if ("cm³" == unit)
                    converted = number * Math.Pow(10, 8);

                else if ("m³" == unit)
                    converted = number * Math.Pow(10, 0);

                else if ("km³" == unit)
                    converted = number * Math.Pow(10, -9);
                else
                    converted = 1;
                return converted;

            }
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcArea(object sender, EventArgs e)
        {
            double  area, side, diagnol, cubeDiagnol;
            

            try
            {
                alertText.Text = " ";

                side = converter(sideCombo.SelectedItem.ToString(), Int32.Parse(sideText.Text), 1);

                area = converter(areaCombo.SelectedItem.ToString(), side*side, 2);

                diagnol = converter(diagnolCombo.SelectedItem.ToString(), 1.414213 * side, 1);

                cubeDiagnol = converter(cubeDiagnolCombo.SelectedItem.ToString(), 1.7320508 * side, 1);

                areaLabel.Text = area.ToString();

                diagnolLabel.Text = diagnol.ToString();

                cubeDiagnolLabel.Text = cubeDiagnol.ToString();

            }
            catch
            {
                alertText.Text = "Invalid input";
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sideCombo.SelectedIndex = 2;
            areaCombo.SelectedIndex = 2;
            diagnolCombo.SelectedIndex = 2;
            cubeDiagnolCombo.SelectedIndex = 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
