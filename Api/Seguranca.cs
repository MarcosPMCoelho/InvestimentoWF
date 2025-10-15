using InvestWF.Model;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestWF.Api
{
    internal class Seguranca
    {
        private readonly HttpClient client = new HttpClient();
        internal async Task<Token> GetToken(Model.Seguranca seguranca)
        {
            string responseBody= "";
            try
            {
                using (var client = new HttpClient())
                {
                    var serializedSeguranca = Newtonsoft.Json.JsonConvert.SerializeObject(seguranca);
                    var content = new StringContent(serializedSeguranca, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(Config.ReadConfig("Seguranca"), content);
                    if (!result.IsSuccessStatusCode)
                    {
                        MessageBox.Show($"Error calling API: {result.StatusCode}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return new Token();
                    }
                    responseBody = await result.Content.ReadAsStringAsync();
                    Token token = Newtonsoft.Json.JsonConvert.DeserializeObject<Token>(responseBody);   
                    return token; 
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Token();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Token();
            }
        }
    }
}
