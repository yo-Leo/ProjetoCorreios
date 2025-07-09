using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using static System.Windows.Forms.AxHost;
using System.Diagnostics.Metrics;

namespace ProjetoCorreios
{
    public partial class FormClima : Form
    {

        private const string API_KEY = "9aee5bf9a9d2af52779ced37ef59ef1d";

        public FormClima()
        {

            InitializeComponent();
        
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {

            string cidade = txtCidade.Text;

            if (string.IsNullOrWhiteSpace(cidade))
            {

                MessageBox.Show("Digite o nome de uma cidade.");
                return;
            }

            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cidade},{br},{country code}&appid={API_KEY};

            using (HttpClient client = new HttpClient())
            {

                try
                {

                    HttpResponseMessage resposta = await client.GetAsync(url);
                    resposta.EnsureSuccessStatusCode();

                    string json = await resposta.Content.ReadAsStringAsync();
                    JObject dados = JObject.Parse(json);

                    string descricao = dados["weather"][0]["description"].ToString();
                    string temperatura = dados["main"]["temp"].ToString();

                    txtClima.Text = $"Clima: {descricao}";
                    txtTemp.Text = $"Temperatura: {temperatura} °C";

                }

                catch (Exception ex)
                {

                    MessageBox.Show("Erro ao buscar o clima: " + ex.Message);

                }
            }
        }
    }
}
