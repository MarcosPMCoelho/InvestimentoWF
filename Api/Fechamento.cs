using InvestWF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestWF.Api
{
    internal class Fechamento
    {

        internal static List<Model.Fechamento> GetFechamentoFechar()
        {
            Business.Variaveis variaveis = Business.Variaveis.Instance;

            try
            {
                using (var client = new HttpClient())
                {

                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var result = client.GetAsync(Config.ReadConfig("Fechamento") + "/Fechar?Corretora=" + variaveis.CorretoraId ).Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var json = result.Content.ReadAsStringAsync().Result;
                        var fechamentos_c = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Fechamento>>(json);
                        return fechamentos_c;
                    }
                    else
                    {
                        MessageBox.Show($"Error calling API: {result.StatusCode}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return new List<Model.Fechamento>();
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Fechamento>();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Fechamento>();
            }
        }

        internal List<Model.Fechamento> GetFechamento()
        {

            try
            {
                using (var httpClient = new HttpClient())
                {
                    Business.Variaveis variaveis = Business.Variaveis.Instance;
                    httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                    httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    var response = httpClient.GetAsync(Config.ReadConfig("Fechamento") + "?Corretora=" + variaveis.CorretoraId.ToString()).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var json = response.Content.ReadAsStringAsync().Result;
                        var fechamentos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Fechamento>>(json);
                        return fechamentos;
                    }
                    else
                    {
                        throw new Exception($"Erro ao obter fechamento: {response.StatusCode}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Fechamento>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Fechamento>();
            }

        }

        internal List<Model.Fechamento> GetMensal()
        {
            return new List<Model.Fechamento>();
        }
    }
}
