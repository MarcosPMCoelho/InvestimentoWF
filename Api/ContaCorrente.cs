using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestWF.Api
{
    internal class ContaCorrente
    {
        private readonly HttpClient httpClient = new HttpClient();

        internal List<Model.ContaCorrente> GetContaCorrente()
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = httpClient.GetAsync(Config.ReadConfig("ContaCorrente") + "?corretora=" + variaveis.CorretoraId.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var contaCorrentes = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.ContaCorrente>>(json);
                    return contaCorrentes;
                }
                else
                {
                    throw new Exception($"Erro ao obter conta-corrente: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.ContaCorrente>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.ContaCorrente>();
            }

        }

        internal bool UpdateContaCorrente(Model.ContaCorrente contaCorrente)
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(contaCorrente);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = httpClient.PutAsync(Config.ReadConfig("ContaCorrente"), content).Result;
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal bool CreateContaCorrente(Model.ContaCorrente contaCorrente)
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(contaCorrente);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                var response = httpClient.PostAsync(Config.ReadConfig("ContaCorrente"), content).Result;
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        internal bool DeleteContaCorrente(int contaCorrenteId)
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var response = httpClient.DeleteAsync(Config.ReadConfig("ContaCorrente") + "?ID=" + contaCorrenteId.ToString() + "&corretora=" + variaveis.CorretoraId).Result;
                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        internal Model.ContaCorrente GetContaCorrenteById(int Id)
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = httpClient.GetAsync(Config.ReadConfig("ContaCorrente") + "?corretora=" + variaveis.CorretoraId.ToString() + "&ID=" + Id.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var contaCorrentes = Newtonsoft.Json.JsonConvert.DeserializeObject<Model.ContaCorrente>(json);
                    return contaCorrentes;
                }
                else
                {
                    throw new Exception($"Erro ao obter conta-corrente: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Model.ContaCorrente();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Model.ContaCorrente();
            }

        }

        internal decimal GetContaCorrenteSaldo()
        {
            try
            {
                Business.Variaveis variaveis = Business.Variaveis.Instance;
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", variaveis.Token);
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));


                var response = httpClient.GetAsync(Config.ReadConfig("ContaCorrente") + "/Saldo?corretora=" + variaveis.CorretoraId.ToString()).Result;
                if (response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var contaCorrentes = Newtonsoft.Json.JsonConvert.DeserializeObject<decimal>(json);
                    return contaCorrentes;
                }
                else
                {
                    throw new Exception($"Erro ao obter conta-corrente: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0M;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0M;
            }

        }
    }
}
