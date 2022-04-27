using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            // displays the location, current temperature and the max and min along with what icon it shows
            cityOutput.Text = Form1.days[0].location;

            double currentTemp = Convert.ToDouble(Form1.days[0].currentTemp);
            double temp = Math.Round(currentTemp);

            double maxTemp = Convert.ToDouble(Form1.days[0].tempHigh);
            double max = Math.Round(maxTemp);

            double minTemp = Convert.ToDouble(Form1.days[0].tempLow);
            double min = Math.Round(minTemp);

            tempLabel.Text = $"{temp.ToString()}°";
            minOutput.Text = $"{min.ToString()}°";
            maxOutput.Text = $"{max.ToString()}°";

            pictureBox1.Image = Form1.days[0].image;
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        
    }
}
