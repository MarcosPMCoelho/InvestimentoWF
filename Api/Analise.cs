using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestWF.Api
{
    internal class Analise
    {
        private readonly HttpClient httpClient = new HttpClient();


        internal List<Model.Analise> GetAnalise()
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = httpClient.GetAsync(Config.ReadConfig("Analise") + "?Corretora=" + variaveis.CorretoraId.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var analises = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Analise>>(json);
                    return analises;
                }
                else
                {
                    throw new Exception($"Erro ao obter corretoras: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Analise>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Analise>();
            }
        }
    }
}
