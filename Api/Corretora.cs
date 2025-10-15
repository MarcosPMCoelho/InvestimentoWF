using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvestWF.Api
{
    internal class Corretora
    {
		private readonly HttpClient httpClient = new HttpClient();

        internal List<Model.Corretora> GetCorretoras()
        {
			try
			{
				var response = httpClient.GetAsync(Config.ReadConfig("Corretora")).Result;
				if (response.IsSuccessStatusCode)
				{
					var json = response.Content.ReadAsStringAsync().Result;
					var corretoras = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Model.Corretora>>(json);
					return corretoras;
				}
				else
				{
					throw new Exception($"Erro ao obter corretoras: {response.StatusCode}");
                }
            }
            catch (HttpRequestException ex) 
            {
                MessageBox.Show($"Error calling API: {ex.Message}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Corretora>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Model.Corretora>();
            }
        }
    }
}
