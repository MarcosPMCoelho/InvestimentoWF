using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestWF.Api
{
    internal class Extrato
    {
        private readonly HttpClient httpClient = new HttpClient();

        internal List<Model.Extrato> GetDays(int qtd)
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = httpClient.GetAsync(Config.ReadConfig("Extrato") + "?QtdDias=" + qtd.ToString() + "&Corretora=" + variaveis.CorretoraId.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var extratos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Extrato>>(json);
                    return extratos;
                }
                else
                {
                    throw new Exception($"Erro ao obter extrato: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Extrato>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Extrato>();
            }
        }
    }
}
