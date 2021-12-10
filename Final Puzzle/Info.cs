using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
namespace Final_Puzzle
{
    public partial class Info : Form
    {
        public Info(string planet)
        {

            InitializeComponent();
            tampilkanPlanet(planet);
        }
        private void tampilkanPlanet(string planet)
        {
            var client = new RestClient(@"https://fearhunt-planet-v1.herokuapp.com/api/planet/" + planet);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            JsonObject obj = (JsonObject)SimpleJson.DeserializeObject(response.Content);
            lblDiameter.Text = (string)obj["diameter"];
            lblJarak.Text = (string)obj["distance"];
            lblMassa.Text = (string)obj["mass"];
            lblPeriode.Text = (string)obj["period"];
            lblTemp.Text = (string)obj["temperature"];
            lblPlanet.Text = planet;
        }
    }
}
