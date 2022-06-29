using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Weather
{
    public partial class Form1 : Form
    {
        public Weather_Info currentWeatherInfo;

        public string results;

        public Form1(Weather_Info passcurrentWeather)

        {
            InitializeComponent();
            currentWeatherInfo = passcurrentWeather;
            results = "";
        }

        private void userLocationBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void userLocationBox_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void fetchWeather_Click(object sender, EventArgs e)
        {
            if(userLocationBox.Text == "")
            {
                MessageBox.Show("Box Cannot Be empty, try again");
            }
            else
            {
                 
                currentWeatherInfo.userLoc = this.userLocationBox.Text;
                currentWeatherInfo.generate(this);
                this.userLocationBox.Visible = false;
                this.fetchWeather.Visible = false;
                this.howToLabel.Visible = false;


                this.resultsLabel.Visible = true;
                this.resultsLabel.Text = results;

            }
        }

        private void userLocationBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.fetchWeather.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void howToLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
