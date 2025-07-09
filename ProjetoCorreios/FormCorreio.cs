using Newtonsoft.Json;
using System.Net;

namespace ProjetoCorreios
{
    public partial class FormCorreio : Form
    {

        public FormCorreio()
        {

            InitializeComponent();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            string cep = txtCEP.Text.Trim().Replace("-", "");

            if (cep.Length != 8)
            {

                MessageBox.Show("CEP inválido!");

                return;

            }

            try
            {
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString($"https://viacep.com.br/ws/{cep}/json/"); 
                    var endereco = JsonConvert.DeserializeObject<Endereco>(json);

                    if (endereco.cep == null)
                    {
                        MessageBox.Show("CEP não encontrado.");
                        return;
                    }

                    txtLogradouro.Text = endereco.logradouro;
                    txtBairro.Text = endereco.bairro;
                    txtCidade.Text = endereco.localidade;
                    txtEstado.Text = endereco.uf;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao buscar o CEP: " + ex.Message);
            }
        }

        public class Endereco
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string complemento { get; set; }
            public string bairro { get; set; }
            public string localidade { get; set; }
            public string uf { get; set; }

        }
    }
}
