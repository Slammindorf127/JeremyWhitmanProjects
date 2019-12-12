using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Net;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Flight> dataList = new List<Flight> { };
        //Direct Flights
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Flight i in dataList)
            {
                //MessageBox.Show("city1" + i.city1);
                //MessageBox.Show("city2" + i.city2);
                if( i.city1 == textBox1.Text && i.city2 == textBox2.Text)
                {
                    MessageBox.Show("Flight from " + i.city1 + " to " + i.city2 + " is " + i.fare);
                    //listBox1.DataSource = "";
                    //listBox1.DataSource = i;
                    //MessageBox.Show("Got into if");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            //string data = client.DownloadString("https://data.transportation.gov/resource/4f3n-jbg2.json?year=2018");
            string data = System.IO.File.ReadAllText("flightData.json");
            dataList = new JavaScriptSerializer().Deserialize<List<Flight>>(data);
            listBox1.DataSource = dataList;
        }
        //Non-Direct Flights
        private void button2_Click(object sender, EventArgs e)
        {
            bool founddest = false;
            string totalflight = "";
            List<Flight> cities = new List<Flight> { };
            List<string> visited = new List<string> { };
            foreach(Flight flights in dataList)
            {
                if(flights.city1 == textBox1.Text)
                {
                    cities.Add(flights);
                }
            }
            visited.Add(textBox1.Text);
            while (cities.Count != 0 && founddest == false)
            {
                Flight currentcity = cities[0];
                cities.RemoveAt(0);
                totalflight = totalflight + "" + currentcity.city1 + '\n';
                if(currentcity.city2 == textBox2.Text)
                {
                    founddest = true;
                }
                if(currentcity.city2 != textBox2.Text && visited.Contains(currentcity.city1) == false)
                {
                    foreach(Flight flights in dataList)
                    {
                        if(flights.city1 == currentcity.city1 && dataList.Contains(flights) == false)
                        {
                            dataList.Add(flights);
                        }
                    }
                }
            }
            MessageBox.Show(totalflight);
        }
    }
}
