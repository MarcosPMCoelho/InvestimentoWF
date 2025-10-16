using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestWF.Api
{
    internal class Cotacao
    {
        private readonly HttpClient httpClient = new HttpClient();


        internal List<Model.Cotacao> GetCotacao()
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = httpClient.GetAsync(Config.ReadConfig("Cotacao")).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var cotacoes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Cotacao>>(json);
                    return cotacoes;
                }
                else
                {
                    throw new Exception($"Erro ao obter corretoras: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Cotacao>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Cotacao>();
            }
        }

        internal List<Model.Cotacao> GetPendente()
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = httpClient.GetAsync(Config.ReadConfig("Cotacao") + "/Pendente").Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var cotacoes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Cotacao>>(json);
                    return cotacoes;
                }
                else
                {
                    throw new Exception($"Erro ao obter corretoras: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Cotacao>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Cotacao>();
            }
        }

        internal Model.Cotacao GetById(int Id)
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var response = httpClient.GetAsync(Config.ReadConfig("Cotacao") + "/Id?ID=" + Id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var cotacoes = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.Cotacao>(json);
                    return cotacoes;
                }
                else
                {
                    throw new Exception($"Erro ao obter corretoras: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Model.Cotacao();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Model.Cotacao();
            }
        }
    }
}
