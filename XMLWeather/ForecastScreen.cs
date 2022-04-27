using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{ 
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            // displays the date and the high and low temperatures of the next two days

            date1.Text = Form1.days[1].date;
            double minTemp = Convert.ToDouble(Form1.days[1].tempLow);
            double maxTemp = Convert.ToDouble(Form1.days[1].tempHigh);
            min1.Text = Math.Round(minTemp).ToString();
            max1.Text = Math.Round(maxTemp).ToString();
           

            date2.Text = Form1.days[2].date;
            minTemp = Convert.ToDouble(Form1.days[2].tempLow);
            maxTemp = Convert.ToDouble(Form1.days[2].tempHigh);
            min2.Text = Math.Round(minTemp).ToString();
            max2.Text = Math.Round(maxTemp).ToString();
        
            pictureBox1.Image = Form1.days[1].image;
            pictureBox2.Image = Form1.days[2].image;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
