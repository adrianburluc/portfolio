using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Web.Script.Serialization;

namespace WeatherApp
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            container.Visible = false;
        }

        protected void afiseaza_vremea_Click(object sender, EventArgs e)
        {
            string appid = "7672f99cb58193d754c2e5babb397d1e";
            string oras = textbox.Text;
            string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q=" + oras + "&units=metric&appid=" + appid);

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                Root weatherinfo = (new JavaScriptSerializer()).Deserialize<Root>(json);

                if(container.Visible==false)
                {
                    container.Visible = true;
                }
                lbl_oras.InnerText=weatherinfo.name+" ("+weatherinfo.sys.country+")";
                img_icon_vreme.ImageUrl = "http://openweathermap.org/img/wn/" + weatherinfo.weather[0].icon + "@2x.png";
                lbl_vreme.InnerText = "Status: " + weatherinfo.weather[0].description;
                lbl_temp.InnerText = weatherinfo.main.temp + " °C";
                lbl_max_temp.InnerText = "Max: " + weatherinfo.main.temp_max + " °C";
                lbl_min_temp.InnerText = "Min: " + weatherinfo.main.temp_min + " °C";
                lbl_vant.InnerText = "Vant: " + weatherinfo.wind.speed + " m/s";
                lbl_umiditate.InnerText = "Umiditate: " + weatherinfo.main.humidity + "%";
                lbl_innorat.InnerText = "Innorat: " + weatherinfo.clouds.all + "%";
            }
        }

        public class Weather
        {
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class MainZ
        {
            public double temp { get; set; }
            public double temp_min { get; set; }
            public double temp_max { get; set; }
            public double humidity { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
        }

        public class Clouds
        {
            public double all { get; set; }
        }

        public class Sys
        {
            public string country { get; set; }
        }

        public class Root
        {
            public List<Weather> weather { get; set; }
            public MainZ main { get; set; }
            public Wind wind { get; set; }
            public Clouds clouds { get; set; }
            public Sys sys { get; set; }
            public string name { get; set; }
        }
    }
}